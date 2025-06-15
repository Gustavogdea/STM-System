using System.Formats.Tar;

class Produto
{
    public Produto(string? nome, string? marca, int quantidade)
    {
        Nome = nome;
        Marca = marca;
        Quantidade = quantidade;
    }
    public int Id { get; }
    public string? Nome { get; }
    public string? Marca { get; set; }
    public int Quantidade { get; set; }
    public DateTime DataEntrada { get; set; }
    public double ValorUnitario { get; set; }
    public double ValorTotal
    {
        get { return ValorUnitario * Quantidade; }
    }
}