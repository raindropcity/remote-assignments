using Assignment_1.Data;
using Assignment_1.Models;
using Assignment_1.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment_1.Controllers
{
    public class UsersController : Controller
    {
        private readonly AssignmentDbContext assignmentDbContext;
        public UsersController(AssignmentDbContext assignmentDbContext)
        {
            this.assignmentDbContext = assignmentDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PostUserData(AddUserViewModel addUserRequest)
        {
            var user = new User()
            {
                Id = Guid.NewGuid(),
                Email = addUserRequest.Email,
                Password = addUserRequest.Password
            };

            await assignmentDbContext.Users.AddAsync(user);
            await assignmentDbContext.SaveChangesAsync();
            Console.WriteLine("123");
            return Content("post complete");
            //return RedirectToAction("Add");
            // 記得改成redirect到"member page" 寫welcome
        }
    }
}
