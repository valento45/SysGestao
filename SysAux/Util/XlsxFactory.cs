using ClosedXML.Excel;
using SysAux.Response;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAux.Util
{
    public class XlsxFactory
    {
        public static IEnumerable<Solicitacao> ImportarXlsxSolicitacao(string base64, out int erros)
        {
            erros = 0;
            if (base64 != string.Empty)
            {
                byte[] bytes = Convert.FromBase64String(base64);
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    List<Solicitacao> result = new List<Solicitacao>();
                    
                    var xlsConfig = new XLWorkbook(ms);
                    foreach (var planilha in xlsConfig.Worksheets)
                    {
                        bool isProduto = false;
                        bool isDestinatario = false;
                        Solicitacao solicitacao = new Solicitacao();
                        solicitacao.Status = StatusSolicitacao.Pendente;

                        for (int i = 1; i <= planilha?.RowsUsed().Count(); i++)
                        {
                            if (planilha.Cell($"A{i}").Value?.ToString() == "Totais")
                            {
                                result.Add(solicitacao);
                                break;
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

                                solicitacao.Produtos.Add(new ProdutoResponse
                                {
                                    Id = Convert.ToInt32(planilha.Cell($"A{i}").Value?.ToString().Trim()),
                                    CodigoSKU = planilha.Cell($"B{i}").Value?.ToString().Trim(),
                                    Descricao = planilha.Cell($"C{i}").Value?.ToString().Trim(),
                                    Variacao = planilha.Cell($"G{i}").Value?.ToString().Trim(),
                                    Quantidade = Convert.ToInt32(planilha.Cell($"I{i}").Value?.ToString().Trim())
                                });
                            }
                        }
                    }
                    return result;
                }

            }
            return null;
        }
    }
}
