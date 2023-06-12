using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao.Email
{
    public class EmailModel
    {
        public string Destinatario { get; set; }
        public string Assunto { get; set; }
        public string Mensagem { get; set; }
        public List<string> Anexos { get; set; }
        public EmailModel()
        {
            Anexos = new List<string>();
        }

    }
}
