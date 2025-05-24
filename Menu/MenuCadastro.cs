using AplicandoConhecimentosCursosAlura;
using AplicandoConhecimentosCursosAlura.Functions;
using AplicandoConhecimentosCursosAlura.Model;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AplicandoConhecimentosCursosAlura.Menu;

internal class MenuCadastro : Menu
{
    public MenuCadastro(Dictionary<int, Opcoes> Opcoes, string Titulo) : base(Opcoes, Titulo)
    {
        _titulo = Titulo;
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

    public static void EditarCadastro()
    {
                
    }

    //private static List<Funcoes> _listaFuncoesCadastro = new List<Funcoes>()
    //{
    //    new Funcoes { Descricao = "Cadastrar Fornecedor"},
    //    new Funcoes { Descricao = "Cadastrar Cliente"},
    //};
    //private static List<Funcoes> _listaFuncoesVisualizarEModificar = new List<Funcoes>()
    //{
    //    new Funcoes {Descricao = "Listar Clientes"},
    //    new Funcoes {Descricao = "Pesquisar Cliente"},
    //    new Funcoes {Descricao = "Ordenar Lista Clientes"},
    //    new Funcoes {Descricao = "Deletar Cliente"},
    //    new Funcoes {Descricao = "Limpar Lista Clien.(!)"},
    //    new Funcoes {Descricao = "Listar Fornecedores"},
    //    new Funcoes {Descricao = "Pesquisar Fornecedor"},
    //    new Funcoes {Descricao = "Ordenar Lista Fornec."},
    //    new Funcoes {Descricao = "Deletar Fornecedor"},
    //    new Funcoes {Descricao = "Limpar lista Forn.(!)"},
    //};
    //public void CadastrarPerfil() 
    //{
    //    Console.Clear();
    //    MontarCabecalho();
    //    int contador = 1;
    //    foreach (var funcao in _listaFuncoesCadastro)
    //    {
    //        Console.WriteLine($"=== {contador} - {funcao.Descricao}");
    //        contador++;
    //    }
    //    MontarRodape();
    //    Console.WriteLine(retornarMenu);
    //    Console.WriteLine("\n");
    //    Console.Write("Digite a opção desejada: ");
    //    int opcao = int.Parse(Console.ReadLine()!);
    //    switch (opcao)
    //    {
    //        case 1: 
    //            Cadastrar.OperacaoCadastroFornecedor();
    //            break;
    //        case 2:
    //            Cadastrar.OperacaoCadastroCliente();
    //            break;
    //        default:
    //            Console.WriteLine("Opção Inválida!...");
    //            break;  
    //    }


    //}

    //public void FuncoesVisualizarEModificar()
    //{
    //    Console.Clear();
    //    MontarCabecalho();
    //    int contador = 1;
    //    foreach (var funcao in _listaFuncoesVisualizarEModificar)
    //    {
    //        Console.WriteLine($"=== {contador} - {funcao.Descricao}");
    //        contador++;
    //    }
    //    MontarRodape();
    //    Console.WriteLine(retornarMenu);
    //    Console.WriteLine("\n");
    //    Console.Write("Digite a opção desejada: ");
    //    int opcao = int.Parse(Console.ReadLine()!);

    //}
}
