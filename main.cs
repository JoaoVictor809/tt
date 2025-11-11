using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Cadastro de Cliente ===");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        var cliente = new Cliente(1, nome);

        Console.WriteLine("\n=== Endereço de Entrega ===");
        Console.Write("Rua: ");
        string rua = Console.ReadLine();
        Console.Write("Bairro: ");
        string bairro = Console.ReadLine();
        Console.Write("Cidade: ");
        string cidade = Console.ReadLine();
        Console.Write("Estado: ");
        string estado = Console.ReadLine();
        Console.Write("CEP: ");
        string cep = Console.ReadLine();

        var enderecoEntrega = new EnderecoEntrega(rua, bairro, cidade, estado, cep);
        var pedido = new Pedido(cliente, enderecoEntrega);

        Console.WriteLine("\n=== Adicionar Produtos ao Pedido ===");
        string opcao;
        do
        {
            Console.Write("Nome do Produto: ");
            string nomeProduto = Console.ReadLine();

            Console.Write("Preço Unitário: ");
            double precoUnitario = double.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            var produto = new Produto(nomeProduto, precoUnitario);
            pedido.AdicionarItem(produto, quantidade);

            Console.Write("Deseja adicionar outro produto? (s/n): ");
            opcao = Console.ReadLine();
        } while (opcao.Equals("s", StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("\n=== RESUMO DO PEDIDO ===");
        Console.WriteLine(pedido);
    }
}