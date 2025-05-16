using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicandoConhecimentosCursosAlura.Model;

class Fornecedor : Cadastro
{
    public Fornecedor(int codigoFornecedor, string? nome)
    {
        CodigoFornecedor = codigoFornecedor;
        Nome = nome;
    }

    public int CodigoFornecedor { get; set; }
    public string? Nome { get; set; }
    public string? Cidade { get; set; }
    public string? Estado { get; set; }
    public string? Pais { get; set; }

    public override void AdicionarCadastro()
    {
        _listaFornecedores.Add(this);
        Console.WriteLine("Cadastro de Fornecedor Realizado com sucesso!...");
    }
    public void Listar()
    {
        foreach (var fornecedor in _listaFornecedores)
        {
            Console.WriteLine($"Código: {fornecedor.CodigoFornecedor}, Nome: {fornecedor.Nome}, Cidade: {fornecedor.Cidade}, Estado: {fornecedor.Estado}, País: {fornecedor.Pais}");
        }
    }
}
