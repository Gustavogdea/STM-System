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
    List<Produto> _listaProduto = new List<Produto>();

var dicionarioOpcoesEstoque = new Dictionary<int, Opcoes>()
{
    {1, new Opcoes{ Descricao = "Listar Produtos em estoque", Acao = () =>
            {
                MenuEstoque.VisualizarEstoque(_listaProduto, _listaFornecedor);
                return null;
            }
        }
    },
    {2, new Opcoes{ Descricao = "Adicionar item", Acao = () =>
            {
                MenuEstoque.AdicionarItemEstoque(_listaProduto, _listaFornecedor);
                return null;
            }
        }
    },
    {3, new Opcoes{ Descricao = "Remover item", Acao = () =>
            {
                MenuEstoque.RemoverItemEstoque(_listaProduto, _listaFornecedor);
                return null;
            }
        }
    },
    {4, new Opcoes{ Descricao = "Atualizar item", Acao = () =>
            {
                MenuEstoque.AtualizarItem(_listaProduto, _listaFornecedor);
                return null;
            }
        }
    },
    {5, new Opcoes{ Descricao = "Importar Estoque", Acao = () =>
            {
                MenuEstoque.ImportarEstoque(_listaProduto, _listaFornecedor);
                return null;
            }
        }
    },
    {6, new Opcoes{ Descricao = "Exportar Estoque", Acao = () =>
            {
                MenuEstoque.ExportarEstoque(_listaProduto, _listaFornecedor);
                return null;
            }
        }
    },
    {0, new Opcoes{ Descricao = "Voltar para o menu", Acao = () =>
            {
                return null;
            }
        }
    }
    
};
    
var dicionarioOpcoesCadastro = new Dictionary<int, Opcoes>()
{
    {1, new Opcoes{ Descricao = "Exibir Lista de fornecedores ou Clientes", Acao = () =>
            {
                MenuCadastro.ConsultaCadastro(_listaFornecedor, _listaCliente);
                return null;
            }
        }
    },
    {2, new Opcoes{ Descricao = "Pesquisar por nome Fornecedor", Acao = () =>
            {
                MenuCadastro.PesquisarNomeFornecedor(_listaFornecedor);
                return null;
            }
        }
    },
    {3, new Opcoes{ Descricao = "Deletar Fornecedor", Acao = () =>
            {
                MenuCadastro.DeletarFornecedor(_listaFornecedor);
                return null;
            }
        }
    },
    {4, new Opcoes{ Descricao = "Limpar Lista de Fornecedores (!)", Acao = () =>
            {
                MenuCadastro.LimparListaFornecedor(_listaFornecedor);
                return null;
            }
        }
    },
    {5, new Opcoes{ Descricao = "Pesquisar por nome Cliente", Acao = () =>
            {
                MenuCadastro.PesquisarNomeCliente(_listaCliente);
                return null;
            }
        }
    },
    {6, new Opcoes{ Descricao = "Deletar Cliente", Acao = () =>
            {
                MenuCadastro.DeletarCliente(_listaCliente);
                return null;
            }
        }
    },
    {7, new Opcoes{ Descricao = "Limpar Lista de Clientes (!)", Acao = () =>
            {
                MenuCadastro.LimparListaCliente(_listaCliente);
                return null;
            }
        }
    },
    { 0, new Opcoes{ Descricao = "Voltar para o Menu", Acao = () =>
            {
                return null;
            }
        }
    }
};

    var dicionarioOpcoes = new Dictionary<int, Opcoes>()
{
    { 1, new Opcoes { Descricao = "Cadastrar", Acao = () =>
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
                MenuCadastro menuCadastro = new MenuCadastro(dicionarioOpcoesCadastro, "Visualizar Cadastro");
                menuCadastro.ShowMenu();
                return null;
            }
        }
    },
    {3, new Opcoes{ Descricao = "Estoque", Acao = () =>
            {
                MenuEstoque menuEstoque = new MenuEstoque(dicionarioOpcoesEstoque, "Estoque/Depósito");
                menuEstoque.ShowMenu();
                return null;
            }
        }
    },
    {4, new Opcoes{ Descricao = "Gerenciamento de Pedidos", Acao = () =>
            {
                
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