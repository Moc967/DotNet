namespace POO.Interfaces
{
    public interface iCalculadora
    {
        int Somar(int num1, int num2);

        int Subtrair(int num1, int num2);

        int Multiplicar(int num1, int num2);
        
        int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
        //Quando implementamos o metodo na Interface, nao precisamos implementar o metodo na classe.

    }
}