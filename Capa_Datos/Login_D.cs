using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;

namespace Capa_Datos
{
    public class Login_D
    {
        //Instancia 
        TheaterEntities db = new TheaterEntities();

        public Loogin BuscarUser(string User, string Contrasena)
        {
            return db.Loogin.Where(i => i.Usuario == User && i.Contrasena == Contrasena).FirstOrDefault();
        }
        public void InsertarNuevoUser(Loogin login)
        {
            db.Loogin.Add(login);
            db.SaveChanges();
        }
    }
}
