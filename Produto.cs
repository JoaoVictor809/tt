public class Produto
{
    public string Nome { get; set; }
    public double PrecoUnitario { get; set; }

    public Produto(string nome, double precoUnitario)
    {
        Nome = nome;
        PrecoUnitario = precoUnitario;
    }
}
