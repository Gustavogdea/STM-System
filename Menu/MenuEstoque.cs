using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using AplicandoConhecimentosCursosAlura.Model;
using AplicandoConhecimentosCursosAlura.Functions;

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
        Console.WriteLine("=== Cadastro de Produto Manual no Estoque ===");
        Console.Write("Digite o nome do produto: ");
        string? nomeProduto = Console.ReadLine()!;
        Console.Write("Digite a marca do produto: ");
        string? marcaProduto = Console.ReadLine()!;
        Console.Write("Digite a quantidade do produto: ");
        int quantidadeProduto = int.Parse(Console.ReadLine()!);
        Console.Write("Digite o valor unitário do produto: ");
        decimal valorUnitarioProduto = decimal.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o ID do Fornecedor do Produto: ");
        int idFornecedor = int.Parse(Console.ReadLine()!);
        Fornecedor? fornecedorProduto = listaFornecedor.FirstOrDefault(f => f.CodigoFornecedor == idFornecedor);
        if (fornecedorProduto == null)
        {
            Console.WriteLine("Fornecedor não encontrado. Por favor, verifique o ID.");
            return;
        }
        ProcEstoque procCadEstoque = new ProcEstoque(
            nomeProduto, marcaProduto, quantidadeProduto, valorUnitarioProduto, fornecedorProduto, listaProduto
        );
    }

    internal static void AtualizarItem(List<Produto> listaProduto, List<Fornecedor> listaFornecedor)
    {
        throw new NotImplementedException();
    }

    internal static void ExportarEstoque(List<Produto> listaProduto, List<Fornecedor> listaFornecedor)
    {
        Console.Clear();
        Console.Write("Digite 1 para gerar um arquivo em XML e 2 para gerar um arquivo em TXT: ");
        int formatoArquivo = int.Parse(Console.ReadLine()!);
        ExportEstoque.VerificarDados(listaProduto, formatoArquivo);
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

    internal static void VisualizarEstoque(List<Produto> listaProduto)
    {
        //Execute uma pesquisa por produto, por fornecedor, data de entrada ou id
        ConsEstoque consultaEstoque = new ConsEstoque(listaProduto);
    }
}
