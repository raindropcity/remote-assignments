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
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Member()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(AddUserViewModel addUserRequest)
        {
            var user = new User()
            {
                Id = Guid.NewGuid(),
                Email = addUserRequest.Email,
                Password = addUserRequest.Password
            };

            if (!assignmentDbContext.Users.Any(e => e.Email == user.Email))
            {
                await assignmentDbContext.Users.AddAsync(user);
                await assignmentDbContext.SaveChangesAsync();
                return RedirectToAction("Member");
            }

            return Content("The email address has been registered");
        }

        [HttpPost]
        public IActionResult SignIn(User signInRequest)
        {
            var user = new User()
            {
                Id = Guid.NewGuid(),
                Email = signInRequest.Email,
                Password = signInRequest.Password
            };

            bool comfirmEmailandPassword = assignmentDbContext.Users.Any(e => e.Email == user.Email && e.Password == user.Password);

            if (comfirmEmailandPassword)
            {
                return RedirectToAction("Member");
            }

            return Content("Please check your Email or Password");
        }
    }
}
