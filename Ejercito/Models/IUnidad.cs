using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercito.Models
{
    public interface IUnidad :IValuable
    {
        int ID { get; set; }
        string Nombre { get; set; }
        double Precio { get; set; }
        Division Division { get; set; }
     }
}
