using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAux.Util.Enums
{
    public enum TipoDocumento : int
    {
        [Description("DANFE Simplificada")]
        DANFE = 1,

        [Description("Declaração de conteúdo")]
        DECLARACAO_CONTEUDO = 2,

        [Description("XML")]
        XML = 3
    }
}
