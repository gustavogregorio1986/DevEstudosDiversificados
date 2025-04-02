using System;
using Logica.Control;
using Logica.Entidade;

namespace Logica
{
    public class Program
    {
        static void Main(string[] args)
        {
            Estudo estudo = new Estudo();
            estudo.Numero = 32;

            Console.WriteLine("Numero: " + estudo.Numero);

            ControlaEstudo controlaEstudo = new ControlaEstudo();
            Console.WriteLine("Calculo: " + controlaEstudo.Sucesor(estudo));
        }
    }
}
