using Logica3.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica3.Control
{
    public class ControlaAluno
    {
        public double CalcularAluno(Aluno aluno)
        {
            double calculo = 0.0;
            calculo = (aluno.Nota1 + aluno.Nota2) / 2;
            return calculo;
        }

        public void VerificarStatus(Aluno aluno)
        {
            if (CalcularAluno(aluno) >= 7.0)
            {
                Console.WriteLine($"A {aluno.NomeAluno} foi aprovado!");
            }
            else
            {
                Console.WriteLine($"A {aluno.NomeAluno} foi reprovado!");
            }
    }
}
