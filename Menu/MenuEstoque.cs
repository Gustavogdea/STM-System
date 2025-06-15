using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using AplicandoConhecimentosCursosAlura.Model;

namespace AplicandoConhecimentosCursosAlura.Menu;

class MenuEstoque : Menu
{
    public MenuEstoque(Dictionary<int, Opcoes> Opcoes, string Titulo) : base(Opcoes, Titulo)
    {
        _titulo = Titulo;
        _opcoes = Opcoes;
    }
    private readonly Dictionary<int, Opcoes> _opcoes;
    private readonly string _titulo;

    public override void ShowMenu()
    {
        base.ShowMenu();
        Console.Write("Escolha: ");
        int opcao = int.Parse(Console.ReadLine()!);
        ExecuteMenu(opcao); 
    }

    internal static void AdicionarItemEstoque(List<Produto> listaProduto, List<Fornecedor> listaFornecedor)
    {
        throw new NotImplementedException();
    }

    internal static void AtualizarItem(List<Produto> listaProduto, List<Fornecedor> listaFornecedor)
    {
        throw new NotImplementedException();
    }

    internal static void ExportarEstoque(List<Produto> listaProduto, List<Fornecedor> listaFornecedor)
    {
        throw new NotImplementedException();
    }

    internal static void ImportarEstoque(List<Produto> listaProduto, List<Fornecedor> listaFornecedor)
    {
        throw new NotImplementedException();
    }

    internal static void RemoverItemEstoque(List<Produto> listaProduto, List<Fornecedor> listaFornecedor)
    {
        //Remove item escolhido em consulta por produto, fornecedor, data de entrada, ou id
        throw new NotImplementedException();
    }

    internal static void VisualizarEstoque(List<Produto> listaProduto, List<Fornecedor> listaFornecedor)
    {
        //Execute uma pesquisa por produto, por fornecedor, data de entrada ou id
        throw new NotImplementedException();
    }
}
