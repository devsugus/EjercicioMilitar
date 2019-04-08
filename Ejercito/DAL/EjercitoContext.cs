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
        public DbSet<Division> Divisiones { get; set; }
        public DbSet<CapituloEjercito> Ejercitos { get; set; }


        public DbSet<Ametrallador> Ametralladors { get; set; }
        public DbSet<AntiAereo> AntiAereos { get; set; }
        public DbSet<Canon> Canones { get; set; }
        public DbSet<InfanteriaBasica> InfanteriaBasicas { get; set; }
        public DbSet<MX7899> MX7899 { get; set; }
        public DbSet<Sanitario> Sanitarios { get; set; }
        public DbSet<TAXIN66> TAXIN66 { get; set; }
        public DbSet<TorpederoM> TorpederoMs { get; set; }
        public DbSet<VB98> VB98 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}