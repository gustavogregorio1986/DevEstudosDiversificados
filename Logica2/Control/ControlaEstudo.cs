using Logica2.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica2.Control
{
    public class ControlaEstudo
    {
        public void VerificarIf(Estudo estudo)
        {
            if(estudo.Numero > 0)
            {
                Console.WriteLine($"O {estudo.Numero} é positivo");
            }
            else if(estudo.Numero < 0)
            {
                Console.WriteLine($"O {estudo.Numero} é negativo");
            }
            else
            {
                Console.WriteLine($"O {estudo.Numero} é vazio e nullo");
            }
        }
    }
}
