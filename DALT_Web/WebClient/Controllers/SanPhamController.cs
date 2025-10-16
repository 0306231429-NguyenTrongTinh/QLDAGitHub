using Microsoft.AspNetCore.Mvc;
using BLL;
using DTO;

namespace WebClient.Controllers
{
    public class SanPhamController : Controller
    {
        private readonly SanPhamBLL _spBLL = new SanPhamBLL();

        public IActionResult Index()
        {
            var list = _spBLL.GetAll();
            return View(list);
        }

        public IActionResult Detail(int id)
        {
            var sp = _spBLL.GetById(id);
            if (sp == null)
                return NotFound();
            return View(sp);
        }
    }
}
