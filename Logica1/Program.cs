using System;
using Logica1.Control;
using Logica1.Entidade;

namespace Logica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.NomeFuncionario = "Pedro";
            funcionario.Salario = 6578.98;
            funcionario.Percentual = 0.87;

            Console.WriteLine("Nome do Funcionario: " + funcionario.NomeFuncionario);
            Console.WriteLine("Salario: " + funcionario.Salario);
            Console.WriteLine("Percentual: " + funcionario.Percentual);

            ControlaFuncionario controlaFuncionario = new ControlaFuncionario();
            Console.WriteLine("Calcular: " + controlaFuncionario.CalcularSalario(funcionario));

            Console.WriteLine("Calcular Total: " + controlaFuncionario.CalculoTotal(funcionario));
        }
    }
}
