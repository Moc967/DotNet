namespace Construtores.Models
{
    public class Data
    {
        private int mes;
        private bool mesValido;
        public int LerMes()
        {
            mes = 0;
            System.Console.WriteLine("Digite o mês: ");
            mes = int.Parse(Console.ReadLine());
            return mes;
        }
        public int GetMes()
        {
            return this.mes;
        }
        public void SetMes(int mes)
        {

            if(mes> 0 && mes <= 12)
            {
                this.mes = mes;
                mesValido = true;
            }
        }
        public void ApresentarMes()
        {
            if(mesValido)
            {
                System.Console.WriteLine("O mes é informado é {0}", mes);
            }
            else
            {
                System.Console.WriteLine("{0} é um mês inválido", mes);
                System.Console.WriteLine();
                LerMes();
                SetMes(mes);
                ApresentarMes();
            }
        }
        public int dia { get; set; } //digitar prop + tab to declarar uma propriedade que contem get e set

    }
}