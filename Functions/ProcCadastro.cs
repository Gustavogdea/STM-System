using AplicandoConhecimentosCursosAlura.Model;

namespace AplicandoConhecimentosCursosAlura.Functions;

class ProcCadastro
{
    public ProcCadastro(string nome, string cidade, string estado, string pais, int opcao ,List<Fornecedor> _listaFornecedor, List<Cliente> _listaCliente)
    {
        AdicionarCadastro(nome, cidade, estado, pais, opcao, _listaFornecedor, _listaCliente);
    }

    public void AdicionarCadastro(string nome, string cidade, string estado, string pais, int opcao, List<Fornecedor> _listaFornecedor, List<Cliente> _listaCliente)
    {
        if (opcao == 1)
        {
            int ultimoCodigo = _listaCliente.Any() ? _listaCliente.OrderByDescending(lc => lc.CodigoCliente).First().CodigoCliente + 1 : 1;
            _listaCliente.Add(new Cliente(nome) { CodigoCliente = ultimoCodigo, Cidade = cidade, Estado = estado, Pais = pais });
            Console.Clear();
            System.Console.WriteLine($"Cliente {nome} Cadastrado com sucesso! ");
        }
        else if (opcao == 0)
        {
            int ultimoCodigo = _listaFornecedor.Any() ? _listaFornecedor.OrderByDescending(lc => lc.CodigoFornecedor).First().CodigoFornecedor + 1 : 1;
            _listaFornecedor.Add(new Fornecedor(nome) { CodigoFornecedor = ultimoCodigo, Cidade = cidade, Estado = estado, Pais = pais });
            Console.Clear();
            System.Console.WriteLine($"Fornecedor {nome} Cadastrado com sucesso! ");
        }
    }
}
