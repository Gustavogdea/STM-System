using AplicandoConhecimentosCursosAlura;
using AplicandoConhecimentosCursosAlura.Functions;
using AplicandoConhecimentosCursosAlura.Model;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AplicandoConhecimentosCursosAlura.Menu;

internal class MenuCadastro : Menu
{
    private readonly Dictionary<int, Opcoes> _opcoes;
    public MenuCadastro(Dictionary<int, Opcoes> Opcoes, string Titulo) : base(Opcoes, Titulo)
    {
        _titulo = Titulo;
        _opcoes = Opcoes;
    }

    private readonly string _titulo;

    public static void Cadastrar(List<Fornecedor> _listaFornecedor, List<Cliente> _listaCliente)
    {
        Console.Write("Digite [0] para cadastrar Fornecedor e [1] para cadastrar Cliente: ");
        int opcao = int.Parse(Console.ReadLine()!);
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine()!;
        Console.Write("Digite a cidade: ");
        string cidade = Console.ReadLine()!;
        Console.Write("Digite o estado: ");
        string estado = Console.ReadLine()!;
        Console.Write("Digite o país: ");
        string pais = Console.ReadLine()!;
        ProcCadastro procCad = new ProcCadastro(nome, cidade, estado, pais, opcao, _listaFornecedor, _listaCliente);
    }
    
    public static void ConsultaCadastro(List<Fornecedor> _listaFornecedor, List<Cliente> _listaCliente)
    {
        Console.Clear();
        Console.Write("Qual o tipo de cadastros que deseja visualizar? [0] Fornecedor [1] Clientes:  ");
        int opcaoListCad = int.Parse(Console.ReadLine()!);
        ConsCadastro consultaCadastro = new ConsCadastro(opcaoListCad, _listaCliente, _listaFornecedor);
    }

    public override void ShowMenu()
    {
        base.ShowMenu();
        Console.Write("Escolha: ");
        int opcao = int.Parse(Console.ReadLine()!);
        ExecuteMenu(opcao);   
    }

    internal static void PesquisarNomeFornecedor(List<Fornecedor> listaFornecedor)
    {
        Console.Clear();
        Console.Write("Digite o nome do Fornecedor: ");
        string buscaNome = Console.ReadLine()!;
        var fornecedoresFiltrados = listaFornecedor.ToList().Where(lf => lf.Nome.Contains(buscaNome));
        Console.WriteLine("=== FORNECEDORES: \n\n");
        foreach (var listaComFiltro in fornecedoresFiltrados)
        {
            Console.WriteLine($"[{listaComFiltro.CodigoFornecedor}] - {listaComFiltro.Nome}");
        }
    }
    internal static void DeletarFornecedor(List<Fornecedor> listaFornecedor)
    {
        Console.Clear();
        Console.Write("Digite o nome do Fornecedor a ser deletado: ");
        string buscaNome = Console.ReadLine()!;
        var buscaNomeDel = listaFornecedor.FirstOrDefault(lf => lf.Nome.Equals(buscaNome));
        if (buscaNomeDel != null)
        {
            listaFornecedor.Remove(buscaNomeDel);
        }
    }
    internal static void PesquisarNomeCliente(List<Cliente> listaCliente)
    {
        throw new NotImplementedException();
    }
    internal static void DeletarCliente(List<Cliente> listaCliente)
    {
        throw new NotImplementedException();
    }
}
