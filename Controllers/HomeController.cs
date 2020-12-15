using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC3_PROGRA.Data;
using PC3_PROGRA.Models;

namespace PC3_PROGRA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            List<Producto> lista= Listar();
            return View(lista);
        }

        public List<Producto> Listar()
        {
            var listaProductos= _context.Productos.ToList();
            List<Producto> lista= new List<Producto>();
            DateTime limitDate= DateTime.Today.AddDays(-7);

            foreach(Producto producto in listaProductos)
            {
                if(DateTime.Compare(producto.addDate,limitDate)>=0)
                {
                    lista.Add(producto);
                }
            }

            return(lista);
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
