using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercito.Models
{
    public class CapituloEjercito
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public ICollection<Division> Divisiones { get; set; }
    }
}