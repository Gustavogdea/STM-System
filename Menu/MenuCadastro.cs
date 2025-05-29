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

    public override void ShowMenu()
    {
        base.ShowMenu();
        Console.Write("Escolha: ");
        int opcao = int.Parse(Console.ReadLine()!);
        ExecuteMenu(opcao);
    }
    public static void ConsultaCadastro(List<Fornecedor> _listaFornecedor, List<Cliente> _listaCliente)
    {
        Console.Clear();
        Console.Write("Qual o tipo de cadastros que deseja visualizar? [0] Fornecedor [1] Clientes:  ");
        int opcaoListCad = int.Parse(Console.ReadLine()!);
        ConsCadastro consultaCadastro = new ConsCadastro(opcaoListCad, _listaCliente, _listaFornecedor);
    }
    internal static void PesquisarNomeFornecedor(List<Fornecedor> listaFornecedor)
    {
        Console.Clear();
        Console.Write("Digite o nome do Fornecedor: ");
        string buscaNome = Console.ReadLine()!;
        var fornecedoresFiltrados = listaFornecedor.ToList().Where(lf => lf.Nome.Contains(buscaNome));
        Console.WriteLine("=== FORNECEDORES: \n\n");

        if (fornecedoresFiltrados != null)
        {
            foreach (var listaComFiltro in fornecedoresFiltrados)
            {
                Console.WriteLine($"[{listaComFiltro.CodigoFornecedor}] - {listaComFiltro.Nome}");
            }
        }
        else
        {
            Console.WriteLine("Fornecedor não encontrado...");
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
        else
        {
            Console.WriteLine("Fornecedor não encontrado...");
        }

    }
    internal static void PesquisarNomeCliente(List<Cliente> listaCliente)
    {
        Console.Clear();
        Console.Write("Digite o nome do Cliente: ");
        string buscaNome = Console.ReadLine()!;
        var clientesFiltrados = listaCliente.ToList().Where(lc => lc.Nome.Equals(buscaNome));
        Console.WriteLine("=== CLIENTES: \n\n");
        if (clientesFiltrados != null)
        {
            foreach (var listaComFiltro in clientesFiltrados)
            {
                Console.WriteLine($"[{listaComFiltro.CodigoCliente}] - {listaComFiltro.Nome}");
            }
        }
        else
        {
            Console.WriteLine("Cliente não encontrado...");
        }
    }
    internal static void DeletarCliente(List<Cliente> listaCliente)
    {
        Console.Clear();
        Console.Write("Digite o nome do Cliente a ser deletado: ");
        string buscaNome = Console.ReadLine()!;
        var buscaNomeDel = listaCliente.FirstOrDefault(lc => lc.Nome.Equals(buscaNome));
        if (buscaNomeDel != null)
        {
            listaCliente.Remove(buscaNomeDel);
        }
        else
        {
            Console.WriteLine("Cliente não encontrado...");
        }
    }

    internal static void LimparListaFornecedor(List<Fornecedor> listaFornecedor)
    {
        Console.WriteLine("Tem certeza que deseja limpar a lista de fornecedores? [Y] SIM ou [N] Não: ");
        string escolhaLimpar = Console.ReadLine()!;
        string escolhaLimparUpper = escolhaLimpar.ToUpper();
        if (escolhaLimparUpper == "Y")
        {
            listaFornecedor.Clear();
        }
        else if (escolhaLimparUpper == "N")
        {
            Console.WriteLine("Retornando...");
            Thread.Sleep(3000);
        }
    }

    internal static void LimparListaCliente(List<Cliente> listaCliente)
    {
        Console.WriteLine("Tem certeza que deseja limpar a lista de clientes? [Y] SIM ou [N] Não: ");
        string escolhaLimpar = Console.ReadLine()!;
        string escolhaLimparUpper = escolhaLimpar.ToUpper();
        if (escolhaLimparUpper == "Y")
        {
            listaCliente.Clear();
        }
        else if (escolhaLimparUpper == "N")
        {
            Console.WriteLine("Retornando...");
            Thread.Sleep(3000);
        }
    }
}
