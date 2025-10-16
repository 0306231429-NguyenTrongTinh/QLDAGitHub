using Microsoft.AspNetCore.Mvc;
using BLL;
using DTO;

namespace WebClient.Controllers
{
    public class GioHangController : Controller
    {
        private readonly GioHangBLL _ghBLL = new GioHangBLL();

        public IActionResult Index()
        {
            var user = HttpContext.Session.GetString("User");
            var cart = _ghBLL.GetCart(user);
            return View(cart);
        }

        public IActionResult Add(int productId)
        {
            var user = HttpContext.Session.GetString("User");
            _ghBLL.AddToCart(user, productId);
            return RedirectToAction("Index");
        }

        public IActionResult Remove(int productId)
        {
            var user = HttpContext.Session.GetString("User");
            _ghBLL.RemoveFromCart(user, productId);
            return RedirectToAction("Index");
        }
    }
}
