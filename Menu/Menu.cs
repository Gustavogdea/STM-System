namespace AplicandoConhecimentosCursosAlura.Menu;

class Menu
{
    public static void ExibirMenu()
    {
        Console.Clear();
        Console.WriteLine("=================================");
        Console.WriteLine("===   STM ESTOQUE ENLATADOS   ===");
        Console.WriteLine("===                           ===");
        Console.WriteLine("=== 1- Opções Cadastro        ===");
        Console.WriteLine("=== 2- Visualizar/Editar Cad. ===");
        Console.WriteLine("=== 3- Acesso Estoque         ===");
        Console.WriteLine("=== 4- Acesso Vendas          ===");
        Console.WriteLine("=== 5- Sair                   ===");
        Console.WriteLine("===                           ===");
        Console.WriteLine("=================================");
        Console.WriteLine("\n\n");
        Console.Write("Digite a opção desejada: ");
        int opcao = int.Parse(Console.ReadLine()!);
        switch (opcao)
        {
            case 1: MenuCadastro.FuncoesCadastrar();
                break;
            case 2: MenuCadastro.FuncoesVisualizarEModificar();
                break;
            case 3: MenuEstoque.FuncoesEstoque();
                break;
            case 4: MenuVendas.FuncoesPedidoDeCompra();
                break;
            case 5: 
                break;
            default:
                Console.WriteLine("Função Inválida");
                break;
        }
    }
}
