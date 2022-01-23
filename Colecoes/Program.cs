using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesArray op = new OperacoesArray();
            int [] array = new int[10]{12, 3, 1, 19, 11, 5, 14, 2, 13, 7};
            int [] arrayCopia = new int[15];

            int valorProcurado = 99;
            
            bool existe = op.Existe(array, valorProcurado);

            if (existe)
            {
                Console.WriteLine("Encontrei o valor {0}", valorProcurado);
            }
            else
            {
                Console.WriteLine("Não encontrei o valor {0}", valorProcurado);
            }
            
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