using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercito.Models
{
    public interface IBlindado
    {
        double Blindaje { get; set; }
        double DameBlindaje();
    }
}