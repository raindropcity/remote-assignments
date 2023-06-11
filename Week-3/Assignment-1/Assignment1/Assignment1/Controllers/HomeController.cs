using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}