using System.Linq;
using Busco.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Busco.Controllers
{
    public class ProductosController : Controller
    {
        private readonly BuscoContext _context;
        public ProductosController(BuscoContext context) {
            _context = context;
        }
        public IActionResult Productos() {
            var productos = _context.Productos.Include(p => p.Solicitudes).ToList();
            return View("Productos");
        }
        public IActionResult RegistrarProducto(){
            ViewBag.Categorias = _context.Categorias.ToList().Select(p => new SelectListItem(p.Nombre, p.Id.ToString()));
            return View();
        }
        [HttpPost]
        public IActionResult RegistrarProducto(Producto p){
            if (ModelState.IsValid) {
                _context.Add(p);
                _context.SaveChanges();
                return RedirectToAction("RegistrarProductoConfirmacion");
            }
            return View(p);
        }
        public IActionResult RegistrarProductoConfirmacion(){
            return View();
        }
    }
}