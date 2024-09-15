using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestaoProdutos
{
    public class PedidoInternacional: Pedido
    {
        public double TaxaImportacao { get; set; }

        public PedidoInternacional(int id_pedido, string nome_Produto, int quantidade, double preco_Produto, string data_Pedido, double taxaImportacao) : base(id_pedido, nome_Produto, quantidade, preco_Produto, data_Pedido)
        {
            TaxaImportacao = taxaImportacao;
        }
        public double CalculoImportacao() => Preco_Produto * TaxaImportacao+ Quantidade * Preco_Produto;

    }
}
