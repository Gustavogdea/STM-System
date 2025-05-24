using AplicandoConhecimentosCursosAlura.Model;

namespace AplicandoConhecimentosCursosAlura.Functions;

class ConsCadastro
{

    public ConsCadastro(int opcaoListCad, List<Cliente> _listaCliente, List<Fornecedor> _listaFornecedores)
   {    
        Listar(opcaoListCad, _listaCliente, _listaFornecedores);
   }

    public void Listar(int opcao, List<Cliente> _listaCliente, List<Fornecedor> _listaFornecedores)
    {
        Console.Clear();
        Console.WriteLine("Lista de Fornecedores");
        if (opcao == 0) { foreach(var lista in _listaFornecedores) { Console.WriteLine($"[{lista.CodigoFornecedor}] - {lista.Nome}"); } }
        else { foreach(var lista in _listaCliente) { Console.WriteLine($"[{lista.CodigoCliente}] - {lista.Nome}"); } }
    }

}
