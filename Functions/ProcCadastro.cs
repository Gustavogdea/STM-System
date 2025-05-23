using AplicandoConhecimentosCursosAlura.Model;

namespace AplicandoConhecimentosCursosAlura.Functions;

class ProcCadastro : ICadastro
{
    List<Fornecedor> ICadastro._listaFornecedores { get; set; }
    List<Cliente> ICadastro._listaClientes { get; set; }

    public void AdicionarCadastro(string nome, string cidade, string estado, string pais, int opcao)
    {
        if (opcao)
    }

    void ICadastro.AdicionarCadastro()
    {
        throw new NotImplementedException();
    }
}
