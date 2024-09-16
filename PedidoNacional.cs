using System;

namespace SistemaGestaoProdutos
{
    public class PedidoNacional : Pedido
    {
        public double Imposto { get; set; }

        public PedidoNacional(int id_pedido, string nome_Produto, int quantidade, double preco_Produto, string data_Pedido, double imposto)
            : base(id_pedido, nome_Produto, quantidade, preco_Produto, data_Pedido)
        {
            Imposto = imposto;
        }

        public override double CalculandoTotal()
        {
            return Quantidade * Preco_Produto * (1 + Imposto);
        }
    }
}
