using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercito.Models.Unidades
{
    public class TorpederoM : IUnidad, IMovimiento, IDestructor, IBlindado
    {
        public TorpederoM() { }
        public TorpederoM(int iD, string nombre, double precio, Division division, double movimiento, double potenciaFuego, double blindaje, int valor)
        {
            ID = iD;
            Nombre = nombre;
            Precio = precio;
            Division = division;
            Movimiento = movimiento;
            PotenciaFuego = potenciaFuego;
            Blindaje = blindaje;
            Valor = valor;
        }

        public int ID { get; set; }
        public string Nombre{ get; set; }
        public double Precio{ get; set; }
        public Division Division{ get; set; }
        public double Movimiento{ get; set; }
        public double PotenciaFuego{ get; set; }
        public double Blindaje{ get; set; }
        public int Valor { get; set; }

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