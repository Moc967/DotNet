namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInteiros = new int[3];
            arrayInteiros[0] = 1;
            arrayInteiros[1] = 2;
            arrayInteiros[2] = 3;

            foreach (int i in arrayInteiros)
            {
                Console.WriteLine(i);
            }
        }
    }
}