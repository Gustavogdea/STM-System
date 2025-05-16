using System.Runtime.CompilerServices;

namespace AplicandoConhecimentosCursosAlura.Menu;

class Menu
{
    //private static List<Funcoes> _listaFuncoes = new List<Funcoes>()
    //{
    //    new Funcoes { Descricao = "Cadastros" },
    //    new Funcoes { Descricao = "Exibir Cadastros"},
    //    new Funcoes { Descricao = "Acesso Estoque"},
    //    new Funcoes { Descricao = "Pedidos de Venda"}
    //};
    private readonly Dictionary<int, Opcoes> _opcoes;
    private readonly string _titulo;
	public static string? tituloPrograma = "===   STM ESTOQUE ENLATADOS   ===";
    public static string? barraPrograma = "=================================";
    public static string? barraSimples = "===                           ===";
    //public static string? mensagemRetorno = "Aperte qualquer tecla para retornar ao menu...";
    //public static string? mensagemRedirect = "Redirecionando ao menu escolhido...";
    //public static string? retornarMenu = "Para retornar ao menu anterior tecle [ 0 ] ...";
    public Menu(Dictionary<int,Opcoes> Opcoes, string Titulo)
    {
        _opcoes = Opcoes;
		_titulo = Titulo;
	}


	public void MontarCabecalho()
    {
		Console.Clear();
		Console.WriteLine($"===   {_titulo}   ===");
        Console.WriteLine(tituloPrograma);
    }
    public void MontarRodape()
    {
        Console.WriteLine(barraSimples);
        Console.WriteLine(barraPrograma);
    }
    public void ShowMenu()
    {   
        MontarCabecalho();
        foreach (var opcao in _opcoes)
		{
			Console.WriteLine($"=== {opcao.Key} - {opcao.Value.Descricao}");
		}
        MontarRodape();
	}
    public object ExecuteMenu(int index)
    {
        return _opcoes[index].Acao();
	}
    //public static void ExibirMenu()
    //{
    //    Console.Clear();
    //    MontarCabecalho();
    //    int contador = 1;
    //    foreach (var funcoes in _listaFuncoes)
    //    {
    //        Console.WriteLine($"=== {contador} - {funcoes.Descricao}");
    //        contador++;
    //    }
    //    MontarRodape();
    //    Console.WriteLine("Aperte [ 0 ] para encerrar o programa");
    //    Console.WriteLine("\n");
    //    Console.Write("Digite a opção desejada: ");
    //    int opcao = int.Parse(Console.ReadLine()!);
    //    switch (opcao)
    //    {
    //        case 1:
    //            Console.WriteLine(mensagemRedirect);
    //            Thread.Sleep(3000);
    //            MenuCadastro.CadastrarPerfil();
    //            break;
    //        case 2:
    //            Console.WriteLine(mensagemRedirect);
    //            Thread.Sleep(3000);
    //            MenuCadastro.FuncoesVisualizarEModificar();
    //            break;
    //        case 3:
    //            Console.WriteLine(mensagemRedirect);
    //            Thread.Sleep(3000);
    //            MenuEstoque.FuncoesEstoque();
    //            break;
    //        case 4:
    //            Console.WriteLine(mensagemRedirect);
    //            Thread.Sleep(3000);
    //            MenuVendas.FuncoesPedidoDeVenda();
    //            break;
    //        case 5: 
    //            break;
    //        default:
    //            Console.WriteLine("Opção Inválida");
    //            Console.WriteLine(mensagemRetorno);
    //            Console.ReadKey();
    //            ExibirMenu();
    //            break;
                   
    //    }
    //}
}
