using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        //Delegate
        public delegate void Operacao(int x,int y);
        
        static void Main(string[] args)
        {
            //Operacao op = new Operacao(Calculadora.Somar);

            //Delegate multi cast
            //op += Calculadora.Subtrair;
            //op.Invoke(10, 40);
            //op(10, 40);

            //Pessoa pessoa = new Pessoa("Renata", "Machado");
            //Aluno aluno = new Aluno("Renata", "Machado", "Matemática");
            //aluno.Apresentar();

            //Log log = Log.GetInstance();
            //log.propriedadeLog = "teste instancia";

            //Mesmo criando outra instância do método o valor permanecerá o mesmo

            //Log Log2 = Log.GetInstance();
            //System.Console.WriteLine(Log2.propriedadeLog);

            //Data data = new Data();

            //data.SetMes(15);
            //data.ApresentarMes();

            // Propriedades

            //data.Mes = 12;
            //System.Console.WriteLine(data.Mes);

            // Eventos

            Matematica mat = new Matematica(2,5);
            mat.Somar();

        }
    }
}
