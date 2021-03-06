﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercito.Models.Unidades
{
    public class Ametrallador : IUnidad, IDestructor, IMovimiento
    {
        public Ametrallador() { }
        public Ametrallador(int iD, string nombre, double precio, Division division, int valor, double potenciaFuego, double movimiento)
        {
            ID = iD;
            Nombre = nombre;
            Precio = precio;
            Division = division;
            Valor = valor;
            PotenciaFuego = potenciaFuego;
            Movimiento = movimiento;
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public Division Division { get; set; }
        public int Valor { get; set; }
        public double PotenciaFuego { get; set; }
        public double Movimiento { get; set; }

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