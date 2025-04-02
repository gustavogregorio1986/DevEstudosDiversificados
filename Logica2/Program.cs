using System;
using Logica2.Control;
using Logica2.Entidade;

namespace Logica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Estudo estudo = new Estudo();
            estudo.Numero = 3;
            Console.WriteLine("Numero: " + estudo.Numero);

            ControlaEstudo controlaEstudo = new ControlaEstudo();
            controlaEstudo.VerificarIf(estudo);
        }
    }
}
