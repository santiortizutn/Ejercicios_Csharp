﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Carreta:Vehiculo, IARBA
    {
        public Carreta(double precio)
            : base(precio)
        { }

        public override void MostrarPrecio()
        {
            Console.WriteLine(this._precio);
        }

        public double CalcularImpuesto()
        {
            return (this._precio * 18) / 100;
        }
    }
}
