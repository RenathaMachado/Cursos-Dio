namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        // Delegate
        public delegate void DelegateCalculadora();
        //Evento
        public static event DelegateCalculadora EventoCalculadora;

        public static void Somar(int x, int y){

            if (EventoCalculadora!=null)
            {
                System.Console.WriteLine($"Soma: {x + y}");
                // Chamada do método que será inscrito no evento.
                EventoCalculadora();
            }else
            {
                System.Console.WriteLine("Nenhum inscrito");
            }
            //System.Console.WriteLine($"Soma: {x + y}");
        }

        public static void Subtrair(int x, int y){
            System.Console.WriteLine($"Subtrair: {x - y}");
        }
    }
}