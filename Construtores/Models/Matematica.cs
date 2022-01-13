namespace Construtores.Models
{
    public class Matematica
    {
        public int X { get; set; }
        public int Y { get; set; }  
        public Matematica (int x, int y)
        {
            X = x;
            Y = y;

            Calculadora.EventoCalculadora += Eventhandler;
        }
        public void Somar()
        {
            Calculadora.Somar(X, Y);
        }

        public void Eventhandler()
        {
            System.Console.WriteLine("Evento disparado");
        } 
    }
}