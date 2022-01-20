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
    public class Login
    {
        public static Login usuarioLogado;
        public int Id_Usuario { get; set; }
        public string Usuario_ { get; set; }
        public DateTime DataLogin { get; set; }

        public Login(DataRow dr)
        {
            Id_Usuario = dr["id_usuario"] != DBNull.Value ? Convert.ToInt32(dr["id_usuario"].ToString()) : -1;
            Usuario_ = dr["user_name"].ToString();
            DataLogin = DateTime.Now;
        }

        public void RegistraLogin()
        {
            if(Id_Usuario > 0)
            {
                NpgsqlCommand cmd = new NpgsqlCommand("insert into sysgestao.tb_login(data_login, id_usuario) values (@data_login, @id_usuario)");
                cmd.Parameters.AddWithValue(@"data_login", DataLogin);
                cmd.Parameters.AddWithValue(@"id_usuario", Id_Usuario);

                PGAccess.ExecuteNonQuery(cmd);
            }
        }

    }
  
}
