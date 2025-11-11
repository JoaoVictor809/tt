using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Executando Teste Automatizado do Sistema de Pedidos ===");

        // --- Cenário de Teste ---
        var cliente = new Cliente(1, "Cliente de Teste");
        var enderecoEntrega = new EnderecoEntrega("Rua Teste", "Bairro Teste", "Cidade Teste", "Estado Teste", "12345-678");
        var pedido = new Pedido(cliente, enderecoEntrega);

        var produto1 = new Produto("Caneta", 1.50);
        var produto2 = new Produto("Caderno", 15.00);
        var produto3 = new Produto("Borracha", 2.00);

        pedido.AdicionarItem(produto1, 2); // 2 * 1.50 = 3.00
        pedido.AdicionarItem(produto2, 1); // 1 * 15.00 = 15.00
        pedido.AdicionarItem(produto3, 3); // 3 * 2.00 = 6.00

        double valorTotalEsperado = 24.00;
        double valorTotalCalculado = pedido.ValorTotal;

        Console.WriteLine("\n=== RESUMO DO PEDIDO PARA TESTE ===");
        Console.WriteLine(pedido);
        Console.WriteLine("=====================================");


        Console.WriteLine($"\nValor Total Esperado: R$ {valorTotalEsperado:F2}");
        Console.WriteLine($"Valor Total Calculado: R$ {valorTotalCalculado:F2}");

        // --- Verificação do Teste ---
        if (valorTotalCalculado == valorTotalEsperado)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[SUCESSO] O valor total do pedido foi calculado corretamente!");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n[FALHA] O valor total do pedido está incorreto!");
            Console.ResetColor();
        }
         Console.WriteLine("\n=== Teste Concluído ===");
    }
}
