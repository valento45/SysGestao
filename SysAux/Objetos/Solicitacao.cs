using SysAux.Interfaces;
using SysAux.ObjetosDestinatario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAux.Response
{
    public class Solicitacao : ISolicitacao
    {
        public Solicitacao()
        {
            destinatario = new Destinatario();
            produtoResponses = new List<ProdutoResponse>();
        }
        private Destinatario destinatario;
        private List<ProdutoResponse> produtoResponses;
        private StatusSolicitacao status;

        public Destinatario Destinatario { get => destinatario; set => destinatario = value; }
        public List<ProdutoResponse> Produtos { get => produtoResponses; set => produtoResponses = value; }
        public StatusSolicitacao Status
        {
            get =>
                status;
            set =>
                status = value;
        }
        public DateTime DataSolicitacao { get; set; }
        public string ArquivoOrigem { get; set; }
        public int Id { get; set; }

        public bool Inserir()
        {
            throw new NotImplementedException();
        }
    }

    public enum StatusSolicitacao
    {
        [Description("Pendente")]
        Pendente = 1,

        [Description("Finalizado")]
        Finalizado = 0
    }
}
