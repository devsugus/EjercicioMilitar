﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercito.Models.Unidades
{
    public class VB98 : IUnidad, IMovimiento, IBlindado, IDestructor
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public Division Division { get; set; }
        public int Valor { get; set; }
        public double Movimiento { get; set; }
        public double PotenciaFuego { get; set; }
        public double Blindaje { get; set; }

        public double DameBlindaje()
        {
            return Blindaje;
        }

        public double DameMovimiento()
        {
            return Movimiento;
        }

        public double DamePotenciaFuego()
        {
            return PotenciaFuego;
        }

        public int DameValor()
        {
            return Valor;
        }
    }
}