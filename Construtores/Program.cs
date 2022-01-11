using Construtores.Models;

namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Magnovaldo", "Silva");
            p1.Apresentar();

            Log log = Log.GetInstance();
            log.PropriedadeLog = "Teste Instancia";

            Log log2 = Log.GetInstance();
            System.Console.WriteLine(log2.PropriedadeLog);


        }
    }
}       