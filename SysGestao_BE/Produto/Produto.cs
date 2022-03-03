using Access;
using Npgsql;
using SysAux.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao_BE.Produto
{
    public class Produto : ProdutoResponse
    {
        public Produto()
        {

        }
        public Produto(DataRow dr)
        {
            Id = dr["id_produto"] != DBNull.Value ? Convert.ToInt32(dr["id_produto"].ToString()) : -1;
            CodigoSKU = dr["codigo_sku"].ToString();
            Cor = dr["cor"].ToString();
            Tamanho = dr["tamanho"].ToString();
            Quantidade = dr["quantidade"] != DBNull.Value ? Convert.ToInt32(dr["quantidade"]) : 0;
            Variacao = dr["variacao"].ToString();
            Descricao = dr["descricao"].ToString();
            CodigoBarras = dr["codigo_barras"].ToString();
            ImagemBase64 = dr["imagem_base64"].ToString();
            CodigoBarrasText = dr["codigo_barras_texto"].ToString();
        }
        public void GetNexVal(DataRow dr)
        {

        }

        public bool InsertOrUpdate()
        {
            if (Id > 0)
            {
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE sysgestao.tb_produto SET codigo_sku = @codigo_sku," +
                    "cor = @cor, tamanho = @tamanho, quantidade = @quantidade, variacao = @variacao," +
                    "descricao = @descricao, codigo_barras = @codigo_barras, imagem_base64 = @imagem_base64, codigo_barras_texto = @codigo_barras_texto WHERE id_produto = @id_produto");
                cmd.Parameters.AddWithValue(@"id_produto", Id);
                cmd.Parameters.AddWithValue(@"codigo_sku", CodigoSKU);
                cmd.Parameters.AddWithValue(@"cor", Cor);
                cmd.Parameters.AddWithValue(@"tamanho", Tamanho);
                cmd.Parameters.AddWithValue(@"quantidade", Quantidade);
                cmd.Parameters.AddWithValue(@"variacao", Variacao);
                cmd.Parameters.AddWithValue(@"descricao", Descricao);
                cmd.Parameters.AddWithValue(@"codigo_barras", CodigoBarras);
                cmd.Parameters.AddWithValue(@"imagem_base64", ImagemBase64);
                cmd.Parameters.AddWithValue(@"codigo_barras_texto", CodigoBarrasText);


                return PGAccess.ExecuteNonQuery(cmd) > 0;
            }
            else
            {
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO sysgestao.tb_produto  (codigo_sku," +
                    "cor, tamanho, quantidade, variacao, descricao, codigo_barras, imagem_base64, codigo_barras_texto) " +
                    "VALUES (@codigo_sku, @cor, @tamanho, @quantidade, @variacao, @descricao, @codigo_barras, @imagem_base64, @codigo_barras_texto) RETURNING id_produto;");

                cmd.Parameters.AddWithValue(@"codigo_sku", CodigoSKU);
                cmd.Parameters.AddWithValue(@"cor", Cor);
                cmd.Parameters.AddWithValue(@"tamanho", Tamanho);
                cmd.Parameters.AddWithValue(@"quantidade", Quantidade);
                cmd.Parameters.AddWithValue(@"variacao", Variacao);
                cmd.Parameters.AddWithValue(@"descricao", Descricao);
                cmd.Parameters.AddWithValue(@"codigo_barras", CodigoBarras);
                cmd.Parameters.AddWithValue(@"imagem_base64", ImagemBase64);
                cmd.Parameters.AddWithValue(@"codigo_barras_texto", CodigoBarrasText);

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


        public static bool Excluir(int id)
        {
            if( id == -1)
            {
                return false;
            }

            NpgsqlCommand cmd = new NpgsqlCommand("delete from sysgestao.tb_produto where id_produto = @id_produto");
            cmd.Parameters.AddWithValue(@"id_produto", id);

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

            NpgsqlCommand cmd = new NpgsqlCommand($"select * from sysgestao.tb_produto WHERE UPPER(codigo_sku) like UPPER($${codigoSKU}%$$)" + (limit > 0 ? $" limit {limit};" : ";"));
            foreach (DataRow row in PGAccess.ExecuteReader(cmd).Tables[0].Rows)
            {
                result.Add(new Produto(row));
            }
            return result?.OrderBy(x => x.CodigoSKU);
        }

        public static IEnumerable<Produto> GetByVariacao(string variacao, int limit = 0)
        {
            List<Produto> result = new List<Produto>();

            NpgsqlCommand cmd = new NpgsqlCommand($"select * from sysgestao.tb_produto WHERE UPPER(variacao) like UPPER($${variacao}%$$)" + (limit > 0 ? $" limit {limit};" : ";"));
            foreach (DataRow row in PGAccess.ExecuteReader(cmd).Tables[0].Rows)
            {
                result.Add(new Produto(row));
            }
            return result?.OrderBy(x => x.CodigoSKU);
        }

        public static Produto GetById(int id)
        {
            Produto result = null;

            NpgsqlCommand cmd = new NpgsqlCommand($"select * from sysgestao.tb_produto WHERE id_produto = $${id}$$;");
            DataTable dt = PGAccess.ExecuteReader(cmd).Tables[0];

            if (dt.Rows.Count > 0)
                result = new Produto(dt.Rows[0]);

            return result;
        }


        public static Produto GetByBarCode(string codigo)
        {
            NpgsqlCommand cmd = new NpgsqlCommand($"select * from sysgestao.tb_produto WHERE UPPER(codigo_barras_texto) LIKE UPPER($${codigo}%$$);");
            DataTable dt = PGAccess.ExecuteReader(cmd).Tables[0];
            if (dt.Rows.Count > 0)
                return new Produto(dt.Rows[0]);

            else
                return null;
        }
        public static void BaixarEstoque(int idProduto, int qtde)
        {
            NpgsqlCommand cmd = new NpgsqlCommand($"UPDATE sysgestao.tb_produto SET quantidade = quantidade - $${qtde}$$ " +
                $"WHERE id_produto = $${idProduto}$$;");

            PGAccess.ExecuteNonQuery(cmd);
        }

        public void BaixarEstoque(int qtde)
        {
            NpgsqlCommand cmd = new NpgsqlCommand($"UPDATE sysgestao.tb_produto SET quantidade = quantidade - $${qtde}$$ " +
                $"WHERE id_produto = $${Id}$$;");

            PGAccess.ExecuteNonQuery(cmd);
        }

        public static int GetNextCodigoBar()
        {
            NpgsqlCommand cmd = new NpgsqlCommand($"select codigo_barras_texto from sysgestao.tb_produto Order By codigo_barras_texto desc limit 1;");
            DataTable dt = PGAccess.ExecuteReader(cmd).Tables[0];
            if (dt.Rows.Count > 0)
            {
                var obj = dt.Rows[0]["codigo_barras_texto"].ToString();
                if (obj != string.Empty)
                {
                    int codigo = Convert.ToInt32(obj);
                    return ++codigo;
                }
                else return 1;
            }
            else
                return 1;
        }
        public static Produto GetBySKUAndVariacao(string sku, string variacao)
        {
            NpgsqlCommand cmd = new NpgsqlCommand($"select * from sysgestao.tb_produto WHERE UPPER(codigo_sku) like UPPER($${sku}$$) and " +
                $"UPPER(variacao) like UPPER($${variacao}%$$);");
            DataTable dt = PGAccess.ExecuteReader(cmd).Tables[0];
            if (dt.Rows.Count > 0)
                return new Produto(dt.Rows[0]);

            else
                return null;
        }


        public Produto Clone()
        {
            Produto prd = new Produto();
            
            prd.CodigoSKU = CodigoSKU;
            prd.Descricao = Descricao;
            prd.Variacao = Variacao;
            prd.Quantidade = Quantidade;
            prd.Separado = false;
            prd.Cor = Cor;
            prd.Tamanho = Tamanho;
            prd.ImagemBase64 = ImagemBase64;
            prd.CodigoBarrasBase64 = "";
            prd.CodigoBarras = "";
            prd.CodigoBarrasText = "";

            return prd;
        }


        public override bool Equals(object obj)
        {
            if (obj is Produto prd)
            {
                return prd.Id == Id;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            int hashCode = -856579666;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CodigoSKU);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Descricao);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Variacao);
            hashCode = hashCode * -1521134295 + Quantidade.GetHashCode();
            hashCode = hashCode * -1521134295 + Separado.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Cor);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Tamanho);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ImagemBase64);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CodigoBarrasBase64);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CodigoBarras);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CodigoBarrasText);
            return hashCode;
        }
    }
}
