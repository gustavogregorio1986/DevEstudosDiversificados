using Logica02.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica02.Control
{
    public class ControlarProduto
    {
        public double Calcualarproduto(Produto produto)
        {
            double resultado = 0.0;
            resultado = produto.Preco * produto.Quantidade;
            return resultado;
        }
    }
}
