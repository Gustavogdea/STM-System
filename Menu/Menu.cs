using System.Runtime.CompilerServices;

namespace AplicandoConhecimentosCursosAlura.Menu;

class Menu
{
    private static List<Funcoes> _listaFuncoes = new List<Funcoes>()
    {
        new Funcoes { Descricao = "Cadastros" },
        new Funcoes { Descricao = "Exibir Cadastros"},
        new Funcoes { Descricao = "Acesso Estoque"},
        new Funcoes { Descricao = "Pedidos de Venda"}
    };

    public static string? tituloPrograma = "===   STM ESTOQUE ENLATADOS   ===";
    public static string? barraPrograma = "=================================";
    public static string? barraSimples = "===                           ===";
    public static string? mensagemRetorno = "Aperte qualquer tecla para retornar ao menu...";
    public static string? mensagemRedirect = "Redirecionando ao menu escolhido...";
    public static string? retornarMenu = "Para retornar ao menu anterior tecle [ 0 ] ...";
    
    public static void MontarCabecalho()
    {
        Console.WriteLine(barraPrograma);
        Console.WriteLine(tituloPrograma);
    }
    public static void MontarRodape()
    {
        Console.WriteLine(barraSimples);
        Console.WriteLine(barraPrograma);
    }
    public static void ExibirMenu()
    {
        Console.Clear();
        MontarCabecalho();
        int contador = 1;
        foreach (var funcoes in _listaFuncoes)
        {
            Console.WriteLine($"=== {contador} - {funcoes.Descricao}");
            contador++;
        }
        MontarRodape();
        Console.WriteLine("Aperte [ 0 ] para encerrar o programa");
        Console.WriteLine("\n");
        Console.Write("Digite a opção desejada: ");
        int opcao = int.Parse(Console.ReadLine()!);
        switch (opcao)
        {
            case 1:
                Console.WriteLine(mensagemRedirect);
                Thread.Sleep(3000);
                MenuCadastro.CadastrarPerfil();
                break;
            case 2:
                Console.WriteLine(mensagemRedirect);
                Thread.Sleep(3000);
                MenuCadastro.FuncoesVisualizarEModificar();
                break;
            case 3:
                Console.WriteLine(mensagemRedirect);
                Thread.Sleep(3000);
                MenuEstoque.FuncoesEstoque();
                break;
            case 4:
                Console.WriteLine(mensagemRedirect);
                Thread.Sleep(3000);
                MenuVendas.FuncoesPedidoDeVenda();
                break;
            case 5: 
                break;
            default:
                Console.WriteLine("Opção Inválida");
                Console.WriteLine(mensagemRetorno);
                Console.ReadKey();
                ExibirMenu();
                break;
                   
        }
    }
}
