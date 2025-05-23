using AplicandoConhecimentosCursosAlura;
using System.Runtime.CompilerServices;

namespace AplicandoConhecimentosCursosAlura.Menu;

internal class MenuCadastro : Menu
{
    public MenuCadastro(Dictionary<int, Opcoes> Opcoes, string Titulo) : base(Opcoes, Titulo)
    {
    }

    public static void Cadastrar() 
    {
        Console.Clear();
        Console.WriteLine("Você chegou!");
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
