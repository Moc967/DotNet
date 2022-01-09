using System.Collections.Generic;

namespace POO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string path)
        {
            var filePath = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

            foreach (var item in filePath)
            {
                System.Console.WriteLine(item);
            }
        }
        public void ListarArquivos(string path)
        {
            var filePath = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

            foreach (var item in filePath)
            {
                System.Console.WriteLine(item);
            }
        }        
        public void CriarDiretorio(string path)
        {
            var resultado = Directory.CreateDirectory(path);
            System.Console.WriteLine(resultado.FullName);
        }
        public void ApagarDiretorio(string path, bool apagarArquivos )
        {
            Directory.Delete(path, apagarArquivos);
        }
        public void CriarArquivoTexto(string path, string nomeArquivo, string conteudo)
        {
            if(!File.Exists(Path.Combine(path, nomeArquivo)))
            {
                File.WriteAllText(Path.Combine(path, nomeArquivo), conteudo);
                System.Console.WriteLine($"Arquivo {nomeArquivo} criado com sucesso!");
            }
            else
            {
                System.Console.WriteLine("Arquivo já existe");
            }
                        
            
        }
        public void CriarArquivoTextoStream (string path, List<string> conteudo, string nomeArquivo )
        {
            using(var stream = File.CreateText(Path.Combine(path, nomeArquivo)))
            {
                foreach (var item in conteudo)
                {
                    stream.WriteLine(item);
                }
            }
        }
        public void AdicionarTexto (string path, string nomeArquivo, string conteudo)
        {
            using(var stream = File.AppendText(Path.Combine(path, nomeArquivo)))
            {
                stream.WriteLine(conteudo);
            }
        }
    }
}