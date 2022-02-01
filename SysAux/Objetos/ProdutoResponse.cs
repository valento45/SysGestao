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
        public string CodigoBarrasText { get { return CodigoSKU + Variacao; } }

        public ProdutoResponse ConvertParaListaDeSeparacao()
        {
            return new ProdutoResponse
            {
                Id = Id,
                CodigoSKU = CodigoSKU,
                Descricao = Descricao,
                Variacao = Variacao,
                Quantidade = 0,
                Separado = false
            };
        }


    }
}
