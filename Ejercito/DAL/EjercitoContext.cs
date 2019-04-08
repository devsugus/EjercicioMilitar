using Ejercito.Models;
using Ejercito.Models.Unidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Ejercito.DAL
{
    public class EjercitoContext : DbContext
    {
        public EjercitoContext() : base("EjercitoContext")
        {

        }
        public DbSet<Canon> Canones { get; set; }
        public DbSet<Division> Divisiones { get; set; }
        public DbSet<CapituloEjercito> Ejercitos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<Ejercito.Models.Unidades.Ametrallador> Ametralladors { get; set; }

        public System.Data.Entity.DbSet<Ejercito.Models.Unidades.AntiAereo> AntiAereos { get; set; }
    }
}