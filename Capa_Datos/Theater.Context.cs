﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Capa_Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    using Capa_Entidad;

    public partial class TheaterEntities : DbContext
    {
        public TheaterEntities()
            : base("name=TheaterEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Director> Director { get; set; }
        public virtual DbSet<Genero> Genero { get; set; }
        public virtual DbSet<Loogin> Loogin { get; set; }
        public virtual DbSet<Pelicula> Pelicula { get; set; }
    
        public virtual ObjectResult<Nullable<int>> CountDirector()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("CountDirector");
        }
    
        public virtual ObjectResult<Nullable<int>> CountGenero()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("CountGenero");
        }
    
        public virtual ObjectResult<Nullable<int>> CountPelicula()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("CountPelicula");
        }
    
        public virtual ObjectResult<ListarPelicula_Result> ListarPelicula()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListarPelicula_Result>("ListarPelicula");
        }
    
        public virtual ObjectResult<ListarUltimaPelicula_Result> ListarUltimaPelicula()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListarUltimaPelicula_Result>("ListarUltimaPelicula");
        }
    
        public virtual int CountUsuario()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CountUsuario");
        }
    }
}
