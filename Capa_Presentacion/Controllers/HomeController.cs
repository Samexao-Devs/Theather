using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_Negocios;
using Capa_Entidad;


namespace Capa_Presentacion.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
       
        public ActionResult Login(string Message = "")
        {
            ViewBag.Message = Message;
            return View();
        }
        
        [HttpPost]
        public ActionResult BuscarUsuario(string Usuario, string Contrasena)
        {
            var UserBuscado = Login_N.BuscarUser(Usuario, Contrasena);

            if (UserBuscado != null)
            {
                if (UserBuscado.Id == 1)
                {
                    //User Admin
                    return RedirectToAction("Index","Admin");
                }
                else
                {
                    //User Normal

                    return RedirectToAction("Index","User");
                }
            }
            else
            {
                return RedirectToAction("Login", new { Message = "Usuario o Contraseña" });
            }
        }
        


        public ActionResult CrearCuenta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CrearCuenta(Loogin login)
        {
            try
            {
                Login_N.InsertarNuevoUser(login);
                return Login("Su Uusario Fue Creado Correctamente");
            }
            catch
            {
                return View();
            }


        }
    }
}