using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAux.Util
{
    public class ConfiguracaoLeituras
    {
        private static XlsxDocumentConfigurationColumns declaracaoConteudo { get; set; }
        private static XlsxDocumentConfigurationColumns danfe  { get; set; }



        public static XlsxDocumentConfigurationColumns GetDeclaracaoConteudo()
        {
            if(declaracaoConteudo == null)
            {
                declaracaoConteudo = XlsxDocumentConfigurationColumns.ObterConfiguracao(Enums.TipoDocumento.DECLARACAO_CONTEUDO);
            }
            return declaracaoConteudo;
        }


        public static XlsxDocumentConfigurationColumns GetDanfe()
        {
            if(danfe == null)
            {
                danfe = XlsxDocumentConfigurationColumns.ObterConfiguracao(Enums.TipoDocumento.DANFE);
            }
            return danfe;
        }

        public static void Refresh()
        {
            danfe = XlsxDocumentConfigurationColumns.ObterConfiguracao(Enums.TipoDocumento.DANFE);
            declaracaoConteudo = XlsxDocumentConfigurationColumns.ObterConfiguracao(Enums.TipoDocumento.DECLARACAO_CONTEUDO);
        }
    }
}
