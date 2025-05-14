namespace AplicandoConhecimentosCursosAlura.Menu;

class MenuCadastro : Menu
{
    public static void FuncoesCadastrar() 
    {
        Console.Clear();
        Console.WriteLine("=================================");
        Console.WriteLine("===   STM ESTOQUE ENLATADOS   ===");
        Console.WriteLine("=== Opções Cadastro:          ===");
        Console.WriteLine("===                           ===");
        Console.WriteLine("=== 1 - Cadastrar Fornecedor  ===");
        Console.WriteLine("=== 2 - Cadastrar Cliente     ===");
        Console.WriteLine("=== 0 - Voltar                ===");
        Console.WriteLine("===                           ===");
        Console.WriteLine("=================================");
        Console.WriteLine("\n\n");
        Console.Write("Digite a opção desejada: ");
        int opcao = int.Parse(Console.ReadLine()!);
        
    }

    public static void FuncoesVisualizarEModificar()
    {
        Console.Clear();
        Console.WriteLine("=================================");
        Console.WriteLine("===   STM ESTOQUE ENLATADOS   ===");
        Console.WriteLine("===                           ===");
        Console.WriteLine("=== Opções Editar/Visualizar: ===");
        Console.WriteLine("===                           ===");
        Console.WriteLine("=== 3 - Listar Clientes       ===");
        Console.WriteLine("=== 4 - Pesquisar Cliente     ===");
        Console.WriteLine("=== 5 - Ordenar Lista Clientes===");
        Console.WriteLine("=== 6 - Deletar Cliente       ===");
        Console.WriteLine("=== 7 - Limpar Lista Clien.(!)===");
        Console.WriteLine("===                           ===");
        Console.WriteLine("===                           ===");
        Console.WriteLine("=== 8 - Listar Fornecedores   ===");
        Console.WriteLine("=== 9 - Pesquisar Fornecedor  ===");
        Console.WriteLine("=== 10 - Ordenar Lista Fornec.===");
        Console.WriteLine("=== 11 - Deletar Fornecedor   ===");
        Console.WriteLine("=== 12 - Limpar lista Forn.(!)===");
        Console.WriteLine("===                           ===");
        Console.WriteLine("=== 0 - Voltar                ===");
        Console.WriteLine("===                           ===");
        Console.WriteLine("=================================");
        Console.WriteLine("\n\n");
        Console.Write("Digite a opção desejada: ");
        int opcao = int.Parse(Console.ReadLine()!);

    }
}
