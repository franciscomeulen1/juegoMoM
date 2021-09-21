using System;
using System.Collections.Generic;
using System.Text;

namespace MoMJuego
{
    class Comida : Item
    {
        private string nombre;
        private int vidaQueCura;
        private int cantidad;

        public Comida(string nombre, int vidaQueCura, int cantidad)
        {
            this.nombre = nombre;
            this.vidaQueCura = vidaQueCura;
            this.cantidad = cantidad;
        }
        public void equipar(Personaje unPersonaje)
        {
            unPersonaje.recargarVida(this);
        }
        public int getVidaQueCura()
        {
            return this.vidaQueCura;
        }
        public int getCantidad()
        {
            return this.cantidad;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public void descontarUno()
        {
            this.cantidad -= 1;
        }
    }
}
