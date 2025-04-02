using Logica.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Control
{
    public class ControlaEstudo
    {
        public int Sucesor(Estudo estudo)
        {
            int calculo = 0;
            calculo = estudo.Numero + 1;
            return calculo;
        }
    }
}
