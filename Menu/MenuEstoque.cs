namespace AplicandoConhecimentosCursosAlura.Menu;

class MenuEstoque : Menu
{
    public static void FuncoesEstoque()
    {
        Console.Clear();
        Console.WriteLine("=================================");
        Console.WriteLine("===   STM ESTOQUE ENLATADOS   ===");
        Console.WriteLine("===                           ===");
        Console.WriteLine("=== Operações de Estoque:     ===");
        Console.WriteLine("===                           ===");
        Console.WriteLine("=== 1- Visualizar Estoque     ===");
        Console.WriteLine("=== 2- Receber Estoque        ===");
        Console.WriteLine("=== 3- Pesquisar Estoque      ===");
        Console.WriteLine("=== 4- Adicionar Produto Man  ===");
        Console.WriteLine("=== 5- Remover Produto        ===");
        Console.WriteLine("=== 0- Voltar                 ===");
        Console.WriteLine("===                           ===");
        Console.WriteLine("=================================");
        Console.WriteLine("\n\n");
        Console.Write("Digite a opção desejada: ");
        int opcao = int.Parse(Console.ReadLine()!);
    }
}
