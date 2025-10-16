using Microsoft.AspNetCore.Mvc;
using BLL;
using DTO;

namespace WebClient.Controllers
{
    public class DonHangController : Controller
    {
        private readonly DonHangBLL _dhBLL = new DonHangBLL();

        public IActionResult Index()
        {
            var user = HttpContext.Session.GetString("User");
            var list = _dhBLL.GetOrdersByUser(user);
            return View(list);
        }

        public IActionResult Detail(int id)
        {
            var order = _dhBLL.GetById(id);
            if (order == null)
                return NotFound();
            return View(order);
        }

        public IActionResult Checkout()
        {
            var user = HttpContext.Session.GetString("User");
            bool result = _dhBLL.CreateOrder(user);
            if (result)
                return RedirectToAction("Index");
            return BadRequest("Không thể tạo đơn hàng!");
        }
    }
}
