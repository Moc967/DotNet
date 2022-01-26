using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[] { 48, 196, 23, 19,77,48,17,10,18,29,43, 11, 0, 43, 2, 12, 6, 17, 18, 29, 10 };

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var arrayUnico = arrayNumeros.Distinct().ToArray();

            System.Console.WriteLine($"Minimo: {minimo}");
            System.Console.WriteLine($"Maximo: {maximo}");
            System.Console.WriteLine($"Medio: {medio}");
            System.Console.WriteLine($"Soma: {soma}");
            System.Console.WriteLine($"Array original: {string.Join(", ", arrayNumeros)}");
            System.Console.WriteLine($"Array distinto: {string.Join(", ", arrayUnico)}"); 



            
            // var numerosParesQuery =
            //     from numero in arrayNumeros
            //     where numero % 2 == 0
            //     orderby numero
            //     select numero;
            
            // var numerosParesMetodo = arrayNumeros.Where(numero => numero % 2 == 0).OrderBy(numero => numero).ToList();
            
            // System.Console.WriteLine("Numeros pares query : " + string.Join(", ", numerosParesQuery));
            // System.Console.WriteLine("Numeros pares metodo : " + string.Join(", ", numerosParesMetodo));
            
            //
            
            // Dictionary<string, string> estados = new Dictionary<string, string>();
            // estados.Add("AC", "Acre");
            // estados.Add("AL", "Alagoas");
            // estados.Add("AP", "Amapá");
            // estados.Add("BA", "Bahia");
            // estados.Add("CE", "Ceará");
            // estados.Add("DF", "Distrito Federal");
            // estados.Add("ES", "Espírito Santo");

            // foreach (var estado in estados)
            // {
            //     System.Console.WriteLine($"{estado.Key} - {estado.Value}");
            // }
            
            // string valorProcurado = "CE";
            // System.Console.WriteLine($"Valor procurado: {valorProcurado}");

            //
            // Stack<string> pilhaLivros = new Stack<string>();

            // pilhaLivros.Push("O Senhor dos Anéis");
            // pilhaLivros.Push("O Hobbit");
            // pilhaLivros.Push("Star Wars");
            // pilhaLivros.Push("A Coisa");
            // pilhaLivros.Push("O Senhor dos Anéis , As Duas Torres");
            // pilhaLivros.Push("O Hobbit, A Desolação");

            // System.Console.WriteLine("Livros para a Leitura: " + pilhaLivros.Count);
            
            // while (pilhaLivros.Count > 0)
            // {
            //     System.Console.WriteLine("Proximo livro para leitura: " + pilhaLivros.Peek());
            //     System.Console.WriteLine($"{pilhaLivros.Pop()}, lido com sucesso!");
            // }   
            
            // System.Console.WriteLine("Livros para a Leitura: " + pilhaLivros.Count);
                        
            //
            // Queue<string> fila = new Queue<string>();
            // fila.Enqueue("Primeiro");
            // fila.Enqueue("Segundo");
            // fila.Enqueue("Terceiro");
            // fila.Enqueue("Quarto");
            // fila.Enqueue("Quinto");

            // foreach (var item in fila)
            // {
            //     System.Console.WriteLine(item);
            // }   
            
            // System.Console.WriteLine("Pessoas na fila: " + fila.Count);

            // while (fila.Count > 0)
            // {
            //     System.Console.WriteLine("Vez de: " + fila.Peek());
            //     System.Console.WriteLine(fila.Dequeue() + " atendido");
            // }
            
            // System.Console.WriteLine("Pessoas na fila: " + fila.Count);
            
            // OperacoesLista opLista = new OperacoesLista();
            // List<string> estados = new List<string>();
            // string[] estadosArray = new string[10] {"BA", "PE", "RN", "AL", "CE", "MA", "PI", "GO", "DF", "MT"};

            
            // estados.Add("RJ");
            // estados.Add("SP");
            // estados.Add("MG");
            // estados.Add("ES");
            // estados.Add("SC");
            // estados.Add("PR");
            // estados.Add("RS");

            // System.Console.WriteLine("Quantidade de elementos na lista: " + estados.Count);
            // estados.AddRange(estadosArray);
            // opLista.ImprimirListaString(estados);

            // estados.Remove("MG");
            // System.Console.WriteLine("Quantidade de elementos na lista após remoção: " + estados.Count);
            // opLista.ImprimirListaString(estados);



            // for (int i = 0; i < estados.Count; i++)
            // {
            //     System.Console.WriteLine($"Indice {i}, Valor: {estados[i]}");
            // }
            // foreach (string estado in estados)
            // {
            //     System.Console.WriteLine(estado);
            // }

            
            // OperacoesArray op = new OperacoesArray();
            // int [] array = new int[10]{12, 3, 1, 19, 11, 5, 14, 2, 13, 7};
            // int [] arrayCopia = new int[15];

            // string [] arrayString = op.ConvertParaArrayString(array);

            // int valorProcurado = 13;

            // System.Console.WriteLine("Capacidade atual do array: " + array.Length);

            // op.RedimensionarArray(ref array, array.Length*2);

            // System.Console.WriteLine("Nova capacidade do array: " + array.Length);

            // op.ImprimirArray(array);

            // int indice = op.ObterIndice(array, valorProcurado);

            // if (indice == -1)
            // {
            //     Console.WriteLine("O valor {0} não foi encontrado no array", valorProcurado);
            // }
            // else
            // {
            //     Console.WriteLine("O valor {0} foi encontrado na posição {0} do array", indice);
            // }

            // int valorAchado = op.ObterValor(array, valorProcurado);

            // if(valorAchado > 0)
            // {
            //     Console.WriteLine("Encontrei o valor {0}", valorAchado);
            // }
            // else
            // {
            //     Console.WriteLine("Não encontrei o valor {0}", valorProcurado);
            // }

            // bool TodosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

            // if( TodosMaiorQue )
            // {
            //     Console.WriteLine("Todos os elementos são maiores que {0}", valorProcurado);
            // }
            // else
            // {
            //     Console.WriteLine("Existem elementos com valores maiores que {0}", valorProcurado);
            // }
            
            // bool existe = op.Existe(array, valorProcurado);

            // if (existe)
            // {
            //     Console.WriteLine("Encontrei o valor {0}", valorProcurado);
            // }
            // else
            // {
            //     Console.WriteLine("Não encontrei o valor {0}", valorProcurado);
            // }
            
        // System.Console.WriteLine("Array antes da ordenação: ");            
        // op.ImprimirArray(array);

        //   op.OrdenarBubbleSort(ref array);
        //   op.Ordenar(ref array);
           
        //    System.Console.WriteLine("Array antes da copia: ");
        //    op.ImprimirArray(arrayCopia);
           
        //    op.Copiar(ref array, ref arrayCopia);
    	   
        //    System.Console.WriteLine("Array depois da copia: ");
        //    op.ImprimirArray(arrayCopia);

        //   System.Console.WriteLine("Array depois da ordenação: ");
        //   op.ImprimirArray(array);


        
        // int[,] matriz = new int[4,2]
        // {
        //     {1,2},
        //     {3,4},
        //     {5,6},
        //     {7,8}
        // };
        // for(int i = 0; i< matriz.Length; i++)
        // {
        //     for(int j = 0; j< matriz.Length; j++)
        //     {
        //         Console.WriteLine(matriz[i,j]);
        //     }
        // }
        }   
        //     int[] arrayInteiros = new int[3];
        //     arrayInteiros[0] = 10;
        //     arrayInteiros[1] = 22;
        //     arrayInteiros[2] = 33;
            
        //     System.Console.WriteLine("Foreach test");
        //     foreach (int i in arrayInteiros)
        //     {
        //         Console.WriteLine(i);
        //     }

        //     System.Console.WriteLine("for test");
        //     for (int i = 0; i < arrayInteiros.Length; i++)
        //     {
        //         Console.WriteLine(i);
        //         Console.WriteLine(arrayInteiros[i]);
        //     }
        // }
    }
}