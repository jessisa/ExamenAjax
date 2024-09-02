using ExamenAjax.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExamenAjax.Controllers
{
    public class ProductoAjaxController : Controller
    {
        private readonly Contexto _context;

        public ProductoAjaxController(Contexto context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var productos = _context.Productos.ToList();
            return View(productos);
        }
        public IActionResult CreateProducto()
        {
            return PartialView("_CreateProductoPartial1");
        }

        [HttpPost]
        public async Task<IActionResult> SubmitForm(string name, int precio, DateTime fecha)
        {
            try
            {
                var productos = new Producto
                {
                    Nombre = name,
                    Precio = precio,
                    FechaVencimiento = fecha,
                    //Nuevo = string.Empty
                };
                _context.Productos.Add(productos);
                await _context.SaveChangesAsync();
                return Json(new { message = "Producto registrado con éxito." });
            }
            catch (Exception ex)
            {

                return Json(new { message = ex.Message });
            }





        }
    }
}
