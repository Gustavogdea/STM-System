using AplicandoConhecimentosCursosAlura.Model;
using System.Formats.Tar;

class Produto
{
    public Produto(string? nome, string? marca, Fornecedor fornecedor)
    {
        Nome = nome;
        Marca = marca;
        FornecedorProduto = fornecedor;
    }
    public int Id { get; set; }
    public string? Nome { get; }
    public string? Marca { get; }
    public int Quantidade { get; set; }
    public Fornecedor FornecedorProduto { get; }
    public DateTime DataEntrada { get; set; } = DateTime.Now;
    public decimal ValorUnitario { get; set; }
    public decimal ValorTotal
    {
        get { return ValorUnitario * Quantidade; }
    }

    public void ExibirProduto()
    {
        Console.Clear();
        //Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Quantidade: {Quantidade}");
        Console.WriteLine($"Valor Unitário: {ValorUnitario:C}");
        Console.WriteLine($"Valor Total: {ValorTotal:C}");
        Console.WriteLine($"Fornecedor: {FornecedorProduto.Nome}");
        Console.WriteLine($"Cidade: {FornecedorProduto.Cidade}");
        Console.WriteLine($"Estado: {FornecedorProduto.Estado}");
        Console.WriteLine($"País: {FornecedorProduto.Pais}");
    }
}