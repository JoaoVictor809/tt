using System;
using System.Collections.Generic;

public class Pedido
{
  public DateTime Data { get; private set; }
  public Cliente Cliente { get; private set; }
  public EnderecoEntrega EnderecoEntrega { get; private set; }
  public List<ItemPedido> Itens { get; private set; }

  public Pedido(Cliente cliente, EnderecoEntrega enderecoEntrega)
  {
    Data = DateTime.Now;
    Cliente = cliente;
    EnderecoEntrega = enderecoEntrega;
    Itens = new List<ItemPedido>();
  }
  public void AdicionarItem(Produto produto, int quantidade)
  {
    Itens.Add(new ItemPedido(produto, quantidade));
  }
  public double ValorTotal
  {
    get
    {
      double total = 0;
      foreach (var item in Itens)
          total += item.TotalItem;
      return total;
    }
  }
  public override string ToString()
  {
    string resultado = $"Data: {Data}\n{Cliente}\n";
    resultado += $" Endereço de Entrega: {EnderecoEntrega}\n";
    resultado += "Itens:\n";
    foreach (var item in Itens)
    {
      resultado += "   " + item + "\n";
    }
    resultado += $"Valor Total: R$ {ValorTotal:F2}";
    return resultado;
    }
}
