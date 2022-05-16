using SysAux.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysAux.Util
{
    public class CampoAdicionalXlsx : ICampoAdicionalXlsx
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mask { get; set; }
        public bool Obrigatorio { get; set; }
        public bool UseMask { get; set; }
        public string Conteudo { get; set; }
        public TipoCampo Tipo { get; set; }
        public bool IsReadOnly { get; set; }
        private Control _control { get; set; }


        public CampoAdicionalXlsx()
        {

        }

        public CampoAdicionalXlsx(int id, string name, string mask, bool obrigatorio, bool useMask, string conteudo, TipoCampo tipo, bool isReadOnly)
        {
            Id = id;
            Name = name;
            Mask = mask;
            Obrigatorio = obrigatorio;
            UseMask = useMask;
            Conteudo = conteudo;
            Tipo = tipo;
            IsReadOnly = isReadOnly;
        }


        public Control GetControl()
        {
            if (_control == null)
            {
                switch (Tipo)
                {
                    case TipoCampo.TextBox:
                        _control = new TextBox
                        {
                            Name = this.Name,
                            Text = this.Conteudo,
                            ReadOnly = this.IsReadOnly
                        };
                        break;

                    case TipoCampo.ComboBox:
                        _control = new ComboBox { };
                        break;

                    case TipoCampo.MaskedTextBox:
                        _control = new MaskedTextBox
                        {
                            Name = this.Name,
                            Text = this.Conteudo,
                            ReadOnly = this.IsReadOnly,
                            Mask = UseMask ? this.Mask : ""
                        };
                        break;

                    default:
                        return null;
                }
            }
            return _control;
        }

        public static bool InsertCampo(CampoAdicionalXlsx campo)
        {
            bool result = false;

            if(campo != null)
            {

            }


            return result;
        }
    }
}
