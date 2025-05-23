namespace AplicandoConhecimentosCursosAlura.Model;

abstract class Cadastro
{
    public abstract void AdicionarCadastro(string nome, string cidade, string estado, string pais, int opcao);

    public List<Fornecedor> _listaFornecedores = new List<Fornecedor>();
    public List<Cliente> _listaClientes = new List<Cliente>();
}
