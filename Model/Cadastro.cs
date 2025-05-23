namespace AplicandoConhecimentosCursosAlura.Model;

interface ICadastro
{
    public abstract void AdicionarCadastro(string nome, string cidade, string estado, string pais, int opcao);
    void AdicionarCadastro(string nome, string cidade, string estado, string pais, int opcao);

    protected List<Fornecedor> _listaFornecedores { get; set; }
    protected List<Cliente> _listaClientes { get; set; }
}
