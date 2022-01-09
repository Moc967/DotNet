namespace Models
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
        }
    }

}