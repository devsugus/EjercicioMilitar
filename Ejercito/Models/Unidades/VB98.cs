﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercito.Models.Unidades
{
    public class VB98 : IUnidad, IMovimiento, IBlindado, IDestructor
    {
        public VB98() { }
        public VB98(int iD, string nombre, double precio, Division division, int valor, double movimiento, double potenciaFuego, double blindaje)
        {
            ID = iD;
            Nombre = nombre;
            Precio = precio;
            Division = division;
            Valor = valor;
            Movimiento = movimiento;
            PotenciaFuego = potenciaFuego;
            Blindaje = blindaje;
        }

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