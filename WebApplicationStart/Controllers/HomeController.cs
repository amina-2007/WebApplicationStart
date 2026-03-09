using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationStart.Models;

namespace WebApplicationStart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Tasks()
        {
            return View();
        }

        public string Task1()
        {
            DateTime dateTime = DateTime.Now;
            if (dateTime.Hour >= 0 && dateTime.Hour <= 6)
            { return "ДОБРОЕ УТРО"; }
            if (dateTime.Hour >= 7 && dateTime.Hour <= 11)
            { return "ДОБРЫЙ ДЕНЬ"; }
            if (dateTime.Hour >= 12 && dateTime.Hour <= 17)
            { return "ДОБРЫЙ ВЕЧЕР"; }
            if (dateTime.Hour >= 18 && dateTime.Hour <= 23)  
            { return "ДОБРАЯ НОЧЬ"; }
            return "Тут решение первой задачи";
        }

        public string Task2(double a, double b)
        {
            
            
            return $"{a}+{b}={a+b}"; }

        public string Task3(double a, double b, string op)
        {
            if (op == "+")

                return $"{a}+{b}={a + b}";

            if (op == "-")

                return $"{a}-{b}={a - b}";
            if (op == "*")

            { return $"{a}*{b}={a * b}"; }
            return "0";

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}