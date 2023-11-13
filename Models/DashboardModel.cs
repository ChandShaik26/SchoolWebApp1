using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using OnlineStudentEnrollmentSystem.Entities;

namespace OnlineStudentEnrollmentSystem.Models
=======
using WebApplication1.Entities;

namespace WebApplication1.Models
>>>>>>> 888fb61ad308486e5a4b7694bdf6bb986f215ab4
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