using Microsoft.AspNetCore.Mvc;
using BLL;
using DTO;

namespace WebClient.Controllers
{
    public class AccountController : Controller
    {
        private readonly AccountBLL _accountBLL = new AccountBLL();

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = _accountBLL.Login(username, password);
            if (user != null)
            {
                HttpContext.Session.SetString("User", user.Username);
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Error = "Sai tên đăng nhập hoặc mật khẩu!";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserDTO newUser)
        {
            if (ModelState.IsValid)
            {
                bool result = _accountBLL.Register(newUser);
                if (result)
                    return RedirectToAction("Login");
                ViewBag.Error = "Đăng ký thất bại!";
            }
            return View(newUser);
        }
    }
}
