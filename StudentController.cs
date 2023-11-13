using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
<<<<<<< HEAD
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using OnlineStudentEnrollmentSystem.Entities;
using OnlineStudentEnrollmentSystem.Models;

namespace OnlineStudentEnrollmentSystem
{
    public class StudentController : Controller
    {
        public IActionResult StudentList()
=======
using System.Runtime.InteropServices;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1
{
    public class StudentController : Controller
    {
        public IActionResult Studying()
>>>>>>> 888fb61ad308486e5a4b7694bdf6bb986f215ab4
        {

            var dbContext = new SchoolDBContext();

            IList<Student> Student = dbContext.Students.ToList();

            return View(Student);
        }

        public IActionResult AddStudent() 
        {
            var model = new AddStudentModel();

<<<<<<< HEAD
            model.ClassList = GetClasses();
         
=======
            var dbContext = new SchoolDBContext();
            var classes = dbContext.Classes.ToList();

            if(model.ClassList == null)
            {
                model.ClassList = new List<SelectListItem>();
            }

            foreach(var classObj in classes)
            {
                 
                model.ClassList.Add(new SelectListItem(classObj.ClassName, classObj.ClassId.ToString())); 
            }
>>>>>>> 888fb61ad308486e5a4b7694bdf6bb986f215ab4
            return View(model);
        }


        [HttpPost]
        public IActionResult SaveChanges(AddStudentModel model)
        {
            var student = new Student();

            //student.StudentId = model.StudentId;
            student.Name = model.Name;
            student.Gender = model.Gender;

            var dbContext = new SchoolDBContext();
            dbContext.Students.Add(student);
            dbContext.SaveChanges();

<<<<<<< HEAD
            return RedirectToAction("StudentList");
=======
            return RedirectToAction("Studying");
>>>>>>> 888fb61ad308486e5a4b7694bdf6bb986f215ab4

        }

        public IActionResult EditStudent(int StudentId)
        {
            var dbContext = new SchoolDBContext();

            var studentObj = dbContext.Students.Where(p => p.StudentId == StudentId).FirstOrDefault();

            var model = new AddStudentModel();

<<<<<<< HEAD
            model.ClassList = GetClasses();

=======
>>>>>>> 888fb61ad308486e5a4b7694bdf6bb986f215ab4
            model.StudentId = studentObj.StudentId;
            model.Name = studentObj.Name;
            model.Gender = studentObj.Gender;

            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateStudent(AddStudentModel model)
        {

            var dbContext = new SchoolDBContext();
            var studentObj = dbContext.Students.Where(p => p.StudentId == model.StudentId).FirstOrDefault();
            
            studentObj.StudentId = model.StudentId;
            studentObj.Name = model.Name;
            studentObj.Gender = model.Gender;

            dbContext.Students.Update(studentObj);
            dbContext.SaveChanges();

<<<<<<< HEAD
            return RedirectToAction("StudentList");
=======
            return RedirectToAction("Studying");
>>>>>>> 888fb61ad308486e5a4b7694bdf6bb986f215ab4
        }

        [HttpPost]
        public IActionResult DeleteStudent(int StudentId)
        {
            var dbContext = new SchoolDBContext();

            var studentObj = dbContext.Students.Where(p => p.StudentId == StudentId).FirstOrDefault();

            dbContext.Students.Remove(studentObj);
            dbContext.SaveChanges();

            return Json(true);
        }
<<<<<<< HEAD

        private IList<SelectListItem> GetClasses()
        {

            var classesListItems = new List<SelectListItem>();

            var dbContext = new SchoolDBContext();

            var classes = dbContext.Classes.ToList();

            classesListItems.Add(new SelectListItem("--Select--", null));

            foreach(var classObj in classes)
            {
               var listOption = new SelectListItem(classObj.Standard, classObj.ClassId.ToString());

               classesListItems.Add(listOption);
            }
            return classesListItems;
        }
=======
>>>>>>> 888fb61ad308486e5a4b7694bdf6bb986f215ab4
    }
}
