using Microsoft.AspNetCore.Mvc;
using appBusca.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

using appBusca.Data;


namespace appBusca.Controllers
{
    public class ProductoController : Controller
    {

        private readonly BuscaDbContext _context;
        public ProductoController(BuscaDbContext context) {
            _context = context;
        }
        public IActionResult Categorias() {
            var Categorias = _context.Categorias.Include(x => x.Productos).OrderBy(r => r.Nombre).ToList();
            return View(Categorias);
        }
        public IActionResult NuevoProducto() {
            ViewBag.Categorias = _context.Categorias.ToList().Select(r => new SelectListItem(r.Nombre, r.Id.ToString()));
            return View();
        }

        [HttpPost]
        public IActionResult NuevoProducto(Producto r) {
            if (ModelState.IsValid) {
                _context.Add(r);
                _context.SaveChanges();
                return RedirectToAction("NuevoProductoConfirmacion");
            }
            return View(r);
        }


    }
}