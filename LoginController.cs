using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using OnlineStudentEnrollmentSystem.Models;
using OnlineStudentEnrollmentSystem.Entities;
=======
using SchoolWebApplication.Models;
using WebApplication1.Entities;
>>>>>>> 888fb61ad308486e5a4b7694bdf6bb986f215ab4

namespace WebApplication1
{
    public class LoginController : Controller
    {
        public IActionResult UserLogin()
        {
            return View(new UserLoginModel());
        }


        [HttpPost]
        public IActionResult SubmitUser(UserLoginModel userLoginModel)
        {
            var dbContext = new SchoolDBContext();
            User userObj = dbContext.Users.FirstOrDefault(p => p.UserName == userLoginModel.UserName && p.Password == userLoginModel.Password);

            if (userObj == null)
            {
                ModelState.AddModelError("", "Entered User name and password doesn't match");
                return View("UserLogin", userLoginModel);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }
    }
}
