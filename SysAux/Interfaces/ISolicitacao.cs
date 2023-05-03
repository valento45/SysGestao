using SysAux.ObjetosDestinatario;
using SysAux.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAux.Interfaces
{
    public interface ISolicitacao
    {
        int Id { get; set; }
        Destinatario Destinatario { get; set; }
        int IdClienteDestinatario { get; set; }
        List<ProdutoResponse> Produtos { get; set; }
        StatusSolicitacao Status { get; set; }
        DateTime DataSolicitacao { get; set; }
        string ArquivoOrigem { get; set; }
        int IdMarketplace { get; set; }
        bool Inserir();
        bool VerificaEAtualizaTabelaDestinatario();
    }
}
