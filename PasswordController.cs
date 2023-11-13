using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1
{
    public class PasswordController : Controller
    {
        
        public IActionResult ForgotPassword(PasswordModel passwordModel)
        {
            var dbContext = new SchoolDBContext();
            var userObj = dbContext.Users.Where(p => p.EmailId == passwordModel.EmailId).FirstOrDefault();
            if (userObj != null)
            {
                ModelState.AddModelError("", "Entered email doesn't match with any user");
                return View("ForgotPassword", passwordModel );
            }

            else
            {
                return RedirectToAction("PasswordCorrection");
            }
           
        }

        
        public IActionResult PasswordCorrection(PasswordCorrectionModel passwordCorrectionModel)
        {
            var dbContext = new SchoolDBContext();

            var userObj = dbContext.Users.Where(p => p.EmailId == passwordCorrectionModel.EmailId).FirstOrDefault();
            userObj.EmailId = passwordCorrectionModel.EmailId;
            userObj.Password = passwordCorrectionModel.Password;
            dbContext.Update(userObj);
            dbContext.SaveChanges();


            return View("UserLogin", "Login");
        }
    }
}
