using Construtores.Models;

namespace Construtores
{
    class Program
    {
        public delegate void Operacao(int a, int b);
        static void Main(string[] args)
        {
            Matematica mat = new Matematica(10, 20);

            mat.Somar();
            
            // Operacao op = new Operacao(Calculadora.Somar);
            // op += Calculadora.Subtrair;
            // op.Invoke(1, 2);
            // // op(3, 4);

            // Data d1 = new Data();
            // int mes = d1.LerMes();
            // d1.SetMes(mes);
            // d1.ApresentarMes();

            // d1.dia = 10;
            // System.Console.WriteLine("O dia é {0}", d1.dia);

        }

    }
}       