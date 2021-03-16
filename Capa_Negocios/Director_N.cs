using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocios
{
    public static class Director_N
    {
         static Director_D elemento = new Director_D();
        public static List<Director> ListarDirector()
        {
            return elemento.ListarDirector().ToList();
        }
        public static void AgregarDirector(Director director)
        {
            elemento.AgregarDirector(director);
        }
        public static Director GetDirector(int id)
        {
            return elemento.GetDirector(id);
        }
        public static void EditarDirector(Director director)
        {
            elemento.EditarDirector(director);
        }
        public static void EliminarDirector(int id)
        {
            elemento.EliminarDirector(id);
        }
    }
}
