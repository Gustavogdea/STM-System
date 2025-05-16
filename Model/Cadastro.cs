namespace AplicandoConhecimentosCursosAlura.Model;

abstract class Cadastro
{
    public abstract void AdicionarCadastro();

    protected List<Fornecedor> _listaFornecedores { get; set; } = new List<Fornecedor>();
    protected List<Cliente> _listaClientes { get; set; } = new List<Cliente>();
}
