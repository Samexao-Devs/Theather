using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;

namespace Capa_Datos
{
    public class Genero_D
    {

        //Instancia
        TheaterEntities entidad = new TheaterEntities();
        
        public List<Genero> ListarGenero() {
            return entidad.Genero.ToList();
        }

    }
}
