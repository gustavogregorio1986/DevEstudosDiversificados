using System;
using Logica3.Control;
using Logica3.Entidade;

namespace Logica3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.NomeAluno = "Pedro";
            aluno.Nota1 = 6.9;
            aluno.Nota2 = 1.7;

            Console.WriteLine("Nome do Aluno: " + aluno.NomeAluno);
            Console.WriteLine("Nota1: " + aluno.Nota1);
            Console.WriteLine("Nota2: " + aluno.Nota2);

            ControlaAluno controlaAluno = new ControlaAluno();
            Console.WriteLine("Calcular: " + controlaAluno.CalcularAluno(aluno));
        }
    }
}
