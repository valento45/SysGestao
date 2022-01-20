using Access;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao_BE.Produto
{
    public class Produto
    {
        public int Id { get; set; }
        public string CodigoSKU { get; set; }
        public string Cor { get; set; }
        public string Tamanho { get; set; }
        public int Quantidade { get; set; }
        public string Variacao { get; set; } //Cor + Tamanho
        public string Descricao { get; set; }
        public string ImagemBase64 { get; set; }
        /// <summary>
        /// Imagem do código de barras em base64
        /// </summary>
        public string CodigoBarras { get; set; }
        /// <summary>
        /// Texto legível do código de barras
        /// </summary>
        public string CodigoBarrasText { get { return CodigoSKU + Variacao; } }
        public Produto()
        {

        }
        public Produto(DataRow dr)
        {
            Id = dr["id_produto"] != DBNull.Value ? Convert.ToInt32(dr["id_produto"]) : -1;
            CodigoSKU = dr["codigo_sku"].ToString();
            Cor = dr["cor"].ToString();
            Tamanho = dr["tamanho"].ToString();
            Quantidade = dr["quantidade"] != DBNull.Value ? Convert.ToInt32(dr["quantidade"]) : 0;
            Variacao = dr["variacao"].ToString();
            Descricao = dr["descricao"].ToString();
            CodigoBarras = dr["codigo_barras"].ToString();
            ImagemBase64 = dr["imagem_base64"].ToString();
        }

        public bool InsertOrUpdate()
        {
            if (Id > 0)
            {
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE sysgestao.tb_produto SET codigo_sku = @codigo_sku," +
                    "cor = @cor, tamanho = @tamanho, quantidade = @quantidade, variacao = @variacao," +
                    "descricao = @descricao, codigo_barras = @codigo_barras WHERE id_produto = @id_produto");
                cmd.Parameters.AddWithValue(@"id_produto", Id);
                cmd.Parameters.AddWithValue(@"codigo_sku", CodigoSKU);
                cmd.Parameters.AddWithValue(@"cor", Cor);
                cmd.Parameters.AddWithValue(@"tamanho", Tamanho);
                cmd.Parameters.AddWithValue(@"quantidade", Quantidade);
                cmd.Parameters.AddWithValue(@"variacao", Variacao);
                cmd.Parameters.AddWithValue(@"descricao", Descricao);
                cmd.Parameters.AddWithValue(@"codigo_barras", CodigoBarras);
                cmd.Parameters.AddWithValue(@"image_base64", ImagemBase64);

                return PGAccess.ExecuteNonQuery(cmd) > 0;
            }
            else
            {
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO sysgestao.tb_produto  (codigo_sku," +
                    "cor, tamanho, quantidade, variacao, descricao, codigo_barras) " +
                    "VALUES (@codigo_sku, @cor, @tamanho, @quantidade, @variacao, @descricao, @codigo_barras) RETURNING id_produto;");

                cmd.Parameters.AddWithValue(@"codigo_sku", CodigoSKU);
                cmd.Parameters.AddWithValue(@"cor", Cor);
                cmd.Parameters.AddWithValue(@"tamanho", Tamanho);
                cmd.Parameters.AddWithValue(@"quantidade", Quantidade);
                cmd.Parameters.AddWithValue(@"variacao", Variacao);
                cmd.Parameters.AddWithValue(@"descricao", Descricao);
                cmd.Parameters.AddWithValue(@"codigo_barras", CodigoBarras);
                cmd.Parameters.AddWithValue(@"image_base64", ImagemBase64);

                int id;
                if (int.TryParse(PGAccess.ExecuteScalar(cmd)?.ToString(), out id))
                {
                    Id = id;
                    return true;
                }
                else
                    return false;
            }
        }


        public bool Excluir(int id)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("delete from sysgestao.tb_produto where id_produto = @id_produto");
            cmd.Parameters.AddWithValue(@"id_produto", Id);

            return PGAccess.ExecuteNonQuery(cmd) > 0;
        }

        public static IEnumerable<Produto> ListarProdutos(int limit = 0)
        {
            List<Produto> result = new List<Produto>();

            NpgsqlCommand cmd = new NpgsqlCommand("select * from sysgestao.tb_produto " + (limit > 0 ? $" limit {limit};" : ";"));
            foreach (DataRow row in PGAccess.ExecuteReader(cmd).Tables[0].Rows)
            {
                result.Add(new Produto(row));
            }
            return result?.OrderBy(x => x.CodigoSKU);
        }

        public static IEnumerable<Produto> GetByCodigoSku(string codigoSKU, int limit = 0)
        {
            List<Produto> result = new List<Produto>();

            NpgsqlCommand cmd = new NpgsqlCommand($"select * from sysgestao.tb_produto WHERE codigo_sku like $${codigoSKU}%$$" + (limit > 0 ? $" limit {limit};" : ";"));
            foreach (DataRow row in PGAccess.ExecuteReader(cmd).Tables[0].Rows)
            {
                result.Add(new Produto(row));
            }
            return result?.OrderBy(x => x.CodigoSKU);
        }

        public static IEnumerable<Produto> GetByVariacao(string variacao, int limit = 0)
        {
            List<Produto> result = new List<Produto>();

            NpgsqlCommand cmd = new NpgsqlCommand($"select * from sysgestao.tb_produto WHERE variacao like $${variacao}%$$" + (limit > 0 ? $" limit {limit};" : ";"));
            foreach (DataRow row in PGAccess.ExecuteReader(cmd).Tables[0].Rows)
            {
                result.Add(new Produto(row));
            }
            return result?.OrderBy(x => x.CodigoSKU);
        }
    }
}
