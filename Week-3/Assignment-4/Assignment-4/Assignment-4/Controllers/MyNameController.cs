using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_4.Controllers
{
    public class MyNameController : Controller
    {
        [HttpGet("{myName}")]
        public ActionResult Index(string myName)
        {
            string name = Request.Cookies["name"];

            if (!string.IsNullOrEmpty(myName))
            {
                ViewBag.Name = name;
            }

            return View();
        }

        public ActionResult SetName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                var cookieOptions = new CookieOptions();
                cookieOptions.Expires = DateTime.Now.AddDays(7);
                cookieOptions.Path = "/";
                Response.Cookies.Append("name", name, cookieOptions);
            }
            return RedirectToAction("Index");
        }
    }
}
