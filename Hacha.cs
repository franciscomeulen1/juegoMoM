using System;
using System.Collections.Generic;
using System.Text;

namespace MoMJuego
{
    class Hacha : Arma
    {
        private string nombre;
        private int danioBase;
        private float probabDanioCritico;
        public Hacha(string nombre)
        {
            this.nombre = nombre;
            this.danioBase = 4;
        }
        public override void equipar(Personaje unPersonaje)
        {
            unPersonaje.setArma(this);
        }
        private bool golpeCritico()
        {
            return true;
        }
        public override void daniar(Personaje unPersonaje, EstadoDeSalud salud)
        {
            if (salud == EstadoDeSalud.Herido)
            {
                if (golpeCritico())
                {
                    unPersonaje.descontarVida(this.danioBase * 2 / 2);
                } else
                {
                    unPersonaje.descontarVida(this.danioBase / 2);
                }
            }
            else
            {
                if (golpeCritico())
                {
                    unPersonaje.descontarVida(this.danioBase * 2);
                }
                else
                {
                    unPersonaje.descontarVida(this.danioBase);
                }
            }

        }
    }
}
