using Logica1.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica1.Control
{
    public class ControlaFuncionario
    {
        public double CalcularSalario(Funcionario funcionario)
        {
            double result = 0;
            result = funcionario.Salario * funcionario.Percentual;
            return result;
        }

        public double CalculoTotal(Funcionario funcionario)
        {
            double result = 0;
            result = CalcularSalario(funcionario) + funcionario.Salario;
            return result;
        }
    }
}
