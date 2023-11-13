using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
using OnlineStudentEnrollmentSystem.Entities;
using OnlineStudentEnrollmentSystem.Models;

namespace OnlineStudentEnrollmentSystem
{
    public class ClassController : Controller
    {
        public IActionResult ClassList()
=======
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1
{
    public class ClassController : Controller
    {
        public IActionResult ClassIndex()
>>>>>>> 888fb61ad308486e5a4b7694bdf6bb986f215ab4
        {

            var dbContext = new SchoolDBContext();

<<<<<<< HEAD
            var classes = dbContext.Classes.ToList();

            return View(classes);
=======
            IList<Class> cs = dbContext.Classes.ToList();

            return View(cs);
>>>>>>> 888fb61ad308486e5a4b7694bdf6bb986f215ab4
        }

        public IActionResult AddClass()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveChanges(AddClassModel model) 
        {
            var classC = new Class();

<<<<<<< HEAD
            classC.ClassId = model.ClassId;
=======
            //classC.ClassId = model.ClassId;
>>>>>>> 888fb61ad308486e5a4b7694bdf6bb986f215ab4
            classC.ClassName = model.Name;   
            classC.Standard = model.Standard;

            var dbContext = new SchoolDBContext();
            dbContext.Classes.Add(classC);

            dbContext.SaveChanges();

<<<<<<< HEAD
            return RedirectToAction("ClassList");
=======
            return RedirectToAction("ClassIndex");
>>>>>>> 888fb61ad308486e5a4b7694bdf6bb986f215ab4
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

<<<<<<< HEAD
            return RedirectToAction("ClassList");
=======
            return RedirectToAction("ClassIndex");
>>>>>>> 888fb61ad308486e5a4b7694bdf6bb986f215ab4
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

<<<<<<< HEAD
        public IActionResult ClassDetail(int classId)
        {
            var dbContext = new SchoolDBContext();

            var classObj = dbContext.Classes.Include(p => p.Students).FirstOrDefault(p => p.ClassId == classId);
           
            return View(classObj);
        }

=======
>>>>>>> 888fb61ad308486e5a4b7694bdf6bb986f215ab4
    }

}
