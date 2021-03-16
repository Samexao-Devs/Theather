using Capa_Entidad;
using System.Collections.Generic;
using System.Linq;

namespace Capa_Datos
{
    public class Director_D
    {
        TheaterEntities db = new TheaterEntities();

        public List<Director> ListarDirector()
        {
            return db.Director.ToList();
        }
        public void AgregarDirector(Director director)
        {
            db.Director.Add(director);
            db.SaveChanges();
        }
        public Director GetDirector(int id)
        {
            return db.Director.Find(id);
        }
        public void EditarDirector(Director director)
        {
            var i = db.Director.Find(director.ID_Director);
            i.Nombre_Completo = director.Nombre_Completo;
            db.SaveChanges();
        }
        public void EliminarDirector(int id)
        {
            var director = db.Director.Find(id);
            db.Director.Remove(director);
            db.SaveChanges();
        }
    }
}
