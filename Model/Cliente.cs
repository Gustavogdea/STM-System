using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicandoConhecimentosCursosAlura.Model;

class Cliente 
{
    public Cliente(string nome)
    {
        Nome = nome;
    }

    public int CodigoCliente { get; set; }
    public string? Nome { get; set; }
    public string? Cidade { get; set; }
    public string? Estado { get; set; }
    public string? Pais { get; set; }



}
