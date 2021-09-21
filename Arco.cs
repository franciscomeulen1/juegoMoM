using System;
using System.Collections.Generic;
using System.Text;

namespace MoMJuego
{
    class Arco : Arma
    {
        private string nombre;
        private int danioBase = 2;
        private int danioTotal;
        private int felchasEquipadas;
        public Arco(string nombre)
        {
            this.nombre = nombre;
            this.felchasEquipadas = 0;
            this.danioTotal = 0;
        }
        public override void equipar(Personaje unPersonaje)
        {
            unPersonaje.setArma(this);
        }
        public void equiparFlechas(Flecha flecha)
        {
            this.felchasEquipadas += flecha.getCantidad();
            calcularDanioTotal(flecha);
        }
        private void calcularDanioTotal(Flecha flecha)
        {
            this.danioTotal = this.danioBase + flecha.getDanio();
        }
        public override void daniar(Personaje unPersonaje, EstadoDeSalud salud)
        {
            if (salud == EstadoDeSalud.Herido)
            {
                unPersonaje.descontarVida(this.danioTotal / 2);
            }
            else
            {
                unPersonaje.descontarVida(this.danioTotal);
            }
        }
    }
}
