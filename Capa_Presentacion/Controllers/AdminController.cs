using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Capa_Entidad;
using Capa_Negocios;
using Capa_Servicios;

namespace Capa_Presentacion.Controllers
{
    public class AdminController : Controller
    {

        List<SelectListItem> DropDownlistGenero = Genero_N.ListarGenero().ConvertAll(c =>
        {
            return new SelectListItem()
            {
                Text = c.Nombre_Genero.ToString(),
                Value = c.ID_Genero.ToString(),
                Selected = false
            };
        }
        );

        List<SelectListItem> DropDownlistDirector = Director_N.ListarDirector().ConvertAll (c =>
        {
            return new SelectListItem()
            {
                Text = c.Nombre_Completo.ToString(),
                Value = c.ID_Director.ToString(),
                Selected = false
            };
        }
     );

        // GET: Admin
        public ActionResult Index()
        {
           // ViewBag.CantidadUsuarios = ConntarUsers();
            ViewBag.CantidadPeli = ConntarPelicula();
            ViewBag.Director = ConntarDirector();
            ViewBag.genero = ConntarGenero();

            return View();
        }


        public ActionResult VerPelicula()
        {
            ViewBag.detalle = Lista();
            return View();
        }
        public ActionResult Lista()
        {
            return View(Listar_Pelicula.ListarPeliculas());
        }
        public ActionResult CrearPelicula()
        {
            ViewBag.ListaGenero = DropDownlistGenero;
            ViewBag.ListaDirector = DropDownlistDirector;
            return View();
        }
        [HttpPost]
        public ActionResult CrearPelicula(Pelicula peli)
        {
            try
            {
                Pelicula_N.InsertarPelicula(peli);
                return  RedirectToAction("VerPelicula");
            }
            catch (Exception)
            {
                return View();
            }
        }

        //Delete Peliculas
        public ActionResult EliminarPelicula(int id)
        {
            var Peli = Pelicula_N.GetPelicula(id);
            return View(Peli);
        }
        [HttpPost]
        public ActionResult EliminarPelicula(int id, FormCollection collection)
        {
            Pelicula_N.EliminarPelicula(id);
            return RedirectToAction("VerPelicula");
        }
        //Edit 
        public ActionResult EditarPeli(int id)
        {
            var pelibuscada = Pelicula_N.GetPelicula(id);

            ViewBag.ListaGenero = DropDownlistGenero;
            ViewBag.ListaDirector = DropDownlistDirector;
            ViewBag.protagonistas = pelibuscada.Protagonista;
            ViewBag.sipnosis = pelibuscada.Sipnosis;
            return View(pelibuscada);
        }

        [HttpPost]
        public ActionResult EditarPeli(Pelicula peli)
        {
            Pelicula_N.EditarPelicula(peli);
            return RedirectToAction("VerPelicula");
        }


        //Detalles
        public ActionResult DetallesPelicula(int id)
        {
            var Detalle = Pelicula_N.GetPelicula(id);
            ViewBag.ListaGenero = DropDownlistGenero;
            ViewBag.ListaDirector = DropDownlistDirector;
            return View(Detalle);
        }



        //Director
        public ActionResult VerDirector()
        {
            ViewBag.detalle = ListaDirector();
            return View();
        }
        public ActionResult ListaDirector()
        {
            return View(Director_N.ListarDirector());
        }

        public ActionResult CrearDirector()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CrearDirector(Director director)
        {
            try
            {
                Director_N.AgregarDirector(director);
                return RedirectToAction("VerDirector");
            }
            catch
            {
                return View();
            }
        }
        // GET: Admin/EliminarDirector/5
        public ActionResult EliminarDirector(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var director = Director_N.GetDirector(id.Value);
            return View(director);
        }
        // POST: Admin/EliminarDirector/5
        [HttpPost]
        public ActionResult EliminarDirector(int id)
        {
            try
            {
                Director_N.EliminarDirector(id);
                return RedirectToAction("VerDirector");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }
        }
        public ActionResult EditarDirector(int id)
        {
            var DirectorEditar = Director_N.GetDirector(id);
            return View(DirectorEditar);
        }
        [HttpPost]
        public ActionResult EditarDirector(Director licencia)
        {
            try
            {
                Director_N.EditarDirector(licencia);

                return RedirectToAction("VerDirector");
            }
            catch
            {
                return View();
            }
        }

        //Metodos
        /*public int ConntarUsers()
        {
            List<int?> pp = Listar_Pelicula.ContarUsuarios().ToList();
            int s = 0;
            foreach (int i in pp)
            {
                s = i;
            }
            return s;
        }*/
        public int ConntarPelicula()
        {
            List<int?> pp = Listar_Pelicula.Contpelicula().ToList();
            int s = 0;
            foreach (int i in pp)
            {
                s = i;
            }
            return s;
        }
        public int ConntarGenero()
        {
            List<int?> pp = Listar_Pelicula.Contargenero().ToList();
            int s = 0;
            foreach (int i in pp)
            {
                s = i;
            }
            return s;
        }
        public int ConntarDirector()
        {
            List<int?> pp = Listar_Pelicula.ContarDirector().ToList();
            int s = 0;
            foreach (int i in pp)
            {
                s = i;
            }
            return s;
        }
    }
}