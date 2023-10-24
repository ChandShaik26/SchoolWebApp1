using Microsoft.AspNetCore.Mvc;
using OnlineStudentEnrollmentSystem.Entities;

namespace OnlineStudentEnrollmentSystem.Models
{
    public class DashboardModel
    {
        public int TotalTeachers { get; set; }

        public int TotalStudents { get; set; }

        public int TotalClasses { get; set; }

        public IList<Teacher> Teachers { get; set; }

        public IList<Class> Classes { get; set; }


   
    }   
}