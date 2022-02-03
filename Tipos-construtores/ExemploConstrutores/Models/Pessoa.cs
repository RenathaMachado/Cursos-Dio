namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
       // private string nome;
       // private string sobrenome;

       // Utilizando modificador de acesso readonly

       private readonly string nome = "Davi";
       private readonly string sobrenome;

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("Classe Pessoa");
        }

        // public Pessoa()
        // {
        //     nome = string.Empty;
        //     sobrenome = string.Empty;
        // }

        public void Apresentar(){
            System.Console.WriteLine($"Meu nome é:{nome} {sobrenome}");
        }
    }
}