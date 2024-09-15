using System;

namespace SistemaGestaoProdutos
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pedido pedido = new Pedido(1, "Guitarra", 3, 7000, "13/09/2024");

            pedido.CalculandoTotal();

            Console.WriteLine(pedido.CalculandoTotal());

            PedidoNacional pedidoNacional = new PedidoNacional(2, "contra-baixo", 1, 100, "14/09/2024", 0.1);
            pedidoNacional.TaxaImpostoNacional();
            Console.WriteLine(pedidoNacional.TaxaImpostoNacional());

            PedidoInternacional pedidoInternacional = new PedidoInternacional(3, "aplificador", 1, 500, "15/09/2024", 0.20);
            pedidoInternacional.CalculoImportacao();
            Console.WriteLine(pedidoInternacional.CalculoImportacao());

        }
    }
}
