namespace MoMJuego
{
    internal class Armadura
    {
        private string nombre;
        private int defensa;

        public Armadura(string nombre)
        {
            this.nombre = nombre;
            this.defensa = 2;
        }
        public void equipar(Personaje unPersonaje)
        {
            unPersonaje.setArmadura(this);
        }
        public int getDefensa()
        {
            return this.defensa;
        }
    }
}