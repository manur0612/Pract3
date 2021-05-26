using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using appBusca.Models;
using appBusca.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace appBusca.Controllers
{
    public class HomeController : Controller
    {
        private readonly BuscaDbContext _context;
        public HomeController(BuscaDbContext context) {
            _context = context;
        }
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Productos = _context.Productos.ToList().Select(r => new SelectListItem(r.Nombre, r.Id.ToString()));
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
