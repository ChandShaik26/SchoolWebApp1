using Microsoft.AspNetCore.Mvc;
using SchoolWebApplication.Models;
using WebApplication1.Entities;

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
