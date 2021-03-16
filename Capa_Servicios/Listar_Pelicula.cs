using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;

namespace Capa_Servicios
{
    public static class Listar_Pelicula
    {
        static TheaterEntities db = new TheaterEntities();
        public static List<ListarPelicula_Result> ListarPeliculas()
        {
            return db.ListarPelicula().ToList();
        }
        public static List<ListarUltimaPelicula_Result> ListarUltimaPelicula()
        {
            return db.ListarUltimaPelicula().ToList();
        }
        /*public static List<int?> ContarUsuarios()
        {
            return db.CountUsuario().ToList();
        }*/

        public static List<int?> ContarDirector()
        {
            return db.CountDirector().ToList();
        }
        public static List<int?> Contargenero()
        {
            return db.CountGenero().ToList();
        }
        public static List<int?> Contpelicula()
        {
            return db.CountPelicula().ToList();
        }
    }
}
