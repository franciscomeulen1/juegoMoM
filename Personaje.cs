using System;
using System.Collections.Generic;
using System.Text;

namespace MoMJuego
{
    class Personaje{
        private string nombre;
        private int vida;
        private Arma arma;
        private Armadura armadura;
        private List<Item> inventario;
        private EstadoDeSalud estadoDeSalud;
        private static int vidaMaxima = 20;

        public Personaje(string nombre, Arma arma, Armadura armadura)
        {
            this.nombre = nombre;
            this.vida = vidaMaxima;
            this.arma = arma;
            this.armadura = armadura;
            this.inventario = new List<Item>();
            this.estadoDeSalud = EstadoDeSalud.Vivo;
        }

        public void daniar(Arma arma, Personaje otroPersonaje)
        {
            if (this.estadoDeSalud == EstadoDeSalud.Muerto)
            {
                Console.WriteLine("Personaje muerto. No puede daniar");
            } else 
            {
                arma.daniar(otroPersonaje, this.estadoDeSalud);
            }
            
        }

        public void agregarItemAlInventario(Item item)
        {
            this.inventario.Add(item);
        }
        public void setArma(Arma arma)
        {
            this.arma = arma;
        }
        public void setArmadura(Armadura armadura)
        {
            this.armadura = armadura;
        }
        public void recargarVida(Comida comida)
        {
            if (comida.getCantidad() >= 1)
            {
                this.vida += comida.getVidaQueCura();
                comida.descontarUno();
            }
        }
        public void descontarVida(int cant)
        {
            int vidaADescontar = cant - this.armadura.getDefensa();
            if (this.vida > vidaADescontar)
            {
                this.vida -= vidaADescontar;
                Console.WriteLine("Vida Descontada");
                if (this.vida <= (vidaMaxima / 2))
                {
                  this.estadoDeSalud = EstadoDeSalud.Herido;
                }
            } else
            {
                this.vida = 0;
                this.estadoDeSalud = EstadoDeSalud.Muerto;
                Console.WriteLine("Personaje Muerto");
            }
        }
        public EstadoDeSalud getSalud()
        {
            return this.estadoDeSalud;
        }

    }
}
