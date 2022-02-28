using Access;
using Npgsql;
using System;
using System.Data;

namespace SysGestao_BE
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string LoginUsuario { get; set; }
        public string Senha { get; set; }
        public string PerguntaSecreta { get; set; }
        public string RespostaSecreta { get; set; }

        //public static Usuario usuarioTrocarSenha;

        public Usuario()
        {
           
        }

        public Usuario(DataRow dr)
        {
            Id = Convert.ToInt32(dr["id_usuario"].ToString());
            Nome = dr["nome"].ToString();
            LoginUsuario = dr["user_name"].ToString();
            Senha = dr["senha"].ToString();
            PerguntaSecreta = dr["pergunta_secreta"].ToString();
            RespostaSecreta = dr["resposta_secreta"].ToString();
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
               // Login.usuarioLogado.RegistraLogin();
                return true; 
            }
            else
            {
                return false;
            }
        }
        public bool InsertOrUpdate()
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            
            cmd.Parameters.AddWithValue(@"nome", Nome);
            cmd.Parameters.AddWithValue(@"user_name", LoginUsuario);
            cmd.Parameters.AddWithValue(@"senha", Senha);
            cmd.Parameters.AddWithValue(@"pergunta_secreta", PerguntaSecreta);
            cmd.Parameters.AddWithValue(@"resposta_secreta", RespostaSecreta);

            if(Id > 0)
            {
                cmd.Parameters.AddWithValue(@"id_usuario", Id);
                cmd.CommandText = "UPDATE sysgestao.tb_usuario SET nome = @nome, user_name = @user_name, senha = @senha, pergunta_secreta = @pergunta_secreta," +
                    "resposta_secreta = @resposta_secreta WHERE id_usuario = @id_usuario;"; 
            }
            else
            {
                cmd.CommandText = "INSERT INTO sysgestao.tb_usuario (nome, user_name, senha, pergunta_secreta, resposta_secreta) " +
                    "values (@nome, @user_name, @senha, @pergunta_secreta, @resposta_secreta);";
            }

            return PGAccess.ExecuteNonQuery(cmd) > 0;
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
