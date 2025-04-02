using Logica02.Control;
using Logica02.Entidade;
using System;

namespace Logica02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            produto.NomeProduto = "Pedro";
            produto.Preco = 43.43;
            produto.Quantidade = 2;

            Console.WriteLine("Nome do produto: " + produto.NomeProduto);
            Console.WriteLine("Preço: " + produto.Preco);
            Console.WriteLine("Quantidade: " + produto.Quantidade);

            ControlarProduto controlarproduto = new ControlarProduto();
            Console.WriteLine("Calcular: " + controlarproduto.Calcualarproduto(produto));
        }
    }
}
