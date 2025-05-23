using AplicandoConhecimentosCursosAlura.Model;

namespace AplicandoConhecimentosCursosAlura.Functions;

class ProcCadastro : Cadastro
{
    public ProcCadastro(string nome, string cidade, string estado, string pais, int opcao)
    {
        AdicionarCadastro(nome, cidade, estado, pais, opcao);
    }

    public override void AdicionarCadastro(string nome, string cidade, string estado, string pais, int opcao)
    {
        if (opcao == 1)
        {
            int ultimoCodigo = _listaClientes.Any() ? _listaClientes.OrderByDescending(lc => lc.CodigoCliente).First().CodigoCliente + 1 : 1;
            _listaClientes.Add(new Cliente(nome) { CodigoCliente = ultimoCodigo, Cidade = cidade, Estado = estado, Pais = pais });
            Console.Clear();
            System.Console.WriteLine($"Cliente {nome} Cadastrado com sucesso! ");
        }
        else if (opcao == 0)
        {
            int ultimoCodigo = _listaFornecedores.Any() ? _listaFornecedores.OrderByDescending(lc => lc.CodigoFornecedor).First().CodigoFornecedor + 1 : 1;
            _listaFornecedores.Add(new Fornecedor(nome) { CodigoFornecedor = ultimoCodigo, Cidade = cidade, Estado = estado, Pais = pais });
            Console.Clear();
            System.Console.WriteLine($"Fornecedor {nome} Cadastrado com sucesso! ");
        }
    }
}
