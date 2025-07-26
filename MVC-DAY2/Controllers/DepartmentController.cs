using Microsoft.AspNetCore.Mvc;

namespace MVC_DAY2.Models.Controllers
{
    public class DepartmentController : Controller
    {
      
        static List<Department> depts = new List<Department>()
        {
            new Department {  DeptId = 1 , DeptName = "SD" },
            new Department {  DeptId = 2 , DeptName = "UI" },
            new Department {  DeptId = 3 , DeptName = "Mob" },
            new Department {  DeptId = 4 , DeptName = "Network" },
        };
      
        public IActionResult GetAll()
        {
            return View(depts);
        }
        /*------------------------------------------------------------------*/
        public IActionResult ViewDetails(int id)
        {
            var dept = depts.FirstOrDefault(d => d.DeptId == id);
            return View(dept);
        }
      
        public IActionResult Create()
        {
            return View();
        }
       
        public IActionResult ActualCreate(Department department)
        {
            depts.Add(department);
            return RedirectToAction("GetAll");
        }
      
    }
}