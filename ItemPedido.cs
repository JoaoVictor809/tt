public class ItemPedido
{
  public Produto Produto { get; private set; }
  public int Quantidade { get; private set; }

  public ItemPedido(Produto produto, int quantidade)
  {
    Produto = produto;
    Quantidade = quantidade;
  }
  public double TotalItem => Produto.PrecoUnitario* Quantidade;

  public override string ToString()
  {
    return $"{Produto.Nome} | Qtd: {Quantidade} | Total: R$ {TotalItem: F2}"  
    }
}