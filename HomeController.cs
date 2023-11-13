using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using OnlineStudentEnrollmentSystem.Entities;
using OnlineStudentEnrollmentSystem.Models;
=======
using WebApplication1.Entities;
using WebApplication1.Models;
>>>>>>> 888fb61ad308486e5a4b7694bdf6bb986f215ab4
using System.Runtime.InteropServices;

namespace WebApplication1
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            var indexModel = new DashboardModel();

            var dbContext = new SchoolDBContext();

            var teacher = dbContext.Teachers.ToList();
            indexModel.Teachers =  teacher;
            indexModel.TotalTeachers = teacher.Count;

            var classes = dbContext.Classes.ToList();
            indexModel.Classes = classes;   
            indexModel.TotalClasses = classes.Count;

            indexModel.TotalStudents = dbContext.Students.Count();
            return View(indexModel);
        }
    }
}
