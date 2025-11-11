public class cliente
{
  public int Codigo { get; set; }
  public string Nome { get; set; }

  public cliente(int codigo, string nome)
  {
    Codigo = codigo;
    Nome = nome;  
  }
  public override string ToString()
  {
    return $"Código: {Codigo}, Nome: {Nome}";
  }
}