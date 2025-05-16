namespace AplicandoConhecimentosCursosAlura.Functions;
using AplicandoConhecimentosCursosAlura.Menu;

class Cadastrar : Menu
{
    public static void OperacaoCadastroCliente()
    {
        Console.Write("Digite o Nome do Cliente: ");
        string nome = Console.ReadLine()!;
    }

    public static void OperacaoCadastroFornecedor()
    {
        throw new NotImplementedException();
    }
}
