using Access;
using Npgsql;
using SysAux.Configuracoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao_BE.Configuracoes
{
    public class ConfiguracoesMarketplaceBE
    {

        public static bool Insert(Marketplace configuracoes)
        {

            if (configuracoes?.ID > 0)
            {
                return Update(configuracoes);
            }
            else
            {
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO sysgestao.tb_configura_marketplaces (marketplace) values (@marketplace) RETURNING id_marketplace;");
                cmd.Parameters.AddWithValue(@"marketplace", configuracoes.NomeMarketplace);

                var result = (int)PGAccess.ExecuteScalar(cmd);
                return result > 0;
            }
        }


        public static bool Update(Marketplace configuracoes)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(
                $"update sysgestao.tb_configura_marketplaces set marketplace = '{configuracoes.NomeMarketplace}' where " +
                $"id_marketplace = {configuracoes.ID}");

            return PGAccess.ExecuteNonQuery(cmd) > 0;
        }


        public static bool Excluir(int id)
        {
            NpgsqlCommand cmd;

            try
            {
                cmd = new NpgsqlCommand("delete from sysgestao.tb_marketplace_produto where id_marketplace = " + id);
                PGAccess.ExecuteNonQuery(cmd);

                cmd = new NpgsqlCommand("delete from sysgestao.tb_configura_marketplaces where id_marketplace = " + id);
                return PGAccess.ExecuteNonQuery(cmd) > 0;
            }
            catch(Exception ex) { throw ex; }
        }


        public static List<Marketplace> GetMarketplaces(int limit = 0)
        {
            var result = new List<Marketplace>();

            NpgsqlCommand cmd = new NpgsqlCommand("select * from sysgestao.tb_configura_marketplaces "
                + (limit > 0 ? $"limit {limit}" : ""));

            foreach (DataRow row in PGAccess.ExecuteReader(cmd).Tables[0].Rows)
            {
                result.Add(new Marketplace(row));
            }

            return result;
        }

        public static Marketplace GetMarketplacePorID(int id)
        {
            var result = new List<Marketplace>();

            NpgsqlCommand cmd = new NpgsqlCommand("select * from sysgestao.tb_configura_marketplaces where id_marketplace = "
                + id);


            foreach (DataRow row in PGAccess.ExecuteReader(cmd).Tables[0].Rows)
            {
                result.Add(new Marketplace(row));
            }

            return result.FirstOrDefault();
        }
    }
}
