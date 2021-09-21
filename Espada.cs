using System;
using System.Collections.Generic;
using System.Text;

namespace MoMJuego
{
    class Espada : Arma
    {
        private string nombre;
        private int danioBase;

        public Espada(string nombre)
        {
            this.nombre = nombre;
            this.danioBase = 4;
        }

        public override void equipar(Personaje unPersonaje)
        {
            unPersonaje.setArma(this);
        }

        public override void daniar(Personaje unPersonaje, EstadoDeSalud salud)
        {
            if (salud == EstadoDeSalud.Herido)
            {
                unPersonaje.descontarVida(this.danioBase / 2);
            } else
            {
                unPersonaje.descontarVida(this.danioBase);
            }
            
        }
    }
}
