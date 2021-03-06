﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercito.Models.Unidades
{
    public class AntiAereo : IUnidad, IMovimiento, IDestructor 
    {
        public AntiAereo() { }
        public AntiAereo(int iD, string nombre, double precio, Division division, double movimiento, double potenciaFuego, int valor)
        {
            ID = iD;
            Nombre = nombre;
            Precio = precio;
            Division = division;
            Movimiento = movimiento;
            PotenciaFuego = potenciaFuego;
            Valor = valor;
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public Division Division { get; set; }
        public double Movimiento { get; set; }
        public double PotenciaFuego { get; set; }
        public int Valor { get; set; }

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