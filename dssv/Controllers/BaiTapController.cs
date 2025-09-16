using Microsoft.AspNetCore.Mvc;
namespace dssv.Controllers
{
    public class BaiTapController : Controller
    {
        public IActionResult Dssv(String id, String name, int age, Double gpa)
        {
            bool validId = !String.IsNullOrEmpty(id);
            bool validName = !String.IsNullOrEmpty(name);
            bool validAge = age >= 18 && age <= 26;
            bool validGpa = gpa >= 0.0 && gpa <= 4.0;

            if (validId && validAge && validGpa && validName)
            {
                ViewBag.Message = $"✅ Sinh viên hợp lệ: {id} - {name} - {age} tuổi - GPA: {gpa}";
            }
            else
            {
                ViewBag.Message = "Sinh viên không hợp lệ";
            }
            return View();
        }
        public IActionResult nhap(){return View(); }
    }
}