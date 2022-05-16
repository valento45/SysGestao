using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAux.Interfaces
{
    public interface ICampoAdicionalXlsx
    {
        int Id { get; set; }
        string Name { get; set; }
        string Mask { get; set; }
        bool Obrigatorio { get; set; }
        bool UseMask { get; set; }
        string Conteudo { get; set; }
        TipoCampo Tipo { get; set; }
        bool IsReadOnly { get;set; }
    }

    public enum TipoCampo : int
    {
        ComboBox = 0,
        TextBox = 1,
        MaskedTextBox = 2
    }
}


