using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using Newtonsoft.Json.Schema;
using SysAux.Interfaces;
using SysAux.ObjetosDestinatario;
using SysAux.Response;
using SysGestao_BE.Auxx;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SysAux.Util
{
    public class XlsxFactory
    {

        #region Metodos Privados

        private static void InserirProdutoNaLista(List<ProdutoResponse> lista, List<ProdutoResponse> listaInsert)
        {
            if (lista == null)
                lista = new List<ProdutoResponse>();

            if (listaInsert == null || !listaInsert.Any())
                return;
            else
                lista.AddRange(listaInsert);

        }


        private static string GetDataSolicitacao(IXLWorksheet planilha, string col, int indice)
        {
            if (planilha.Cell($"{col}{indice}").Value.ToString().Contains("Data emissão"))
                return planilha.Cell($"{col}{indice}").Value?.ToString().Split('\n')[1].Trim();

            return "";
        }

        private static string GetEndereco(IXLWorksheet planilha, string col, int indice)
        {

            if (planilha.Cell($"{col}{indice}").Value.ToString().Contains("Endereço"))
                return planilha.Cell($"{col}{indice}").Value?.ToString().Split('\n')[1].Trim();

            return "";

        }
        private static string GetNomeCliente(IXLWorksheet planilha, string col, int indice)
        {
            if (planilha.Cell($"{col}{indice}").Value.ToString().Contains("Nome / Razão Social"))
                return planilha.Cell($"{col}{indice}").Value.ToString().Split('\n')[1];

            return "";
        }

        private static string GetCpfCnpj(IXLWorksheet planilha, string col, int indice)
        {
            if (planilha.Cell($"{col}{indice}").Value.ToString().Contains("CNPJ/CPF"))
            {
                string[] cpfArray = planilha.Cell($"{col}{(indice)}")?.Value?.ToString()?.Split('\n');

                if (cpfArray.Length >= 1 && cpfArray[1].SomenteNumeros().Length > 0)
                    return cpfArray.Length > 0 ? cpfArray[1].SomenteNumeros() : "";
            }

            return "";
        }


        private static List<ProdutoResponse> GetProdutos(IXLWorksheet planilha, int indice)
        {
            string codSku = "", variacao = "", descricao = "";
            int quant = 0;
            var xlsxAnalytic = XlsxDocumentConfigurationColumns.ObterConfiguracao(Enums.TipoDocumento.DANFE);
            xlsxAnalytic.LimparColunas();
            var result = new List<ProdutoResponse>();
            bool isEnd = false, incrementarLinha = false;
            var colunas = planilha.ColumnsUsed().ToList().Select(x => x.ColumnUsed());

            for (int i = indice; i < planilha.RowsUsed().Count() + 100; i++)
            {
                if (isEnd)
                    break;

                if (!xlsxAnalytic.IsProdutoConfigurado())
                {
                    foreach (var col in colunas)
                    {
                        if (xlsxAnalytic.IsProdutoConfigurado())
                        {

                            if ((i + 1) < (planilha.RowsUsed().Count() + 100) && incrementarLinha)
                            {
                                incrementarLinha = false;
                                break;
                            }
                        }
                        else
                        {

                            if (planilha.Cell($"{col.RangeAddress.FirstAddress.ColumnLetter}{indice}").Value.ToString().Contains("Código"))
                                xlsxAnalytic.CodigoSKU = col.RangeAddress.FirstAddress.ColumnLetter;

                            else if (planilha.Cell($"{col.RangeAddress.FirstAddress.ColumnLetter}{indice}").Value.ToString().Contains("Descrição do produto/serviço"))
                                xlsxAnalytic.Variacao = col.RangeAddress.FirstAddress.ColumnLetter;

                            else if (planilha.Cell($"{col.RangeAddress.FirstAddress.ColumnLetter}{indice}").Value.ToString().Contains("Qtde"))
                                xlsxAnalytic.Quantidade = col.RangeAddress.FirstAddress.ColumnLetter;

                            incrementarLinha = xlsxAnalytic.IsProdutoConfigurado();
                        }
                    }
                }

                else
                {
                    if (planilha.Cell($"A{i}").Value?.ToString().Trim() == "Cálculo do ISSQN"
                        || planilha.Cell($"A{i}").Value?.ToString().Trim() == string.Empty)
                    {
                        isEnd = true;
                        break;
                    }
                    else
                    {
                        codSku = planilha.Cell($"{xlsxAnalytic.CodigoSKU}{i}").Value.ToString();
                        descricao = planilha.Cell($"{xlsxAnalytic.Variacao}{i}").Value.ToString();
                        variacao = TrataDescricaoProduto(descricao, xlsxAnalytic);
                        string qtd = planilha.Cell($"{xlsxAnalytic.Quantidade}{i}").Value.ToString();
                        quant = int.Parse(qtd);

                        var prd = new ProdutoResponse(codSku, variacao, descricao, quant);
                        result.Add(prd);

                    }
                }
            }
            return result;

        }

        private static ProdutoResponse GetProduto(IXLWorksheet planilha, XlsxDocumentConfigurationColumns xlsxConfig, int indice, out int indiceUpdate)
        {
            var xlsxConfiguredSeparator = XlsxDocumentConfigurationColumns.ObterConfiguracao(Enums.TipoDocumento.DANFE);
            string codSku = "", variacao = "";

            codSku = planilha.Cell($"{xlsxConfig.CodigoSKU}{indice}").Value?.ToString().Trim();

            string informacoes = planilha.Cell($"{xlsxConfig.Variacao}{indice}").Value?.ToString().Trim();

            var infos_separators = informacoes.Split(xlsxConfiguredSeparator.Separadores.ToArray());
            infos_separators = infos_separators.Where(x => x != "Tamanho").ToArray();

            string descricao = infos_separators.Length > 0 ? infos_separators[0] : "";

            variacao = infos_separators.Length > 0 ? string.Join(",", infos_separators.Where(x => x != infos_separators?[0]).ToArray())
                : variacao;

            string quantidade_text = planilha.Cell($"{xlsxConfig.Quantidade}{indice}").Value?.ToString().Trim();
            int quant = Convert.ToInt16(quantidade_text.SomenteNumeros() != String.Empty ? quantidade_text : "0");
            indiceUpdate = ++indice;
            return new ProdutoResponse
            {
                CodigoSKU = codSku,
                Variacao = variacao,
                Quantidade = quant,
                Descricao = descricao
            };
        }



        private static Destinatario GetDestinatario(IXLWorksheet planilha, XlsxDocumentConfigurationColumns xlsxConfiguration, int i)
        {
            var name = planilha.Cell($"{xlsxConfiguration.NomeDestinatario}{i}").Value.ToString().Split('\n')[1];
            string cpf = "";
            var cpfArray = planilha.Cell($"{xlsxConfiguration.CpfCnpj}{i}")?.Value?.ToString()?.Split('\n');
            cpf = cpfArray.Length > 0 ? cpfArray[1].SomenteNumeros() : "";

            var end = planilha.Cell($"{xlsxConfiguration.Endereco}{++i}").Value?.ToString().Split('\n')[1].Trim();

            return new Destinatario() { Nome = name, CpfCnpj = long.Parse(cpf), Endereco = end };
        }



        public static string TrataDescricaoProduto(string informacoes, XlsxDocumentConfigurationColumns xlsxConfig)
        {
            var infos_separators = informacoes.Split(xlsxConfig.Separadores.ToArray());
            infos_separators = infos_separators.Where(x => x != "Tamanho").ToArray();

            string variacao = "";
            variacao = infos_separators.Length > 0 ? string.Join(",", infos_separators.Where(x => x != infos_separators?[0]).ToArray())
               : variacao;

            return variacao;
        }
        private static void TrataInformacoesXLSXDanfe(XLWorkbook xlsx, XlsxDocumentConfigurationColumns xlsxConfig, out List<Solicitacao> result)
        {
            result = new List<Solicitacao>();

            if (xlsxConfig != null)
            {
                foreach (var planilha in xlsx.Worksheets)
                {
                    var colunas = planilha.ColumnsUsed().ToList().Select(x => x.ColumnUsed());
                   
                    string name = "", cpf = "", end = "", dataSolicitacao = "";
                    bool isProduto = false, isDestinatario = false;

                    Solicitacao solicitacao = new Solicitacao();
                    XlsxDocumentConfigurationColumns xlsxAnalytic = new XlsxDocumentConfigurationColumns();

                    int linhas_ = planilha.RowsUsed().Count() + 100;

                    for (int i = 1; i <= linhas_; i++)
                    {
                        if (xlsxConfig.IsLeituraAutomatica)
                        {

                            foreach (var col in colunas)
                            {

                                if (planilha.Cell($"A{i}").Value?.ToString().Trim() == "Destinatário/Remetente")
                                {
                                    isDestinatario = true;
                                    break;
                                }
                                else if (isDestinatario)
                                {

                                    #region DADOS DESTINATARIO

                                    if (string.IsNullOrEmpty(name))
                                        name = GetNomeCliente(planilha, col.RangeAddress.FirstAddress.ColumnLetter, i);

                                    if (string.IsNullOrEmpty(cpf))
                                        cpf = GetCpfCnpj(planilha, col.RangeAddress.FirstAddress.ColumnLetter, i);

                                    if (string.IsNullOrEmpty(end))
                                        end = GetEndereco(planilha, col.RangeAddress.FirstAddress.ColumnLetter, i);

                                    if (string.IsNullOrEmpty(dataSolicitacao))
                                        dataSolicitacao = GetDataSolicitacao(planilha, col.RangeAddress.FirstAddress.ColumnLetter, i);

                                    if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(cpf) && !string.IsNullOrEmpty(end) && !string.IsNullOrEmpty(dataSolicitacao))
                                    {
                                        isDestinatario = false;
                                        break;
                                    }
                                    #endregion
                                }


                                else if (planilha.Cell($"A{i}").Value?.ToString() == "Itens da nota fiscal")
                                {
                                    isDestinatario = false;
                                    isProduto = true;

                                    break;
                                }
                                if (isProduto)
                                {

                                    var produtos = GetProdutos(planilha, i);
                                    result.Add(new Solicitacao(name, cpf, end, dataSolicitacao, produtos));

                                    isProduto = false;
                                    xlsxAnalytic = null;
                                    name = cpf = end = "";

                                    break;

                                }
                            }
                        }

                        else
                        {
                            if (planilha.Cell($"A{i}").Value?.ToString().Trim() == "Cálculo do ISSQN")
                            {
                                result.Add(solicitacao);
                                solicitacao = new Solicitacao();
                                isProduto = false;
                                continue;
                            }

                            if (planilha.Cell($"A{i}").Value?.ToString().Trim() == "Destinatário/Remetente")
                            {
                                isDestinatario = true;
                                continue;
                            }
                            else if (isDestinatario)
                            {

                                solicitacao.Destinatario = GetDestinatario(planilha, xlsxConfig, i);
                                isDestinatario = false;
                                isProduto = false;
                            }

                            else if (planilha.Cell($"A{i}").Value?.ToString() == "Itens da nota fiscal")
                            {
                                isDestinatario = false;
                                isProduto = true;
                                i++;
                                continue;
                            }

                            if (isProduto)
                            {
                                int indiceUpdate;
                                var produto_extraido = GetProduto(planilha, xlsxConfig, i, out indiceUpdate);

                                if (solicitacao.Produtos.Any(x => x.CodigoSKU == produto_extraido.CodigoSKU && x.Variacao == produto_extraido.Variacao))
                                {
                                    var attProduto = solicitacao.Produtos
                                        .FirstOrDefault(x => x.CodigoSKU == produto_extraido.CodigoSKU && x.Variacao == produto_extraido.Variacao);

                                    attProduto.Quantidade += produto_extraido.Quantidade;
                                }
                                else
                                {
                                    solicitacao.Produtos.Add(produto_extraido);
                                }

                            }
                        }
                    }
                }
            }


        }



        private static void TrataInformacoesXLSXDeclaracaoConteudo(XLWorkbook xlsx, XlsxDocumentConfigurationColumns xlsxConfig, out List<Solicitacao> result)
        {
            result = new List<Solicitacao>();

            if (xlsxConfig != null)
            {
                foreach (var planilha in xlsx.Worksheets)
                {
                    bool isProduto = false;
                    bool isDestinatario = false;
                    Solicitacao solicitacao = new Solicitacao();
                    int linhas_ = planilha.RowsUsed().Count() + 100;
                    for (int i = 1; i <= linhas_; i++)
                    {
                        if (planilha.Cell($"A{i}").Value?.ToString() == "Totais")
                        {
                            result.Add(solicitacao);
                            solicitacao = new Solicitacao();
                            isProduto = false;
                            continue;
                        }

                        if (planilha.Cell($"E{i}").Value?.ToString() == "DESTINATÁRIO" || planilha.Cell($"F{i}").Value?.ToString() == "DESTINATÁRIO"
                            || planilha.Cell($"G{i}").Value?.ToString() == "DESTINATÁRIO")
                        {
                            isDestinatario = true;
                            continue;
                        }
                        else if (isDestinatario)
                        {
                            string cpf = planilha.Cell($"{xlsxConfig.CpfCnpj}{(i + 3)}").Value?.ToString().Replace("CPF/CNPJ:", "").Trim();

                            solicitacao.Destinatario = new ObjetosDestinatario.Destinatario
                            {
                                Nome =
                                planilha.Cell($"{xlsxConfig.NomeDestinatario}{i}").Value?.ToString().Replace("NOME:", "").Trim(),
                                Endereco = planilha.Cell($"{xlsxConfig.Endereco}{(i + 1)}").Value?.ToString().Replace("ENDEREÇO:", "").Trim(),
                                CpfCnpj = cpf.SomenteNumeros() != string.Empty ? long.Parse(cpf.SomenteNumeros()) : 0
                            };
                            isDestinatario = false;
                            isProduto = false;
                        }

                        else if (planilha.Cell($"A{i}").Value?.ToString() == "IDENTIFICAÇÃO DOS BENS")
                        {
                            i++;
                            isDestinatario = false;
                            isProduto = true;
                            continue;
                        }
                        if (isProduto)
                        {
                            int id = i;//Convert.ToInt32(planilha.Cell($"A{i}").Value?.ToString().Trim());
                            string codSku = planilha.Cell($"{xlsxConfig.CodigoSKU}{i}").Value?.ToString().Trim();
                            string desc = planilha.Cell($"{xlsxConfig.Variacao}{i}").Value?.ToString().Trim();
                            string variacao = planilha.Cell($"{xlsxConfig.Variacao}{i}").Value?.ToString().Trim();
                            int quant = Convert.ToInt32(planilha.Cell($"{xlsxConfig.Quantidade}{i}").Value?.ToString().Trim());


                            if (solicitacao.Produtos.Any(x => x.CodigoSKU == codSku && x.Variacao == variacao))
                            {
                                var attProduto = solicitacao.Produtos.FirstOrDefault();
                                attProduto.Quantidade += quant;
                            }
                            else
                            {
                                solicitacao.Produtos.Add(new ProdutoResponse
                                {
                                    Id = id,
                                    CodigoSKU = codSku,
                                    Descricao = desc,
                                    Variacao = variacao,
                                    Quantidade = quant
                                });
                            }

                        }
                    }
                }
            }
            else
            {

                foreach (var planilha in xlsx.Worksheets)
                {
                    bool isProduto = false;
                    bool isDestinatario = false;
                    Solicitacao solicitacao = new Solicitacao();
                    int linhas_ = planilha.RowsUsed().Count() + 100;
                    for (int i = 1; i <= linhas_; i++)
                    {
                        if (planilha.Cell($"A{i}").Value?.ToString() == "Totais")
                        {
                            result.Add(solicitacao);
                            solicitacao = new Solicitacao();
                            isProduto = false;
                            continue;
                        }

                        if (planilha.Cell($"E{i}").Value?.ToString() == "DESTINATÁRIO")
                        {
                            isDestinatario = true;
                            continue;
                        }
                        else if (isDestinatario)
                        {
                            solicitacao.Destinatario = new ObjetosDestinatario.Destinatario
                            {
                                Nome =
                                planilha.Cell($"E{i}").Value?.ToString().Replace("NOME:", "").Trim()
                            };
                            isDestinatario = false;
                            isProduto = false;
                        }

                        else if (planilha.Cell($"A{i}").Value?.ToString() == "IDENTIFICAÇÃO DOS BENS")
                        {
                            i++;
                            isDestinatario = false;
                            isProduto = true;
                            continue;
                        }
                        if (isProduto)
                        {
                            int id = Convert.ToInt32(planilha.Cell($"A{i}").Value?.ToString().Trim());
                            string codSku = planilha.Cell($"B{i}").Value?.ToString().Trim();
                            string desc = planilha.Cell($"C{i}").Value?.ToString().Trim();
                            string variacao = planilha.Cell($"G{i}").Value?.ToString().Trim();
                            int quant = Convert.ToInt32(planilha.Cell($"J{i}").Value?.ToString().Trim());


                            if (solicitacao.Produtos.Any(x => x.CodigoSKU == codSku && x.Variacao == variacao))
                            {
                                var attProduto = solicitacao.Produtos.FirstOrDefault();
                                attProduto.Quantidade += quant;
                            }
                            else
                            {
                                solicitacao.Produtos.Add(new ProdutoResponse
                                {
                                    Id = id,
                                    CodigoSKU = codSku,
                                    Descricao = desc,
                                    Variacao = variacao,
                                    Quantidade = quant
                                });
                            }

                        }
                    }
                }
            }

        }
        #endregion


        #region Metodos Publicos
        /// <summary>
        /// 
        /// </summary>
        /// <param name="base64"></param>
        /// <param name="xlsxConfig"></param>
        /// <param name="erros"></param>
        /// <returns></returns>
        public static IEnumerable<Solicitacao> ImportarXlsxSolicitacaoDeclaracaoConteudo(string base64, XlsxDocumentConfigurationColumns xlsxConfig, out int erros)
        {
            erros = 0;
            if (base64 != string.Empty)
            {
                byte[] bytes = Convert.FromBase64String(base64);
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    List<Solicitacao> result = new List<Solicitacao>();

                    var xls = new XLWorkbook(ms);

                    TrataInformacoesXLSXDeclaracaoConteudo(xls, xlsxConfig, out result);


                    return result;
                }

            }
            return null;
        }



        public static IEnumerable<Solicitacao> ImportarXlsxSolicitacaoDANFESimplificada(string base64, XlsxDocumentConfigurationColumns xlsxConfig, out int erros)
        {
            erros = 0;
            if (base64 != string.Empty)
            {
                byte[] bytes = Convert.FromBase64String(base64);
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    List<Solicitacao> result = new List<Solicitacao>();

                    var xlsConfig = new XLWorkbook(ms);
                    TrataInformacoesXLSXDanfe(xlsConfig, xlsxConfig, out result);
                    return result;
                }

            }
            return null;
        }

        #endregion

    }
}
