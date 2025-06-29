using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using AplicandoConhecimentosCursosAlura.Enum;

namespace AplicandoConhecimentosCursosAlura.Functions;

class ExportEstoque
{
    public static void VerificarDados(List<Produto> _listaProdutos, int formato)
    {
        if(_listaProdutos.Count == 0)
        {
            throw new Exception("Lista de Produtos Vazia!");
        }
        else if(!(formato.Equals(FormatoArquivo.Xml)) || !(formato.Equals(FormatoArquivo.Txt)))
        {
            throw new Exception("Formato de Arquivo desejado não encontrado!");
        }
        else
        {
            if (FormatoArquivo.Xml.Equals(formato)) { ExportarDados(_listaProdutos, FormatoArquivo.Xml); }
            else { ExportarDados(_listaProdutos, FormatoArquivo.Txt); }
        }
    }

    private static void ExportarDados(List<Produto> produtos, FormatoArquivo formato)
    {
        string arquivoNome = "DadosExportados";
        if(formato == FormatoArquivo.Xml)
        {
            var serializar = new XmlSerializer(typeof(Produto));
            try
            {
                FileStream fs = new FileStream($"{arquivoNome}.xml", FileMode.Create);
                using (StreamWriter leitor = new StreamWriter(fs))
                {
                    serializar.Serialize(leitor, produtos);
                }
                Console.WriteLine("Arquivo gerado!");
            }
            catch (Exception ex)
            {
                throw new Exception($"O seguinte erro foi gerado na exportação do xml: {ex.Message}");
            }
        }
        if(formato == FormatoArquivo.Txt)
        {
            try
            {
                using(var fluxoDeArquivo = new FileStream($"{arquivoNome}.txt", FileMode.Create))
                using(var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
                {
                    foreach(var linha in produtos)
                    {
                        escritor.WriteLine($"{linha.Nome},{linha.Marca},{linha.Quantidade},{linha.FornecedorProduto.CodigoFornecedor},{linha.ValorUnitario},{linha.DataEntrada}");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"O seguinte erro foi gerado na exportação do txt: {ex.Message}");
            }
        }
    }

}
