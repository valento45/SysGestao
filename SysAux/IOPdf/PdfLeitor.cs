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
        //public static string ExtrairTexto(string filename)
        //{
        //    using (PdfReader leitor = new PdfReader(filename))
        //    {
        //        StringBuilder texto = new StringBuilder();
        //        for (int i = 1; i <= leitor.NumberOfPages; i++)
        //        {
        //            texto.Append(PdfTextExtractor.GetTextFromPage(leitor, i));
        //        }
        //        return texto.ToString();
        //    }
        //}

        public static IEnumerable<ProdutoResponse> GetProdutosFromText(string texto)
        {
            List<ProdutoResponse> produtos = new List<ProdutoResponse>();

            int indiceCodigoSKU_primeiro = texto.IndexOf("IDENTIFICAÇÃO DOS BENS");



            return produtos;
        }

        public static string GetDestinatarioNomeFromText(string texto)
        {
            return "";
        }

        public static string ConvertePDFParaTexto(string filepath)
        {

            using(StreamReader fs = new StreamReader(filepath))
            {
                var x = fs.ReadToEnd();
            }

            byte[] objByte = File.ReadAllBytes(filepath);

            string arquivo = Convert.ToBase64String(objByte);


            File.WriteAllText(filepath.Replace(".pdf", ".txt"), arquivo);

            return File.ReadAllText(filepath);
        }
    }
}
