namespace POO.Models
{
    public class Retangulo
    {
        private double comprimento;
        private double largura;
        private bool valido;

        public void DefinirMedidas(double comprimento, double largura)
        {
           if (comprimento > 0 && largura > 0)
            {
                this.comprimento = comprimento;
                this.largura = largura;
                valido = true;
            }
            else
            {
                //atalho cw para chamar System.Console.WriteLine()
                System.Console.WriteLine("Comprimento e largura devem ser maiores que zero");
            }
           
            this.comprimento = comprimento;
            this.largura = largura;
        }
        public double CalcularArea()
        {
            if (valido)
            {
                return comprimento * largura;
            }
            else
            {
                System.Console.WriteLine("Comprimento e largura devem ser maiores que zero");
                return 0;
            }

        }
    }
}