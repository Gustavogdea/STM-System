using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicandoConhecimentosCursosAlura.Model;

class Cliente : Cadastro
{
    public Cliente(int codigoCliente, string? nome)
    {
        CodigoCliente = codigoCliente;
        Nome = nome;
    }

    public int CodigoCliente { get; set; }
    public string? Nome { get; set; }
    public string? Cidade { get; set; }
    public string? Estado { get; set; }
    public string? Pais { get; set; }

    public override void AdicionarCadastro()
    {
        _listaClientes.Add(this);
        Console.WriteLine("Cadastro de Cliente Realizado com sucesso!...");
    }

    public void Listar()
    {
        foreach (var cliente in _listaClientes)
        {
            Console.WriteLine($"Código: {cliente.CodigoCliente}, Nome: {cliente.Nome}, Cidade: {cliente.Cidade}, Estado: {cliente.Estado}, País: {cliente.Pais}");
        }
    }
}
