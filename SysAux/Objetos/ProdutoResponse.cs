using SysAux.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAux.Response
{
    public class ProdutoResponse : IProduto
    {
        public int Id { get; set; }
        public string CodigoSKU { get; set; }
        public string Descricao { get; set; }
        public string Variacao { get; set; }
        public int Quantidade { get; set; }
        public bool Separado { get; set; }
        public string Cor { get; set; }
        public string Tamanho { get; set; }
        public string ImagemBase64 { get; set; }
        /// <summary>
        /// Imagem do código de barras em base64
        /// </summary>
        public string CodigoBarrasBase64 { get; set; }

        /// <summary>
        /// Texto do codigo de barras
        /// </summary>
        public string CodigoBarras { get; set; }
        /// <summary>
        /// Texto legível do código de barras
        /// </summary>
        private string _codigoBarrasText { get; set; }
        public string CodigoBarrasText
        {
            get
            {
               // _codigoBarrasText = CalculaCodigoBarras(CodigoSKU, Variacao);
                return _codigoBarrasText;
            }
            set
            {
                _codigoBarrasText = value;
            }
        }



        public ProdutoResponse()
        {
            
        }

        public ProdutoResponse(string codigoSku, string variacao, string descricao, int quantidade)
        {
            CodigoSKU = codigoSku;
            Variacao = variacao;
            Descricao = descricao;
            Quantidade = quantidade;
        }

        private string CalculaCodigoBarras(string codigoSKU, string variavao)
        {
            string result = "";
            string auxSKU = "";
            string auxSKU2 = "";
            int index = 0;
            index = codigoSKU.IndexOf(" ");
            if (index > 0)
                auxSKU = codigoSKU.Substring(index).Trim();
            else
            {
                auxSKU = codigoSKU.Substring(0, 3).Trim();
                result = auxSKU + variavao.Substring(0, 3);
            }

            auxSKU2 = auxSKU.Substring(auxSKU.IndexOf(" ")).Trim();
            result = (codigoSKU.Substring(0, 3) + auxSKU.Substring(0, auxSKU.Length >= 3 ? 3 : auxSKU.Length) + (auxSKU2.Length > 0 ? auxSKU2.Substring(0, auxSKU2.Length >= 2 ? 2 : auxSKU2.Length) : "") + variavao.Substring(0, 3) + variavao.Substring(variavao.IndexOf(',')).Replace(",", string.Empty)).Replace(" ", "").Replace("/", "").Replace("-", "");

            return result;
        }
        public ProdutoResponse ConvertParaListaDeSeparacao()
        {
            return new ProdutoResponse
            {
                Id = Id,
                CodigoSKU = CodigoSKU,
                Descricao = Descricao,
                Variacao = Variacao,
                Quantidade = 0, //Hard Code == ZERADO POIS AINDA NAO FOI SEPARADO NENHUM
                Separado = false
                
            };
        }


    }
}
