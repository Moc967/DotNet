using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsusario();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSeries();
                        break;
                    case "3":
                        AtualizarSeries();
                        break;
                    case "4":
                        //ExcluirSerie();
                        break;
                    case "5":
                        //VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;                    
                    default:
                        throw new ArgumentOutOfRangeException();
                    }
                opcaoUsuario = ObterOpcaoUsusario();
            }
            Console.WriteLine(" Obrigado por utilizar nossos serviços!");
            Console.WriteLine();
                   
        }

        private static void ListarSeries()
        {
            Console.WriteLine("Lista de Séries");
            var lista = repositorio.Listar();
            if(lista.Count == 0)
            {
                Console.WriteLine("Não há séries cadastradas");
                return;
            }
            foreach (var serie in repositorio.Listar())
            {
                Console.WriteLine("#ID {0}: - {1}", serie.retornaID(), serie.retornaTitulo());
            }
        }
        private static void InserirSeries()
        {
            Console.WriteLine("Inserir nova Série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
                       
            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();
            
            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite o a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(), 
                                        genero: (Genero)entradaGenero, 
                                        titulo: entradaTitulo, 
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
        repositorio.Inserir(novaSerie);
        }
        private static void AtualizarSeries()
        {
            Console.WriteLine("Digite o id da série");
            int indicaSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
                       
            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();
            
            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite o a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSeries = new Serie(id: indicaSerie, 
                                        genero: (Genero)entradaGenero, 
                                        titulo: entradaTitulo, 
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            repositorio.Atualizar(indicaSerie, atualizaSeries); 
        }

        private static string ObterOpcaoUsusario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Series a seu dospor!!!");
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Series");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();
            
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
    
}
