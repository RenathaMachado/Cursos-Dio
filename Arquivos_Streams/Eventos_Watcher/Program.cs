using System;
using System.IO;

namespace Eventos_Watcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Andre\Documents\Atividades_Dio\Arquivos_Streams";
            using var fsw = new FileSystemWatcher(path);
            fsw.Created += OnCreated;
            fsw.Deleted += OnDeleted;
            fsw.Renamed += OnRenamed;

            fsw.EnableRaisingEvents = true; // Para que o evento seja disparado
            fsw.IncludeSubdirectories = true; // para que o evento ocorra também nos subdoretórios

            Console.WriteLine($"Monitorando eventos na pasta {path}");
            Console.WriteLine("Aperte [enter] para finalizar");
            Console.ReadLine();

            void OnCreated(object sender, FileSystemEventArgs e){
                Console.WriteLine($"Foi criado o arquivo {e.Name}");
            }

            void OnDeleted(object sender, FileSystemEventArgs e){
                Console.WriteLine($"O arquivo foi exluído {e.Name}");
            }

            void OnRenamed(object sender, FileSystemEventArgs e){
                Console.WriteLine($"O arquivo foi renomeado para {e.Name}");
            }

            
        }
    }
}
