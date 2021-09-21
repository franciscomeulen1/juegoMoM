using System;

namespace MoMJuego
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Arma espada1 = new Espada("espada1");
            Armadura armadura1 = new Armadura("armadura1");
            Personaje per1 = new Personaje("Gauchito", espada1, armadura1);

            Arma espada2 = new Espada("espada2");
            Armadura armadura2 = new Armadura("armadura2");
            Personaje per2 = new Personaje("Manchito", espada2, armadura2);
        }
    }
}
