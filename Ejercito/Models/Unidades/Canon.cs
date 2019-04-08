using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercito.Models.Unidades
{
    public class Canon : IUnidad, IDestructor
    {
        public Canon() { }
        public Canon(int iD, string nombre, double precio, Division division, double potenciaFuego)
        {
            ID = iD;
            Nombre = nombre;
            PotenciaFuego = potenciaFuego;
            Precio = precio;
            Division = division;

        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public double PotenciaFuego { get; set; }
        public double Precio { get; set; }
        public Division Division { get; set; }
        public int Valor { get; set; }
        double IDestructor.PotenciaFuego { get; set; }

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