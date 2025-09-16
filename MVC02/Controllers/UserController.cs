using Microsoft.AspNetCore.Mvc;
using MVC02.Models;
namespace MVC02.Controllers
{
    public class User : Controller
    {
        public IActionResult Index()
        {
            UserModel user = (new UserModel()).NewUser();
            return View(user);
        }
        public IActionResult listAll()
        {
            List<UserModel> list=(new UserModel()).GetListOfusers();
            return View(list);
        }
    }
}