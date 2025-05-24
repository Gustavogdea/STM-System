using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AplicandoConhecimentosCursosAlura.Menu;

public class Opcoes
{
	public required string Descricao { get; set; }
	public required Func<object> Acao{ get; set; }

}
