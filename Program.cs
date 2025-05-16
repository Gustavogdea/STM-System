//Aplicação de gestão de estoque e envio de mercadoria
//Criar um estoque
//Receber mercadoria de fornecedor
//Cadastrar clientes e fornecedores
//Fazer movimentação de estoque
//Criar uma ordem de envio de pedido
//Gerar um JSON

using AplicandoConhecimentosCursosAlura.Menu;
using AplicandoConhecimentosCursosAlura.Model;
var dicionrioOpcoes = new Dictionary<int, Opcoes>()
{
	{ 1, new Opcoes { Descricao = "Cadastrar Produto", Acao = () => {
				//não use menus estaticos nesse formato
				//MenuCadastro.CadastrarPerfil();
				//return MenuCadastro;
				return null;
			} 
		} 
	},
};
Menu men = new Menu(dicionrioOpcoes,"Menu Principal");
men.ShowMenu();