using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EntityFamework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFamework.Controllers
{
    public class HomeController : Controller
    {
        private DemoContext _context;
        public HomeController(DbContext context)
        {
            _context = (DemoContext)context;


        }
        public IActionResult Index()
        {
            var students = _context.Student.Where(s=>s.name.StartsWith("Khayer")).ToList();

            return View(students);
        }

        public IActionResult Privacy()
        {
            var student = _context.Student.Single(s => s.name.Equals("Khayer",  StringComparison.Ordinal));
            return View(student);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
