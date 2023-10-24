using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineStudentEnrollmentSystem.Entities;
using OnlineStudentEnrollmentSystem.Models;

namespace OnlineStudentEnrollmentSystem
{
    public class TeacherController : Controller
    {
        public IActionResult TeacherList()
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

            return RedirectToAction("TeacherList");


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

            return RedirectToAction("TeacherList");
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


        public IActionResult TeacherDetail(int TeacherId)
        {
            var dbContext = new SchoolDBContext();

            var teacherObj = dbContext.Teachers.Include(p => p.Students).FirstOrDefault(p => p.TeacherId == TeacherId);

            return View(teacherObj);
        }
    }
}
