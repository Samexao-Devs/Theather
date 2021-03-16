using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;

namespace Capa_Datos
{
    public class Pelicula_D
    {
        TheaterEntities db = new TheaterEntities();
        public List<Pelicula> ListarPelicula()
        {
            return db.Pelicula.ToList();
        }
        public void InsertarPelicula(Pelicula peliculas)
        {
            db.Pelicula.Add(peliculas);
            db.SaveChanges();
        }
        public void EliminarPelicula(int id)
        {
            var pelicula = db.Pelicula.Find(id);

            db.Pelicula.Remove(pelicula);
            db.SaveChanges();
        }
        public Pelicula GetPelicula(int id)
        {
            //Busca el primero que encuentre y retorna el registro
            return db.Pelicula.Find(id);
        }
        public void EditarPelicula(Pelicula pel)
        {
            var pelicula = db.Pelicula.Find(pel.ID_Pelicula);

            pelicula.Duracion = pel.Duracion;
            pelicula.Estudio = pel.Estudio;
            pelicula.FechaLanzamiento = pel.FechaLanzamiento;
            pelicula.Genero = pel.Genero;
            pelicula.ID_Director = pel.ID_Director;
            pelicula.ID_Genero = pel.ID_Genero;
            pelicula.Imagen = pel.Imagen;
            pelicula.Media = pel.Media;
            pelicula.Protagonista = pel.Protagonista;
            pelicula.Sipnosis = pel.Sipnosis;
            pelicula.Titulo = pel.Titulo;

            db.SaveChanges();
        }
    }
}
