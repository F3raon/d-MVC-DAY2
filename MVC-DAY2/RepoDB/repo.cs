using MVC_DAY2.Models;

namespace MVC_DAY2.RepoDB
{
    public static class repo
    {
      public  static List<Student> GetStudents()
        {
            return new List<Student> {
            new Student() { StdId = 1, StdName = "John Doe", StdAddress = "123 Main St", StdAge = 20 },
            new Student() { StdId = 2, StdName = "Jane Smith", StdAddress = "456 Elm St", StdAge = 22 },
            new Student() { StdId = 3, StdName = "Sam Brown", StdAddress = "789 Oak St", StdAge = 19 },
           new Student() { StdId = 4, StdName = "youhan Doe", StdAddress = "12 Main St", StdAge = 17 },
            new Student() { StdId = 5, StdName = "fego Smith", StdAddress = "225 Elm St", StdAge = 24 },
            new Student() { StdId = 6, StdName = "stren Brown", StdAddress = "44 Oak St", StdAge = 18 }
            };
        }


        public static List<Department> GetDepartments()
        {
            return new List<Department> {
             new Department {  DeptId = 1 , DeptName = "SD" },
            new Department {  DeptId = 2 , DeptName = "UI" },
            new Department {  DeptId = 3 , DeptName = "Mob" },
            new Department {  DeptId = 4 , DeptName = "Network" },
            };
        }
     

    }
}
