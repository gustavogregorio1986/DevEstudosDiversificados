using Logica01.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica01.Control
{
    public class ControlaEstudo
    {
        public int Somar(Estudo estudo)
        {
            int calculo = 0;
            calculo = estudo.Numero1 + estudo.Numero2;
            return calculo;
        }

        public int Subtrair(Estudo estudo)
        {
            int calculo = 0;
            calculo = estudo.Numero1 - estudo.Numero2;
            return calculo;
        }

        public int Multiplicar(Estudo estudo)
        {
            int calculo = 0;
            calculo = estudo.Numero1 * estudo.Numero2;
            return calculo;
        }

        public int Divisao(Estudo estudo)
        {
            int calculo = 0;
            calculo = estudo.Numero1 / estudo.Numero2;
            return calculo;
        }
    }
}
