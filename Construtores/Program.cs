using Construtores.Models;

namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Data d1 = new Data();
            int mes = d1.LerMes();
            d1.SetMes(mes);
            d1.ApresentarMes();

            d1.dia = 10;
            System.Console.WriteLine("O dia é {0}", d1.dia);

        }

    }
}       