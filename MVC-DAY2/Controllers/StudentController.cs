
using Microsoft.AspNetCore.Mvc;
using MVC_DAY2.Models;
using MVC_DAY2.RepoDB;

namespace MVC_DAY2.Controllers
{
    public class StudentController : Controller
    {
        
        static List<Student> Stds = new List<Student>()
        {
            
            new Student() { StdId = 1, StdName = "John Doe", StdAddress = "123 Main St", StdAge = 20 },
            new Student() { StdId = 2, StdName = "Jane Smith", StdAddress = "456 Elm St", StdAge = 22 },
            new Student() { StdId = 3, StdName = "Sam Brown", StdAddress = "789 Oak St", StdAge = 19 },
           new Student() { StdId = 4, StdName = "youhan Doe", StdAddress = "12 Main St", StdAge = 17 },
            new Student() { StdId = 5, StdName = "fego Smith", StdAddress = "225 Elm St", StdAge = 24 },
            new Student() { StdId = 6, StdName = "stren Brown", StdAddress = "44 Oak St", StdAge = 18 }
           
        
        };

        public IActionResult GetAll()     
        {
          ViewBag.llStudents = Stds;
           return View();
       }
        
        public IActionResult ViewDetails(int id)
        {
            var std = Stds.FirstOrDefault(x => x.StdId == id);
            ViewBag.Student = std;
            ViewBag.Title = "Student Details";
            return View();
        }
     
        public IActionResult Create()
        {
            return View();
        }
       
        public IActionResult ActualCreate(int id, string sname, int age, string address)
        {
            Student ss = new Student { StdId = id, StdName = sname, StdAge = age, StdAddress = address };
            Stds.Add(ss);
          
            return RedirectToAction("GetAll");
        }
        
    }
}