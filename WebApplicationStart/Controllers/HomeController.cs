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
            if (dateTime.Hour >= 0 && dateTime.Hour <= 5)
            { return "ДОБРАЯ НОЧЬ"; }
            if (dateTime.Hour >= 6 && dateTime.Hour <= 11)
            { return "ДОБРОЕ УТРО"; }
            if (dateTime.Hour >= 12 && dateTime.Hour <= 17)
            { return "ДОБРЫЙ ДЕНЬ"; }
            if (dateTime.Hour >= 18 && dateTime.Hour <= 23)  
            { return "ДОБРЫЙ ВЕЧЕР"; }
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

        public string Task4(string first, string second, string op)
        {
            List<string> ops = new List<string> { "%2B", "-", "+", "/"};
            if (!ops.Contains(op))
            { return "Доступные символы:%2B    -   +   /"; }

            double a =string.IsNullOrEmpty(first)?0: Convert.ToDouble(first);
            double b = string.IsNullOrEmpty(second) ? 0 : Convert.ToDouble(second);
            if (op == "%2B")

                return $"{a}+{b}={a + b}";

            if (op == "-")

                return $"{a}-{b}={a - b}";
            if (op == "*")

            { return $"{a}*{b}={a * b}"; }

            if (op == "/")

            {if(b==0)
                { return "На ноль делить нельзя."; }
                return $"{a}/{b}={a / b}"; }
            return $"{a}+{b}={a + b}";


        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}