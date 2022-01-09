using POO.Helper;
using POO.Models;
using System.Collections;

namespace POO
{

    class Program
    {
        static void Main(string[] args)
        {
            var path = "c:\\DotNetFolder";
            var fileHelper = new FileHelper();
            var caminhoPathCombine = Path.Combine(path, "Folder T2");
            
            //Criando arquivo texto stream
            var conteudo = new List<string>()
            {
                "Primeira linha",
                "Segunda linha",
                "Terceira linha"
            };
            fileHelper.CriarArquivoTextoStream(caminhoPathCombine, conteudo, "ArquivoTextoStream.txt");


            //Criando arquivo texto

            // fileHelper.CriarArquivoTexto(caminhoPathCombine, "Criado With CSharp.txt", "Conteudo do arquivo");

            // Apagar diretório
            // fileHelper.ApagarDiretorio(caminhoPathCombine, true);

            //Criando um diretorio com o metodo CriarDiretorio 

            // var caminhoPathCombine = Path.Combine(path, "Folder T3", "SubFolder T3");
            // System.Console.WriteLine("Criando diretorio" + caminhoPathCombine);
            // fileHelper.CriarDiretorio(caminhoPathCombine);
            // Fim do metodo CriarDiretorio


            // FileHelper helpers = new FileHelper();
            // helpers.ListarDiretorios(path);
            // helpers.ListarArquivos(path);

        // Exemplos para objetos implicitos.
        //  Computador computador = new Computador();
        //  computador.ToString();
        // Fim do exemplo para objetos implicitos.
        
        // Corrente c1 = new Corrente();
        // c1.Creditar(100);
        // c1.ExibirSaldo();    
           

        // Diretor d1 = new Diretor();
        // d1.Apresentar();
        // Pessoa pessoa1 = new Pessoa();
        // pessoa1.Nome = "João";
        // pessoa1.Sobrenome = "Silva";
        // pessoa1.Idade = 25;
        // pessoa1.Sexo = "Masculino";
        // pessoa1.EstadoCivil = "Solteiro";
        // pessoa1.Profissao = "Desenvolvedor";
        // pessoa1.Email = "";

        // pessoa1.Apresentar();

        // Retangulo retangulo1 = new Retangulo();
        // retangulo1.DefinirMedidas(10, 20);

        // System.Console.WriteLine("Área do retângulo: " + retangulo1.CalcularArea());

        // Calculadora calculadora1 = new Calculadora();
        // System.Console.WriteLine("Soma: " + calculadora1.Somar(10, 20, 30));
        }
    }

}