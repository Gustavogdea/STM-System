using AplicandoConhecimentosCursosAlura.Model;

namespace AplicandoConhecimentosCursosAlura.Functions;

class ProcEstoque
{
    //Criar criação de excessão em caso de problemas no cadastro

    public ProcEstoque(string nomeProduto, string marcaProduto, int quantidade, decimal valorUnit, Fornecedor fornecedorProduto, List<Produto> _listaProduto)
    {
        AdicionarCadastro(nomeProduto, marcaProduto, quantidade, valorUnit, fornecedorProduto, _listaProduto);
    }

    public void AdicionarCadastro(string nomeProduto, string marcaProduto, int quantidade, decimal valorUnit, Fornecedor fornecedor, List<Produto> _listaProduto)
    {
        int ultimoCodigo = _listaProduto.Any() ? _listaProduto.OrderByDescending(lc => lc.Id).First().Id + 1 : 1;
        _listaProduto.Add(new Produto(nomeProduto, marcaProduto, fornecedor) { Id = ultimoCodigo, Quantidade = quantidade, ValorUnitario = valorUnit });
        Console.Clear();
        Console.WriteLine($"Produto {nomeProduto} do Fornecedor {fornecedor.Nome} foi cadastrado com sucesso! ");
    }
}