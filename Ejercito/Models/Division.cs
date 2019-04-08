using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercito.Models
{
    public class Division
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public ICollection<IUnidad> Unidades { get; set; }
    }
}