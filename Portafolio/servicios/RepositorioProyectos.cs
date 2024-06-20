using Portafolio.Models;

namespace Portafolio.servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
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
    }
}
