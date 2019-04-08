using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercito.Models
{
    public interface IValuable
    {
        int Valor { get; set; }
        int DameValor();
    }
}