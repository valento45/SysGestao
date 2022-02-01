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
        Destinatario Destinatario { get; set; }
        List<ProdutoResponse> Produtos { get; set; }
        StatusSolicitacao Status { get; set; }
        DateTime DataSolicitacao { get; set; }
        string ArquivoOrigem { get; set; }
    }
}
