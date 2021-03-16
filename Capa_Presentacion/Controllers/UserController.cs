using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_Entidad;
using Capa_Servicios;
using Capa_Negocios;
using Capa_Datos;

namespace Capa_Presentacion.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            ViewBag.Ultimas_Peliculas = Listar_Pelicula.ListarUltimaPelicula().ToList();
            var pelicula = Listar_Pelicula.ListarPeliculas().ToList();
            return View(pelicula);
        }
        public ActionResult Detail(int id)
        {
            var DetallePelicula = Pelicula_N.GetPelicula(id);
            return View(DetallePelicula);
        }
    }
}