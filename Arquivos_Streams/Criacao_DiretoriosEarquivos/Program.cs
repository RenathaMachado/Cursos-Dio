using System;
using System.IO;
using System.Text;

namespace Criacao_DiretoriosEarquivos
{
    class Program
    {

        static void CopiarArquivo(string pathOrigem, string pathDestino){
            if(!File.Exists(pathOrigem)){
                Console.WriteLine("Não existe um arquivo com este nome");
                return;
            }
            if(File.Exists(pathDestino)){
                Console.WriteLine("Já existe um arquivo com este nome");
                return;
            }
                
            File.Copy(pathOrigem, pathDestino);
        }
        
        static void MoverArquivo(string pathOrigem, string pathDestino){

            if(!File.Exists(pathOrigem)){
                Console.WriteLine("Não existe um arquivo com este nome");
                return;
            }
                
            if(File.Exists(pathDestino)){
                Console.WriteLine("Já existe um arquivo com este nome");
                return;
            }
             File.Move(pathOrigem, pathDestino);
            
        }

        static void CriarArquivo(){
            var path = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
            if (!File.Exists(path))
            {
                var criar = File.CreateText(path);
                criar.WriteLine("População: 213MM");
                criar.WriteLine("IDH: 0,901");
                criar.WriteLine("Dados atualizados em: 26/02/2022");
                criar.Flush();
            }else{
                Console.WriteLine("Arquivo já existe");
            }
        }

        static void CriarDiretoriosGlobo(){

            var path = Path.Combine(Environment.CurrentDirectory, "globo");
            if(!Directory.Exists(path)){
                
                var dirGlobo = Directory.CreateDirectory(path);
                var dirAmNorte = dirGlobo.CreateSubdirectory("América do Norte");
                var dirAmCentral = dirGlobo.CreateSubdirectory("América do Central");
                var dirAmSul = dirGlobo.CreateSubdirectory("América do Sul");

                dirAmNorte.CreateSubdirectory("USA");
                dirAmNorte.CreateSubdirectory("México");
                dirAmNorte.CreateSubdirectory("Canadá");

                dirAmCentral.CreateSubdirectory("Costa Rica");
                dirAmCentral.CreateSubdirectory("Panamá");
                

                dirAmSul.CreateSubdirectory("Brasil");
                dirAmSul.CreateSubdirectory("Argentina");
                dirAmSul.CreateSubdirectory("Paraguai");
            }else{
                Console.WriteLine("Já existe diretório criado");
            }
        }


        static void Main(string[] args)
        {
            // CriarDiretoriosGlobo();
            // CriarArquivo();
            // var origem = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
            // var destino = Path.Combine(Environment.CurrentDirectory, "globo", "América do Sul", "Brasil", "brasil.txt");
            // MoverArquivo(origem, destino);
            var origem = Path.Combine(Environment.CurrentDirectory,"globo", "América do Sul", "Brasil", "brasil.txt");
            var destino = Path.Combine(Environment.CurrentDirectory, "globo", "América do Sul", "Argentina", "argentina.txt");
            CopiarArquivo(origem, destino);
        }
    }
}
