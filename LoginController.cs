using Microsoft.AspNetCore.Mvc;
using SchoolWebApplication.Models;
using WebApplication1.Entities;

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
