using System;
using System.Collections.Generic;
using System.Text;

namespace MoMJuego
{
    class Flecha
    {
        private string nombre;
        private int cantidad;
        private int danio;

        public Flecha(string nombre)
        {
            this.nombre = nombre;
            this.cantidad = 10;
            this.danio = 2;
        }
        public int getCantidad()
        {
            return this.cantidad;
        }
        public int getDanio()
        {
            return this.danio;
        }
    }
}
