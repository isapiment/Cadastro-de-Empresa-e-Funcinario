public class Endereco
{
    public string Rua { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public int Numero { get; set; }
    public string Estado { get; set;}

    public Endereco() { }

    public Endereco ( string rua, string bairro, string cidade, int numero, string est)
    {
        this.Rua = rua;
        this.Bairro = bairro;
        this.Cidade = cidade;
        this.Numero = numero;
        this.Estado = est;
    }
}