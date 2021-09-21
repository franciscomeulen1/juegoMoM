namespace MoMJuego
{
    abstract class Arma : Item
    {
        public abstract void equipar(Personaje unPersonaje);
        public abstract void daniar(Personaje unPersonaje, EstadoDeSalud salud);

    }
}