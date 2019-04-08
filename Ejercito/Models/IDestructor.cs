using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercito.Models
{
    public interface  IDestructor
    {
        double PotenciaFuego { get; set; }

        double DamePotenciaFuego();
    }
}