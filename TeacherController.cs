using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1
{
    public class TeacherController : Controller
    {
        public IActionResult Teaching()
        {
            var dbContext = new SchoolDBContext();

            IList<Teacher> Teacher = dbContext.Teachers.ToList();

            return View(Teacher);
        }

        public IActionResult AddTeacher()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveChanges(AddTeacherModel model) 
        {
            var teacher = new Teacher();

            //teacher.TeacherId = model.TeacherId;
            teacher.Name = model.Name;
            teacher.Qualification = model.Qualification;

            var dbContext = new SchoolDBContext();

            dbContext.Teachers.Add(teacher);
            dbContext.SaveChanges();

            return RedirectToAction("Teaching");


        }

        public IActionResult EditTeacher(int TeacherId)
        {
            var dbContext = new SchoolDBContext();
            var teacherObj = dbContext.Teachers.Where(p => p.TeacherId == TeacherId).FirstOrDefault();

            var model = new AddTeacherModel();

            model.TeacherId = teacherObj.TeacherId;
            model.Name = teacherObj.Name;
            model.Qualification = teacherObj.Qualification;


            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateTeacher(AddTeacherModel model)
        {
            var dbContext = new SchoolDBContext();
            var teacherObj = dbContext.Teachers.Where(p => p.TeacherId == model.TeacherId).FirstOrDefault();
             
            teacherObj.TeacherId = model.TeacherId;
            teacherObj.Name = model.Name;   
            teacherObj.Qualification = model.Qualification;
            dbContext.Update(teacherObj);
            dbContext.SaveChanges();

            return RedirectToAction("Teaching");
        }

        [HttpPost]
        public IActionResult DeleteTeacher(int TeacherId)
        {
            var dbContext = new SchoolDBContext();

            var teacherObj =  dbContext.Teachers.Where(p => p.TeacherId == TeacherId).FirstOrDefault()!;

            dbContext.Teachers.Remove(teacherObj);
            dbContext.SaveChanges();

            return Json(true);
        }
    }
}
