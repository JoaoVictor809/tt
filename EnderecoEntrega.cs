public class EnderecoEntrega
{
  public string Rua { get; set; }
  public string Bairro { get; set; }
  public string Cidade { get; set; }
  public string Estado { get; set; }
  public string Cep { get; set; }

  public EnderecoEntrega(string rua, string bairro, string cidade, string estado, string cep)
  {
    Rua = rua;
    Bairro = bairro;
    Cidade = cidade;
    Estado = estado;
    Cep = cep;
  }

  public override string ToString()
  {
    return $"{Rua}, {Bairro}, {Cidade}, {Estado}, {Cep}";
  }
}
