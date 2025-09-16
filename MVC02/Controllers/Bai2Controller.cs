using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;

namespace MVC02.Controllers
{
    public class Bai2Controller : Controller
    {
        public IActionResult Receive(string username, string password, string email)
        {
            bool validusername = !string.IsNullOrEmpty(username);
            bool validpassword = password.Length >= 8 && password.Any(char.IsDigit);
            bool validemail = Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            if (validemail && validpassword && validusername)
            {
                ViewBag.Message = $"Xin chào {username}, bạn đã đăng ký thành công";
            }
            else
            {
                ViewBag.Message = "Đăng ký thất bại";
            }
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        // GET: hiển thị form nhập
        [HttpGet]
        public IActionResult GetRandomNumbers()
        {
            return View();
        }

        // POST: xử lý dữ liệu từ form
        [HttpPost]
        public IActionResult GetRandomNumbers(byte lb, byte ub, byte n)
        {
            if (lb >= ub || n <= 0)
            {
                ViewBag.Error = "Lower bound phải nhỏ hơn Upper bound và n > 0";
                return View(); // quay lại form nhập
            }

            Random rnd = new Random();
            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Add(rnd.Next(lb, ub + 1));
            }

            return View("ShowRandomNumber", numbers);
        }
    }
}
