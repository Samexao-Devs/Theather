using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;

namespace Capa_Negocios
{
   public static class Login_N
    {

        //Instancias
        static Login_D datos = new Login_D();

        //Metodos
        public static Loogin BuscarUser(string User, string Contrasena)
        {
            return datos.BuscarUser(User,  Contrasena);
        }
        public static void InsertarNuevoUser(Loogin lo)
        {
            datos.InsertarNuevoUser(lo);
        }
    }
}
