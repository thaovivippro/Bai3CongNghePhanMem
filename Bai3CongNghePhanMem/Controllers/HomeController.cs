using System.Diagnostics;
using Bai3CongNghePhanMem.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bai3CongNghePhanMem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // Giả lập dữ liệu lưu tạm (vì chưa dùng database)
        private static List<Employee> _employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Thơ", Position = "Nhân viên", Age = 30, Email = "thodq@example.com" },
            new Employee { Id = 2, Name = "Công", Position = "Lãnh đạo", Age = 25, Email = "congtd@example.com" }
        };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(_employees);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
