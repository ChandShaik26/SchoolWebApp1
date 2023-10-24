using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineStudentEnrollmentSystem.Entities;
using OnlineStudentEnrollmentSystem.Models;

namespace OnlineStudentEnrollmentSystem
{
    public class ClassController : Controller
    {
        public IActionResult ClassList()
        {

            var dbContext = new SchoolDBContext();

            var classes = dbContext.Classes.ToList();

            return View(classes);
        }

        public IActionResult AddClass()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveChanges(AddClassModel model) 
        {
            var classC = new Class();

            classC.ClassId = model.ClassId;
            classC.ClassName = model.Name;   
            classC.Standard = model.Standard;

            var dbContext = new SchoolDBContext();
            dbContext.Classes.Add(classC);

            dbContext.SaveChanges();

            return RedirectToAction("ClassList");
        }

        public IActionResult EditClass(int ClassId)
        {

            var dbContext = new SchoolDBContext();

            var classObj = dbContext.Classes.Where(p => p.ClassId == ClassId).FirstOrDefault();
            var model = new AddClassModel();

            model.ClassId = classObj.ClassId;
            model.Name = classObj.ClassName;
            model.Standard = classObj.Standard;

            return View(model);
        }


        [HttpPost]
        public IActionResult UpdateClass(AddClassModel model) 
        {
            var dbContext = new SchoolDBContext();

            var classObj = dbContext.Classes.Where(p => p.ClassId == model.ClassId).FirstOrDefault();

            classObj.ClassId = model.ClassId;
            classObj.ClassName = model.Name;
            classObj.Standard = model.Standard;

            dbContext.Classes.Update(classObj);
            dbContext.SaveChanges();

            return RedirectToAction("ClassList");
        }


        [HttpPost]
        public IActionResult DeleteClass(int ClassId)
        {
            var dbContext = new SchoolDBContext();

            var classObj = dbContext.Classes.Where(p => p.ClassId == ClassId).FirstOrDefault();

            dbContext.Classes.Remove(classObj);
            dbContext.SaveChanges();
            return Json(true);
        }

        public IActionResult ClassDetail(int classId)
        {
            var dbContext = new SchoolDBContext();

            var classObj = dbContext.Classes.Include(p => p.Students).FirstOrDefault(p => p.ClassId == classId);
           
            return View(classObj);
        }

    }

}
