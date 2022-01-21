using Access;
using Npgsql;
using System.Data;

namespace SysGestao_BE
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string PerguntaSecreta { get; set; }
        public string RespostaSecreta { get; set; }

        //public static Usuario usuarioTrocarSenha;

        public Usuario()
        {

        }

        public Usuario(DataRow dr)
        {

        }

        public Usuario(string nome, string senha, string perguntaSecreta, string respostaSecreta)
        {
            Nome = nome;
            Senha = senha;
            PerguntaSecreta = perguntaSecreta;
            RespostaSecreta = respostaSecreta;
        }

        public static bool Logar(string nome, string senha)
        {

            NpgsqlCommand cmd = new NpgsqlCommand("select * from sysgestao.tb_usuario where user_name = @user_name and senha = @senha");
            cmd.Parameters.AddWithValue(@"user_name", nome);
            cmd.Parameters.AddWithValue(@"senha", senha);
            DataTable ds = PGAccess.ExecuteReader(cmd).Tables[0];

            if (ds.Rows.Count > 0)
            {
                Login.usuarioLogado = new Login(ds.Rows[0]);
                Login.usuarioLogado.RegistraLogin();
                return true; 
            }
            else
            {
                return false;
            }
        }

        public bool AlterarSenha(string nomeUsuario, string respostaSecreta, string novaSenha)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("update sysgestao.tb_usuario set senha = @senha where user_name = @user_name and resposta_secreta = @resposta_secreta");
            cmd.Parameters.AddWithValue(@"senha", novaSenha);
            cmd.Parameters.AddWithValue(@"user_name", nomeUsuario);
            cmd.Parameters.AddWithValue(@"resposta_secreta", respostaSecreta);

            if (PGAccess.ExecuteNonQuery(cmd) > 0) { return true; }

            return false;
        }

        public static Usuario BuscarUsuario(string usuarioBuscar)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("select * from sysgestao.tb_usuario where user_name = @user_name");
            cmd.Parameters.AddWithValue(@"user_name", usuarioBuscar);
            DataTable ds = PGAccess.ExecuteReader(cmd).Tables[0];

            if (ds.Rows.Count > 0)
            {
                return new Usuario(ds.Rows[0]);

            }
            else
            {
                return null;
            }
        }
    }
}
