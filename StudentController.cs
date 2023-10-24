using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using OnlineStudentEnrollmentSystem.Entities;
using OnlineStudentEnrollmentSystem.Models;

namespace OnlineStudentEnrollmentSystem
{
    public class StudentController : Controller
    {
        public IActionResult StudentList()
        {

            var dbContext = new SchoolDBContext();

            IList<Student> Student = dbContext.Students.ToList();

            return View(Student);
        }

        public IActionResult AddStudent() 
        {
            var model = new AddStudentModel();

            model.ClassList = GetClasses();
         
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

            return RedirectToAction("StudentList");

        }

        public IActionResult EditStudent(int StudentId)
        {
            var dbContext = new SchoolDBContext();

            var studentObj = dbContext.Students.Where(p => p.StudentId == StudentId).FirstOrDefault();

            var model = new AddStudentModel();

            model.ClassList = GetClasses();

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

            return RedirectToAction("StudentList");
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
    }
}
