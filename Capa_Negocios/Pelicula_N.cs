using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocios
{
    public class Pelicula_N
    {
        static Pelicula_D elemento = new Pelicula_D();
        public static void InsertarPelicula(Pelicula empleado)
        {
            elemento.InsertarPelicula(empleado);
        }
        public static void EliminarPelicula(int id)
        {
            elemento.EliminarPelicula(id);
        }
        public static void EditarPelicula(Pelicula pelicula)
        {
            elemento.EditarPelicula(pelicula);
        }
        public static Pelicula GetPelicula(int id)
        {
            return elemento.GetPelicula(id);
        }
        public static List<Pelicula> ListarPelicula()
        {
            return elemento.ListarPelicula();
        }
    }
}
