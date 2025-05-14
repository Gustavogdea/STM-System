//Aplicação de gestão de estoque e envio de mercadoria
//Criar um estoque
//Receber mercadoria de fornecedor
//Cadastrar clientes e fornecedores
//Fazer movimentação de estoque
//Criar uma ordem de envio de pedido
//Gerar um JSON

using AplicandoConhecimentosCursosAlura.Menu;
using AplicandoConhecimentosCursosAlura.Model;

Cliente cliente = new Cliente(1, "João")
{ 
    Cidade = "São Paulo",
    Estado = "SP",
    Pais = "Brasil"
};
Fornecedor fornecedor = new Fornecedor(1, "Fornecedor A")
{
    Cidade = "Rio de Janeiro",
    Estado = "RJ",
    Pais = "Brasil"
};
fornecedor.Cadastrar();
fornecedor.Listar();
cliente.Cadastrar();
cliente.Listar();

Menu.ExibirMenu();