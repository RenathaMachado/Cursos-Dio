using System;
using System.IO;
using System.Text;

namespace Arquivos_Streams
{
    class Program
    {
        

        static void  CriarArquivo (String path){
            try // tratamento de erro para quando ser digitado nome do arquivo inválido
            {
                var sw = File.CreateText(path);
                sw.WriteLine("linha 1 do arquivo");
                sw.WriteLine("linha 2 do arquivo");
                sw.WriteLine("linha 3 do arquivo");
                sw.Flush(); // encerra a aplicação e insere o conteúdo no arquivo.
            }
            catch
            {
                
                Console.WriteLine("O nome do arquivo é inválido");
            }
            
        }

        static string LimparNome(string nome){
            foreach (var item in Path.GetInvalidFileNameChars())// método que retorna um array de caracteres inválidos
            {   
                nome = nome.Replace(item, '-'); // método que substitui o caracter inválido por um válido(-).
            }

            return nome;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do arquivo:");
            var nome = Console.ReadLine();
            nome = LimparNome(nome);
            var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");
            CriarArquivo(path);
            Console.WriteLine("Digite enter para finalizar");
            Console.ReadLine();
        }
    }
}
