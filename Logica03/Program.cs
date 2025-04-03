using System;
using Logica03.Control;
using Logica03.Entidade;

namespace Logica03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudo estudo = new Estudo();
            estudo.Mes = 3;
            Console.WriteLine("P numero é: " + estudo.Mes);

            ControlaEstudo controlaEstudo = new ControlaEstudo();
            controlaEstudo.VerificarMes(estudo);
        }
    }
}
