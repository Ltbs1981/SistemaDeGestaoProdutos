using System;

namespace SistemaGestaoProdutos
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pedido pedido = new Pedido(1, "Guitarra", 3, 7500, "13/09/2024");

            pedido.CalculandoTotal();

            Console.WriteLine(pedido.CalculandoTotal());
        }
    }
}
