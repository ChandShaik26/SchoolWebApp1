using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entities;

namespace WebApplication1.Models
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