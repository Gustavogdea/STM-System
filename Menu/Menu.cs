using System.Runtime.CompilerServices;

namespace AplicandoConhecimentosCursosAlura.Menu;

class Menu
{
    #region Construtores_Listas
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
    #endregion
    public void MontarCabecalho()
    {
		Console.Clear();
		Console.WriteLine($"===   {_titulo}   ===");
    }
    public static void MontarRodape()
    {
        Console.WriteLine(barraSimples);
        Console.WriteLine(barraPrograma);
    }
    public virtual void ShowMenu()
    {
        Console.Clear();
        MontarCabecalho();
        foreach (var opcao in _opcoes)
		{
			Console.WriteLine($"=== {opcao.Key} - {opcao.Value.Descricao}");
		}
        MontarRodape();
	}
    public virtual object ExecuteMenu(int index)
    {
        return _opcoes[index].Acao();
	}

}
