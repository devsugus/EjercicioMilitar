using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercito.Models.Unidades
{
    public class Sanitario : IUnidad, IBlindado, IMovimiento
    {
        public Sanitario() { }
        public Sanitario(int iD, string nombre, double precio, Division division, int valor, double blindaje, double movimiento)
        {
            ID = iD;
            Nombre = nombre;
            Precio = precio;
            Division = division;
            Valor = valor;
            Blindaje = blindaje;
            Movimiento = movimiento;
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public Division Division { get; set; }
        public int Valor { get; set; }
        public double Blindaje { get; set; }
        public double Movimiento { get; set; }

        public double DameBlindaje()
        {
            return Blindaje;
        }

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