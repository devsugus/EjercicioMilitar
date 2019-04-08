using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercito.Models
{
    public interface IMovimiento
    {
        double Movimiento { get; set; }
        double DameMovimiento();
    }
}