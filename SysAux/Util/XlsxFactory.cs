using ClosedXML.Excel;
using SysAux.Response;
using SysGestao_BE.Auxx;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SysAux.Util
{
    public class XlsxFactory
    {


        private static void TrataInformacoesXLSXDanfe(XLWorkbook xlsx, XlsxDocumentConfigurationColumns xlsxConfig, out List<Solicitacao> result)
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
                        if (xlsxConfig.IsDanfeSimplificada)
                        {
                            if (planilha.Cell($"A{i}").Value?.ToString().Trim() == "VALOR NOTA R$")
                            {
                                result.Add(solicitacao);
                                solicitacao = new Solicitacao();
                                isProduto = false;
                                continue;
                            }

                            if (planilha.Cell($"A{i}").Value?.ToString().Trim() == "DANFE Simplificado - Etiqueta")
                            {
                                isDestinatario = true;
                                continue;
                            }
                            else if (isDestinatario)
                            {
                                solicitacao.Destinatario = new ObjetosDestinatario.Destinatario
                                {
                                    Nome =
                                    planilha.Cell($"{xlsxConfig.NomeDestinatario}{i}").Value?.ToString().Trim().SomenteLetras(),
                                    CpfCnpj = long.Parse(planilha.Cell($"{xlsxConfig.CpfCnpj}{++i}").Value.ToString().Replace("CNPJ:", "").Substring(0, planilha.Cell($"{xlsxConfig.CpfCnpj}{i}").Value.ToString().IndexOf("IE:") - 5).Trim().SomenteNumeros()),
                                    Endereco = planilha.Cell($"{xlsxConfig.Endereco}{++i}").Value?.ToString().Trim()
                                };
                                isDestinatario = false;
                                isProduto = false;
                            }

                            else if (planilha.Cell($"A{i}").Value?.ToString() == "ITEM")
                            {
                                isDestinatario = false;
                                isProduto = true;
                                i++;
                            }

                            if (isProduto)
                            {
                                string codSku = planilha.Cell($"{xlsxConfig.CodigoSKU}{i}").Value?.ToString().Trim();

                                if (codSku == String.Empty)
                                    continue;

                                if (codSku.IndexOf(",") > 0)
                                    codSku = codSku.Substring(0, codSku.IndexOf(","));


                                string variacao = planilha.Cell($"{xlsxConfig.Variacao}{i}").Value?.ToString().Trim();
                                if (variacao.IndexOf(",") > 0)
                                {
                                    int indiceA = variacao.IndexOf(",");
                                    int indiceB = variacao.IndexOf(" - ");

                                    variacao = variacao.Substring(indiceA + 1, indiceB);
                                    variacao = variacao.Substring(0, variacao.Length - variacao.IndexOf(" - ") - 2);
                                }

                                string quantidade_text = planilha.Cell($"{xlsxConfig.Quantidade}{i}").Value?.ToString().Trim();
                                if (quantidade_text.IndexOf(" - ") > 0)
                                {
                                    int indiceA = quantidade_text.IndexOf(",") + 3;

                                    quantidade_text = quantidade_text.Substring(indiceA);

                                    int indiceB = quantidade_text.IndexOf(" - ") + 3;
                                    int indiceC = quantidade_text.IndexOf(" UN");

                                    quantidade_text = quantidade_text.Substring(indiceB, indiceC - indiceB);


                                }
                                decimal quant = Convert.ToDecimal(quantidade_text.SomenteNumeros() != String.Empty ? quantidade_text : "0");

                                if (solicitacao.Produtos.Any(x => x.CodigoSKU == codSku && x.Variacao == variacao))
                                {
                                    var attProduto = solicitacao.Produtos.FirstOrDefault();
                                    attProduto.Quantidade += (int)quant;
                                }
                                else
                                {
                                    solicitacao.Produtos.Add(new ProdutoResponse
                                    {
                                        Id = i,
                                        CodigoSKU = codSku,
                                        Descricao = "",
                                        Variacao = variacao,
                                        Quantidade = (int)quant
                                    });
                                }
                                isProduto = false;
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
                                var name = planilha.Cell($"{xlsxConfig.NomeDestinatario}{i}").Value.ToString().Split('\n')[1];
                                string cpf = "";
                                var cpfArray = planilha.Cell($"{xlsxConfig.CpfCnpj}{i}")?.Value?.ToString()?.Split('\n');
                                cpf = cpfArray.Length > 0 ? cpfArray[1].SomenteNumeros() : ""; 

                                var end = planilha.Cell($"{xlsxConfig.Endereco}{++i}").Value?.ToString().Split('\n')[1].Trim();

                                solicitacao.Destinatario = new ObjetosDestinatario.Destinatario
                                {
                                    Nome = name,
                                    CpfCnpj = cpf!=string.Empty ?  long.Parse(cpf) : 0,
                                    Endereco = end
                                };
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
                                string codSku = "", variacao = "";

                                codSku = planilha.Cell($"{xlsxConfig.CodigoSKU}{i}").Value?.ToString().Trim();

                                string informacoes = planilha.Cell($"{xlsxConfig.Variacao}{i}").Value?.ToString().Trim();

                                if (informacoes == String.Empty)
                                    continue;
                                

                                var infos_separators = informacoes.Split(xlsxConfig.Separadores.ToArray());
                                infos_separators = infos_separators.Where(x => x != "Tamanho").ToArray();
                         
                                variacao = infos_separators.Length > 0 ? string.Join(",", infos_separators.Where(x => x != infos_separators?[0]).ToArray())
                                    : variacao;

                                string quantidade_text = planilha.Cell($"{xlsxConfig.Quantidade}{i}").Value?.ToString().Trim();
                                int quant = Convert.ToInt16(quantidade_text.SomenteNumeros() != String.Empty ? quantidade_text : "0");


                                if (solicitacao.Produtos.Any(x => x.CodigoSKU == codSku && x.Variacao == variacao))
                                {
                                    var attProduto = solicitacao.Produtos.FirstOrDefault();
                                    attProduto.Quantidade += quant;
                                }
                                else
                                {
                                    solicitacao.Produtos.Add(new ProdutoResponse
                                    {
                                        Id = i,
                                        CodigoSKU = codSku,
                                        Descricao = infos_separators.Length > 0  ? infos_separators[0] : "",
                                        Variacao = variacao,
                                        Quantidade = quant
                                    });
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
                                Endereco = planilha.Cell($"{xlsxConfig.Endereco}{(i + 1)}").Value?.ToString().Replace("ENDEREÇO:", "").Trim() ,
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



    }
}
