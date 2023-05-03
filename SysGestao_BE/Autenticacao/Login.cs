using Access;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao_BE
{
    public enum TipoLogin : int
    {
        Login = 1,
        Logoff = 0
    }
    public class Login
    {
        public static Login usuarioLogado;
        public int Id_Usuario { get; set; }
        public string Usuario_ { get; set; }
        public DateTime DataLogin { get; set; }
        public TipoLogin Tipo { get; set; }

        public Login()
        {

        }

        public Login(int idUsuario)
        {

        }

        public Login(DataRow dr)
        {
            Id_Usuario = dr["id_usuario"] != DBNull.Value ? Convert.ToInt32(dr["id_usuario"].ToString()) : -1;
            Usuario_ = dr["user_name"].ToString();
            DataLogin = DateTime.Now;
        }

        public void RegistraLogin(TipoLogin tipo)
        {
            if (Id_Usuario > 0)
            {
                NpgsqlCommand cmd = new NpgsqlCommand("insert into sysgestao.tb_login(id_usuario, data_hora, tipo) values (@id_usuario, @data_hora, @tipo)");
                cmd.Parameters.AddWithValue(@"data_hora", DataLogin);
                cmd.Parameters.AddWithValue(@"id_usuario", Id_Usuario);
                cmd.Parameters.AddWithValue(@"tipo", (int)tipo);
                PGAccess.ExecuteNonQuery(cmd);
            }
        }

    }

}
