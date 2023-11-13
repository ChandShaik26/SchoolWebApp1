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
    public class RegisterController : Controller
    {

        
        public IActionResult UserRegister()
        {
            var model = new UserRegisterModel();

            return View(model);
        }

        [HttpPost]
        public IActionResult SaveUser(UserRegisterModel userRegisterModel)
        {
            var dbContext = new SchoolDBContext();
            User newUser = new User();
            newUser.UserName = userRegisterModel.UserName;
            newUser.EmailId = userRegisterModel.EmailId;
            newUser.Password = userRegisterModel.Password;

            dbContext.Users.Add(newUser);
            dbContext.SaveChanges();

            return RedirectToAction("UserLogin", "Login" );
        }
    }
}
