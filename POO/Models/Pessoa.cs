namespace POO.Models
{
    public class Pessoa
    {
        public string Nome { get; set; } = "";
        public string Sobrenome { get; set; } = "";	
        public int Idade { get; set; }
        public string Sexo { get; set; } = "";
        public string EstadoCivil { get; set; } = "";
        public string Profissao { get; set; } = "";
        public string Email { get; set; } = "";
        public string Telefone { get; set; } = "";
        public string Celular { get; set; } = "";
        public string Endereco { get; set; } = "";
        public string Cidade { get; set; } = "";
        public string Estado { get; set; } = "";
        public string CEP { get; set; } = "";
        public string Pais { get; set; } = "";
        public string Observacao { get; set; } = "";

        public void Apresentar()
        {
            Console.WriteLine();
            Console.WriteLine($"Ola meu Nome é {Nome} e tenho {Idade} anos");
        }
    }
}