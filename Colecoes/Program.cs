using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Primeiro");
            fila.Enqueue("Segundo");
            fila.Enqueue("Terceiro");
            fila.Enqueue("Quarto");
            fila.Enqueue("Quinto");

            foreach (var item in fila)
            {
                System.Console.WriteLine(item);
            }   
            
            System.Console.WriteLine("Pessoas na fila: " + fila.Count);

            while (fila.Count > 0)
            {
                System.Console.WriteLine("Vez de: " + fila.Peek());
                System.Console.WriteLine(fila.Dequeue() + " atendido");
            }
            
            System.Console.WriteLine("Pessoas na fila: " + fila.Count);
            
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