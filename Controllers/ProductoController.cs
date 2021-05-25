using Busco.Models;
using Microsoft.AspNetCore.Mvc;

namespace Busco.Controllers
{
    public class ProductoController : Controller
    {
        private readonly BuscoContext _context;
        public ProductoController(BuscoContext context) {
            _context = context;
        }
        
        // public IActionResult RegistrarProducto(){

        // }
    }
}