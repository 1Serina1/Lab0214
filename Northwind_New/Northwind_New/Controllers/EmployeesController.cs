using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Northwind_New.Models;

namespace Northwind_New.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly MyDbContext _context;


        public EmployeesController(MyDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            ViewBag.Demo = await _context.Employees.ToListAsync();
            return View();
        }
    }
}
