using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entities;
using WebApplication1.Models;
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
