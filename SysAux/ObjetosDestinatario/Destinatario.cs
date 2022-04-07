using SysAux;
using SysAux.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAux.ObjetosDestinatario
{
    public class Destinatario : IDestinatario
    {
        private string _nome;
        public string Nome { get => _nome; set => _nome = value; }


        public override string ToString()
        {
            return Nome.Trim();
        }
        public Destinatario()
        {

        }
        public Destinatario(string nome)
        {
            _nome = nome;
        }
    }
}
