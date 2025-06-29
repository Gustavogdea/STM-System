using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicandoConhecimentosCursosAlura.Model;

class Fornecedor
{
    public Fornecedor(string? nome)
    {
        Nome = nome;
    }

    public int CodigoFornecedor { get; set; }
    public string? Nome { get; }
    public string? Cidade { get; set; }
    public string? Estado { get; set; }
    public string? Pais { get; set; }

}
