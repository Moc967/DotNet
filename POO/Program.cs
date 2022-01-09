using POO.Models;

namespace POO
{

    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "João";
            pessoa1.Sobrenome = "Silva";
            pessoa1.Idade = 25;
            pessoa1.Sexo = "Masculino";
            pessoa1.EstadoCivil = "Solteiro";
            pessoa1.Profissao = "Desenvolvedor";
            pessoa1.Email = "";

            pessoa1.Apresentar();

            Retangulo retangulo1 = new Retangulo();
            retangulo1.DefinirMedidas(10, 20);

            System.Console.WriteLine("Área do retângulo: " + retangulo1.CalcularArea());

            Calculadora calculadora1 = new Calculadora();
            System.Console.WriteLine("Soma: " + calculadora1.Somar(10, 20, 30));
        }
    }

}