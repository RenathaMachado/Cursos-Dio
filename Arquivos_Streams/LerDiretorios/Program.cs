using System;
using System.IO;

namespace LerDiretorios
{
    class Program
    {
        
        static void LerDiretorios(string path){

            if(Directory.Exists(path)){
                var diretorios = Directory.GetDirectories(path,"*", SearchOption.AllDirectories);
                foreach (var dir in diretorios)
                {
                var dirInfo = new DirectoryInfo(dir);
                Console.WriteLine($"[Nome] :{dirInfo.Name}");
                Console.WriteLine($"[Raiz] :{dirInfo.Root}");
                if(dirInfo.Parent != null)
                    Console.WriteLine($"[Pai] : {dirInfo.Parent.Name}");

                Console.WriteLine("-----------------------------");
                }
            }else{
                Console.WriteLine($"{path} não existe");
            }
            
        }
        static void Main(string[] args)
        {
            var path = @"C:\Users\Andre\Documents\Atividades_Dio\Arquivos_Streams";
            LerDiretorios(path);
        }
    }
}
