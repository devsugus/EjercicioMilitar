﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercito.Models.Unidades
{
    public class MX7899 : IUnidad, IMovimiento
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public Division Division { get; set; }
        public int Valor { get; set; }
        public double Movimiento { get; set; }

        public double DameMovimiento()
        {
            return Movimiento;
        }

        public int DameValor()
        {
            return Valor;
        }
    }
}