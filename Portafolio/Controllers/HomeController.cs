using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            

            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel()
            {
                proyectos = proyectos,
            };

            return View(modelo);
        }

        private List<Proyecto> ObtenerProyectos()
        {
            // Crear una lista de proyectos y añadir todos los proyectos en ella
            return new List<Proyecto>
    {
        new Proyecto
        {
            Titulo = "Amazon",
            Descripcion = "E-commerce realizado en ASP.NET Core",
            Link = "https://amazon.com",
            ImagenURL = "/imagenes/amazon.png"
        },
        new Proyecto
        {
            Titulo = "New York Times",
            Descripcion = "Pagina de noticias en React",
            Link = "https://nytimes.com",
            ImagenURL = "/imagenes/nytimes.png"
        },
        new Proyecto
        {
            Titulo = "Reddit",
            Descripcion = "Red social para compartir en comunidades",
            Link = "https://reddit.com",
            ImagenURL = "/imagenes/reddit.jpg"
        },
        new Proyecto
        {
            Titulo = "Steam",
            Descripcion = "Tienda en línea para comprar videojuegos",
            Link = "https://store.steampowered.com",
            ImagenURL = "/imagenes/steam.jpg"
        }
    };
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
