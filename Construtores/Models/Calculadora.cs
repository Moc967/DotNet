namespace Construtores.Models
{
    public class Calculadora
    {
        // Delegate
        public delegate void DelegateCalculadora();
        public static event DelegateCalculadora EventoCalculadora;

        public static void Somar(int a, int b)
        {
            if (EventoCalculadora != null)
            {
                System.Console.WriteLine("Soma: {0}", a + b);
                EventoCalculadora();
            }
            else
            {
                System.Console.WriteLine("Nenhum inscrito");
            }

        }
        // public static void Subtrair(int a, int b)
        // {
        //     System.Console.WriteLine("Subtração: {0}", a - b); 
        // }
    }
}