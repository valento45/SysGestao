using Newtonsoft.Json;
using SysAux.LOGS;
using SysAux.ObjetosDestinatario;
using SysAux.Util.Enums;
using SysGestao_BE.Auxx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAux.Util
{
    public class XlsxDocumentConfigurationColumns : Path7<XlsxDocumentConfigurationColumns>
    {
        public string CodigoSKU { get; set; }
        public string Quantidade { get; set; }
        public string Variacao { get; set; }
        public string NomeDestinatario { get; set; }
        public string CpfCnpj { get; set; }
        public string IdEstrangeiro { get; set; }
        public string Endereco { get; set; }
        public bool IsEstrangeiro { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public List<char> Separadores { get; set; }
        public bool IsDanfeSimplificada { get; set; }
        public bool IsLeituraAutomatica { get; set; }



        
        public static List<string> GetColunasExcel()
        {
            List<string> result = new List<string>();


            result.AddRange(new string[]
            {
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S",
            "T", "U", "V", "W", "X", "Y", "Z",
            "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS",
            "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF","BG", "BH","BI","BJ","BK","BL","BM", "BN",
            "BO","BP","BQ","BR","BS","BT","BU","BV","BW","BX","BY","BZ"
            });

            return result;
        }


        public void LimparColunas()
        {
            CodigoSKU = "";
            Variacao = "";
            Quantidade = "";
        }


        public string GetFullPathFilename() => GetFullPath().Replace(".txt", TipoDocumento.GetEnumDescriptionExtension()) + ".txt";

        public static XlsxDocumentConfigurationColumns ObterConfiguracao(TipoDocumento tipo)
        {
            XlsxDocumentConfigurationColumns result;
            try
            {
                string filename = GetFullPath().Replace(".txt", tipo.GetEnumDescriptionExtension()) + ".txt"; ;
                if (File.Exists(filename))
                {
                    string json = File.ReadAllText(filename);

                    if (json != string.Empty)
                    {
                        result = JsonConvert.DeserializeObject<XlsxDocumentConfigurationColumns>(json);
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public bool AtualizarConfiguracao()
        {
            try
            {
                var json = JsonConvert.SerializeObject(this);

                File.WriteAllText(GetFullPathFilename(), json);
                return true;
            }
            catch (Exception ex)
            {

                ExceptionLog.Insert(ex, "Falha ao atualizar configuração!!");
            }
            return false;
        }



        public bool IsProdutoConfigurado()
        {
            return !string.IsNullOrEmpty(CodigoSKU) && !string.IsNullOrEmpty(Variacao) && !string.IsNullOrEmpty(Quantidade);
        }
    }


}
