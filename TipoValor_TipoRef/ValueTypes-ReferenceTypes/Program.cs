using System;
using System.Collections.Generic;


namespace ValueTypes_ReferenceTypes
{
    class Program
    {

        static ref string LocalizaNome(string[] nomes, string nome ){
            for(int i = 0; i<nomes.Length; i++){
                if(nomes[i] == nome)
                    return ref nomes[i];
            }
                    throw new Exception("Nome não encontrado");
        }

       

        //  static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa){
        //     foreach (var item in pessoas)
        //     {
        //         if(item.Nome == pessoa.Nome){ 
        //             return true;
        //         }
        //     }
        //             return false;
        // }

        // static int EncontrarNumero(int[] numeros, int numero){
        //     for (int i = 0; i < numeros.Length; i++)
        //     {
        //        if (numeros[i] == numero)
               
        //           return i; 
        //     }

        //     return -1;
        // }

        public static void Main()
        {
        //    int[] numeros = new int[]{2,4,6,8};
        //     Console.WriteLine("Digite o número que gostaria de encontrar");
        //     var numero = int.Parse(Console.ReadLine());

        //     var idxEncontrado = EncontrarNumero(numeros, numero);

        //     if(idxEncontrado >= 0){
        //         Console.WriteLine($"Valor encontrado na posição: {idxEncontrado}");
        //     }else{ if(idxEncontrado < 0)
        //         Console.WriteLine("Valor não encontrado");
        //     } 


            // List<Pessoa> pessoas = new List<Pessoa>(){
            //     new Pessoa(){Nome = "Ricardo"},
            //     new Pessoa(){Nome = "Renata"},
            //     new Pessoa(){Nome = "Davi"},
            //     new Pessoa(){Nome = "Tiago"},
            // };
            // Console.WriteLine("Qual a pessoa você deseja encontrar?");
            // var nome = Console.ReadLine();
            // var pessoa = new Pessoa(){Nome = nome};
            // var encontrado = EncontrarPessoa( pessoas, pessoa);

            // if(encontrado){
            //     Console.WriteLine("Pessoa encontrada");
            // }else{
            //     Console.WriteLine("Pessoa não encontrada");
            // }

        //     String[] nome = {
        //         "José",
        //         "Maria",
        //         "Marcelo",
        //         "Tereza",
        //         "Renato",
        //     };

        //     Console.WriteLine("Digite um nome a ser localizado");
        //     var Nome = Console.ReadLine();

        //    var localizar = LocalizaNome(nome, Nome);

        //    if(localizar){
        //        Console.WriteLine("Nome localizado");
        //    }else{
        //        Console.WriteLine("Nome não localizado");
        //    }


           String[] nomes = {
                "José",
                "Maria",
                "Marcelo",
                "Tereza",
                "Renato",
            };

            Console.WriteLine("Digite um nome a ser substituído");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite o novo nome");
            var nomeNovo = Console.ReadLine();

            ref var localizado = ref LocalizaNome(nomes, nome);

           if(!String.IsNullOrWhiteSpace(localizado)){
               localizado = nomeNovo;
               Console.WriteLine($@"A lista de nomes alterada é:{
                String.Join(", \n", nomes) }");
           }else{
               Console.WriteLine("Nome não localizado");
           }
        }
    }
}
