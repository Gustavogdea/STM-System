//Aplicação de gestão de estoque e envio de mercadoria
//Criar um estoque
//Receber mercadoria de fornecedor
//Cadastrar clientes e fornecedores
//Fazer movimentação de estoque
//Criar uma ordem de envio de pedido
//Gerar um JSON
using AplicandoConhecimentosCursosAlura.Menu;
using AplicandoConhecimentosCursosAlura.Model;
{ 
List<Cliente> _listaCliente = new List<Cliente>();
List<Fornecedor> _listaFornecedor = new List<Fornecedor>();
    var dicionarioOpcoes = new Dictionary<int, Opcoes>()
{
    { 1, new Opcoes { Descricao = "Cadastrar Produto", Acao = () =>
            {
				//não use menus estaticos nesse formato
				//MenuCadastro.CadastrarPerfil();
				//return MenuCadastro;
				MenuCadastro.Cadastrar(_listaFornecedor, _listaCliente);
                return null;
            }
        }
    },
    {2, new Opcoes{ Descricao = "Editar/Modificar Cadastro", Acao = () =>
            {
                MenuCadastro.ConsultaCadastro(_listaFornecedor, _listaCliente);
                return null;
            }
        }
    },
    {3, new Opcoes{ Descricao = "Estoque", Acao = () =>
            {
                MenuEstoque.AcessoEstoque();
                return null;
            }
        }
    },
    {4, new Opcoes{ Descricao = "Gerenciamento de Pedidos", Acao = () =>
            {
                MenuCadastro.EditarCadastro();
                return null;
            }
        }
    },
    {0, new Opcoes{ Descricao = "Sair", Acao = () =>
            {

                return null;

            }
        }
    },
};

    var dicionarioOpcoesPerfil = new Dictionary<int, Opcoes>()
{
    {1, new Opcoes{ Descricao = "Exibir Lista de fornecedores", Acao = () =>
            {
                
                return null;
            }
        }
    }
};

    int verificador = 1;
    while (verificador != 0)
    {
        Menu men = new Menu(dicionarioOpcoes, "Menu Principal");
        men.ShowMenu();
        Console.Write("Escolha: ");
        int opcaoValue;

        if (int.TryParse(Console.ReadLine()!, out opcaoValue))
        {
            if (opcaoValue == 0)
            {
                verificador = 0;
            }
            men.ExecuteMenu(opcaoValue);
        }
        else
        {
            System.Console.WriteLine("Entrada inválida. Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        if (opcaoValue != 0)
        {
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Saindo da Aplicação...");
        }
    }
}