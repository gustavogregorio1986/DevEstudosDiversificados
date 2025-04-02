using System;
using Logica01.Control;
using Logica01.Entidade;

namespace Logica01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudo estudo = new Estudo();
            estudo.Numero1 = 32;
            estudo.Numero2 = 12;

            Console.WriteLine("Numero1: " + estudo.Numero1);
            Console.WriteLine("Numero2: " + estudo.Numero2);

            ControlaEstudo controlaEstudo = new ControlaEstudo();
            Console.WriteLine("Soma: " + controlaEstudo.Somar(estudo));
            Console.WriteLine("Subtrair: " + controlaEstudo.Subtrair(estudo));
            Console.WriteLine("Multiplicar: " + controlaEstudo.Multiplicar(estudo));
            Console.WriteLine("Dividir: " + controlaEstudo.Divisao(estudo));
        }
    }
}
