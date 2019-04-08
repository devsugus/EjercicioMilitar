using Ejercito.Models;
using Ejercito.Models.Unidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercito.DAL
{
    public class EjercitoInicializer :System.Data.Entity.DropCreateDatabaseIfModelChanges<EjercitoContext>
    {
        protected override void Seed(EjercitoContext context)
        {
            var Division = new List<Division>
            {
                new Division{ID=1,Nombre="Falicas"}
            };
            Division.ForEach(s => context.Divisiones.Add(s));
            context.SaveChanges();

            var Unidad = new List<Canon>
            {
                new Canon(100,"General Pollesco",1,Division[0] ,10000)
                //,
                //new Canon{ID=2, Nombre="CanonZipoton", potenciaFuego=10, Precio=1000 }
            };
            Unidad.ForEach(s => context.Canones.Add(s));
            context.SaveChanges();
        }
    }
}