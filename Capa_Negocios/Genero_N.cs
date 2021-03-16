using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocios
{
    public static class Genero_N
    {
         static Genero_D elemento = new Genero_D();
        public static List<Genero> ListarGenero()
        {
            return elemento.ListarGenero().ToList();
        }
    }
}
