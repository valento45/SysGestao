using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao_BE
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string PerguntaSecreta { get; set; }
        public string RespostaSecreta { get; set; }

        public Usuario()
        {

        }

        public Usuario(string nome, string senha, string perguntaSecreta, string respostaSecreta)
        {
            Nome = nome;
            Senha = senha;
            PerguntaSecreta = perguntaSecreta;
            RespostaSecreta = respostaSecreta;
        }

        public static string ConsultarUsuario()
        {
            NpgsqlCommand cmd = new NpgsqlCommand("select * from sysgestao.tb_usuario");
            var result = new Usuario();
            return result.ToString();
        }
    }
}
