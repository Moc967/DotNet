namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            
            string opcaoUsuario = ObterOpcaoDoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //Todo: Inserir novo aluno
                        Console.WriteLine("Informe o novo do aluno:");
                        var aluno = new Aluno();
                        
                        aluno.Nome = Console.ReadLine();
                        
                        Console.WriteLine("Informe a nota do aluno:");

                        if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException ("O valor da nota deve ser decimal");
                        }
                        alunos[indiceAluno]=aluno;
                        indiceAluno++;

                        
                        break;
                    case "2":
                        //Todo: Listar alunos   
                        foreach (var a in alunos)
                        {
                            if(string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"Aluno: {a.Nome}, Nota: {a.Nota}");
                            }
                        }
                        break;
                    case "3":
                        //Todo: Calcular media geral
                        //CalcularMediaGeral()
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();

                }
                opcaoUsuario = ObterOpcaoDoUsuario();

            }


        }

        private static string ObterOpcaoDoUsuario()
        {
            Console.WriteLine();            
            Console.WriteLine("Informe a opcao desejada: ");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular media geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();            
            return opcaoUsuario;
        }
    }
}
