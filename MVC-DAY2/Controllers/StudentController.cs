//using Microsoft.AspNetCore.Mvc;
//using MVC_DAY2.RepoDB;
//using MVC_DAY2.Models;

//namespace MVC_DAY2.Controllers
//{
//    public class StudentController : Controller
//    {


//        public IActionResult GetAll()
//        {
//           ViewBag.llStudents = repo.GetStudents();
//            return View();
//        }

//        public IActionResult ViewData(int id)
//        {
//            var student = repo.GetStudents().FirstOrDefault(s => s.StdId == id);
//           ViewBag.student = student;
//            ViewBag.Title = "Student Details";
//            return View();
//        }
//        public IActionResult Create()
//        {
//            return View();
//        }

//        public IActionResult ActualCreate(int id, string ename, int age, string address)
//        {
//            Student student = new Student { StdId = id, StdName = ename, StdAge = age, StdAddress = address };
//            var s = RepoDB.repo.GetStudents();
//            s.Add(student);
//            return RedirectToAction("GetAll");
//        }
//    }
//}
using Microsoft.AspNetCore.Mvc;
using MVC_DAY2.Models;
using MVC_DAY2.RepoDB;

namespace MVC_DAY2.Controllers
{
    public class StudentController : Controller
    {
        
        static List<Student> students = new List<Student>()
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
          ViewBag.llStudents = students;
           return View();
       }
        
        public IActionResult ViewDetails(int id)
        {
            var std = students.FirstOrDefault(x => x.StdId == id);
            ViewBag.students = std;
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
            students.Add(ss);
          
            return RedirectToAction("GetAll");
        }
        
    }
}