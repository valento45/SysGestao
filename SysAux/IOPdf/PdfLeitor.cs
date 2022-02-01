using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using SysAux.ObjetosDestinatario;
using SysAux.Response;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAux.IOPdf
{
    public class PdfLeitor
    {
        public static string ExtrairTexto(string filename)
        {
            using (PdfReader leitor = new PdfReader(filename))
            {
                StringBuilder texto = new StringBuilder();
                for (int i = 1; i <= leitor.NumberOfPages; i++)
                {
                    texto.Append(PdfTextExtractor.GetTextFromPage(leitor, i));
                }
                return texto.ToString();
            }
        }

        public static IEnumerable<ProdutoResponse> GetProdutosFromText(string texto, out string textoRetorno)
        {
            List<ProdutoResponse> produtos = new List<ProdutoResponse>();
            string textoAux = texto;

            int indice = texto.IndexOf("IDENTIFICAÇÃO DOS BENS");

            if (indice > 0)
            {
                textoAux = textoAux.Substring(indice + "IDENTIFICAÇÃO DOS BENS".Length).Replace("\nNº CÓDIGO (SKU) DESCRIÇÃO DO PRODUTO VARIAÇÃO QTD VALOR\n", "");
                textoAux = textoAux.Substring(0, textoAux.IndexOf("Totais"));
                var arrayz = textoAux.Split('\n');

                for(int i = 0; i <arrayz.Length -2; i++)
                {
                    produtos.Add(ConvertTextForProdutoResponse(arrayz[i]));
                }
                
            }

            textoRetorno = "";

            return produtos;

        }

        private static ProdutoResponse ConvertTextForProdutoResponse(string text)
        {
            if(text != string.Empty)
            {
                
            }
            throw new Exception("");
        }

        public static Destinatario GetDestinatarioNomeFromText(string texto, out string textoRetorno)
        {
            string textoAux = texto.Replace("\n", " ").Replace(".", " ");
            bool proximo = true;
            string nome = "";
            int qnt = 0;
            do
            {
                int indice = textoAux.ToUpper().IndexOf("NOME", 1);
                if (indice > 0 && qnt < 1)
                {
                    textoAux = textoAux.Substring(indice + 5);
                    qnt++;
                }
                else if (indice > 0 && qnt == 1)
                {
                    int index_corte = textoAux.ToLower().IndexOf("endereço");

                    nome = textoAux.Substring(indice + 5, index_corte);
                    nome = nome.Substring(0, nome.ToLower().IndexOf("endereço") + 8);
                    nome = nome.Replace("ENDEREÇO", "");


                    textoAux = textoAux.Substring(index_corte + 9);
                    proximo = false;
                }
                else
                    proximo = false;

            } while (proximo);


            textoRetorno = textoAux;
            return new Destinatario { Nome = nome };


            throw new Exception("Falha ao obter dados do destinatário!");
        }

        public static int CountDeclaracaoInTextoPDF(string textoPdf)
        {
            string textoAux = textoPdf.Replace("\n", " ").Replace(".", " ");
            bool contemDeclaracao = true;
            int quantidadeDeclaracao = 1;
            do
            {
                int indice = textoAux.ToUpper().IndexOf("DECLARAÇÃO DE CONTEÚDO", 1);
                if (indice > 0)
                    textoAux = textoAux.Substring(indice + 22);
                else
                    contemDeclaracao = false;
                quantidadeDeclaracao++;
            } while (contemDeclaracao);

            return quantidadeDeclaracao;
        }
    }
}
