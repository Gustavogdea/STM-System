using AplicandoConhecimentosCursosAlura.Model;

namespace AplicandoConhecimentosCursosAlura.Functions;
class ConsEstoque
{
    public ConsEstoque(List<Produto> _listaProdutos)
    {
        ConsultarEstoque( _listaProdutos);
    }
    public void ConsultarEstoque(List<Produto> _listaProduto)
    {
        Console.Clear();
        Console.WriteLine("Lista de Fornecedores");
        foreach(var produto in _listaProduto)
        {
            Console.WriteLine($"[{produto.Id}] - {produto.Nome} | Fornecedor: {produto.FornecedorProduto.Nome} Qtde: {produto.Quantidade}| VUnit: {produto.ValorUnitario} = Total em estoque: $ {produto.ValorTotal}");
        }
    }

}