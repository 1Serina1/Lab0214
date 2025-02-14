using Lab250214_School.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;

namespace Lab250214_School.Controllers
{
    public class SchoolController : Controller
    {
        List<Student> students = new List<Student>
            {
                new Student{sID=1, sName="Pikachu", Chinese=100, English=90, Math=60},
                new Student{sID=12, sName="Mary", Chinese=92, English=82, Math=60},
                new Student{sID=23, sName="Lisa", Chinese=98, English=91, Math=94},
                new Student{sID=34, sName="John", Chinese=63, English=85, Math=55},
                new Student{sID=45, sName="David", Chinese=59, English=77, Math=82}
            };

        public IActionResult Index()
        {
            return View(students);
        }
        public IActionResult Edit(string SID)
        {
            //foreach
            //foreach (Student item in students) { 
            //    if(item.sID.ToString() == SID)
            //    {
            //        return View(item);
            //    }
            //}
            //return View();

            //LINQ 查詢
            //Student s2 = (from xa in students where xa.sID.ToString() == SID select xa).First();
            //return View(s2);

            //LINQ方法
            Student? s3 = students.Where( x=> x.sID.ToString()==SID).FirstOrDefault();
            return View(s3);
        }
    }
}
