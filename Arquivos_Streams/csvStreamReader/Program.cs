using System;
using System.IO;



namespace csvStream
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "usuarios-exportacao.csv");
            using var sr = new StreamReader(path);
            var cabecalho = sr.ReadLine()?.Split(',');

            while (true)
            {
                var registro = sr.ReadLine()?.Split(','); // cria um array de string
                if(registro == null) break;
                if(cabecalho.Length != registro.Length){
                    Console.WriteLine("Arquivo fora do padrão");
                    break;
                }

                for(int i = 0; i < registro.Length; i++){
                    Console.WriteLine($"{cabecalho?[i]}:{registro[i]}");
                }
                Console.WriteLine("---------------");
            }

            Console.WriteLine("\n\n Pressione [enter] para finalizar");
            Console.ReadLine();
        }
    }
}
