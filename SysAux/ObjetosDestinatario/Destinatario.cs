using Access;
using DocumentFormat.OpenXml.Office2010.Excel;
using Npgsql;
using SysAux;
using SysAux.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SysAux.ObjetosDestinatario
{
    public class Destinatario : IDestinatario
    {
        public int IdClienteDestinatario { get; set; }
        private string _nome;
        public string Nome
        {
            get
            {
                if (_nome == string.Empty && IdClienteDestinatario > 0)
                {
                    var obj = Destinatario.ObterPorID(IdClienteDestinatario);

                    _nome = obj?.Nome ?? "";
                    this.CpfCnpj = obj?.CpfCnpj ?? 0;
                    this.Endereco = obj?.Endereco ?? "";
                    this.IdEstrangeiro = obj?.IdEstrangeiro ?? 0;
                }
                return _nome;
            }
            set => _nome = value;
        }
        public long CpfCnpj { get; set; }
        public long IdEstrangeiro { get; set; }
        public bool IsEstrangeiro { get { return IdEstrangeiro > 0; } }
        public string Endereco { get; set; }

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

        public Destinatario(string nome, string cpfCnpj, string endereco)
        {
            _nome = nome;
            CpfCnpj = long.Parse(cpfCnpj);
            Endereco = endereco;

        }

        public Destinatario(DataRow dr)
        {

            IdClienteDestinatario = int.Parse(dr["id_cliente_destinatario"].ToString());
            Nome = dr["nome"].ToString();
            Endereco = dr["endereco"].ToString();

            long cpfcnpj;
            long.TryParse(dr["cpfcnpj"].ToString(), out cpfcnpj);
            CpfCnpj = cpfcnpj;
            IdEstrangeiro = dr["idestrangeiro"] != null ? int.Parse(dr["idestrangeiro"].ToString()) : 0;

        }


        public int InsertCliente()
        {
            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO sysgestao.tb_cliente_destinatario (nome, endereco, cpfcnpj, idestrangeiro) " +
                "VALUES (@nome, @endereco, @cpfcnpj, @idestrangeiro) RETURNING id_cliente_destinatario;");
            cmd.Parameters.AddWithValue(@"nome", Nome);
            cmd.Parameters.AddWithValue(@"endereco", Endereco);
            cmd.Parameters.AddWithValue(@"cpfcnpj", CpfCnpj);
            cmd.Parameters.AddWithValue(@"idestrangeiro", IdEstrangeiro);
            int result = int.Parse(PGAccess.ExecuteScalar(cmd).ToString());
            return result;
        }

        public bool AtualizarCliente()
        {
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE sysgestao.tb_cliente_destinatario SET nome= @nome, endereco = @endereco, " +
                $"cpfcnpj = cpfcnpj, idestrangeiro = @idestrangeiro WHERE id_cliente_destinatario = {IdClienteDestinatario} ;");
            cmd.Parameters.AddWithValue(@"nome", Nome);
            cmd.Parameters.AddWithValue(@"endereco", Endereco);
            cmd.Parameters.AddWithValue(@"cpfcnpj", CpfCnpj);
            cmd.Parameters.AddWithValue(@"idestrangeiro", IdEstrangeiro);
            int result = PGAccess.ExecuteNonQuery(cmd);
            return result > 0;

        }


        public static bool Deletar(int id)
        {
            NpgsqlCommand cmd = null;

            cmd = new NpgsqlCommand("delete from sysgestao.tb_item_pre_solicitacao where id_pre_solicitacao in " +
                $"(select id_pre_solicitacao from sysgestao.tb_pre_solicitacao_produto where id_cliente_destinatario = {id})");
            PGAccess.ExecuteNonQuery(cmd);

            cmd = new NpgsqlCommand("delete from sysgestao.tb_pre_solicitacao_produto where id_cliente_destinatario = " + id);
            PGAccess.ExecuteNonQuery(cmd);


            cmd = new NpgsqlCommand("delete from sysgestao.tb_item_solicitacao where id_solicitacao in " +
                $"(select id_solicitacao from sysgestao.tb_solicitacao_produto where id_cliente_destinatario = {id})");
            PGAccess.ExecuteNonQuery(cmd);

            cmd = new NpgsqlCommand("delete from sysgestao.tb_solicitacao_produto where id_cliente_destinatario = " + id);
            PGAccess.ExecuteNonQuery(cmd);

            cmd = new NpgsqlCommand("DELETE FROM sysgestao.tb_cliente_destinatario " +
              $" WHERE id_cliente_destinatario = {id} ;");

            int result = PGAccess.ExecuteNonQuery(cmd);
            return result > 0;
        }

        public static bool Exists(string nome)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("select count(*) from sysgestao.tb_cliente_destinatario " +
              $" WHERE UPPER(nome) LIKE {nome.ToUpper()} ;");

            DataRow row = PGAccess.ExecuteReader(cmd).Tables[0].Rows[0];
            int result = int.Parse(row["count"].ToString());

            return result > 0;
        }

        public static bool Exists(long cpfCnpj)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("select count(*) from sysgestao.tb_cliente_destinatario " +
              $" WHERE cpfcnpj = {cpfCnpj} ;");

            DataRow row = PGAccess.ExecuteReader(cmd).Tables[0].Rows[0];
            int result = int.Parse(row["count"].ToString());

            return result > 0;
        }

        public static Destinatario ObterPorID(int id)
        {
            if (id > 0)
            {
                NpgsqlCommand cmd = new NpgsqlCommand("select * from sysgestao.tb_cliente_destinatario " +
                  $" WHERE id_cliente_destinatario = {id} ;");

                var rows = PGAccess.ExecuteReader(cmd).Tables[0]?.Rows;

                if (rows.Count > 0)
                    return new Destinatario(rows[0]);

                return null;
            }
            return null;
        }

        public static Destinatario ObterPorCPF(long cpfCnpj)
        {
            Destinatario result = null;
            NpgsqlCommand cmd = new NpgsqlCommand("select * from sysgestao.tb_cliente_destinatario " +
              $" WHERE cpfcnpj = {cpfCnpj} ;");

            var row = PGAccess.ExecuteReader(cmd).Tables[0].Rows;
            if (row.Count > 0)
                result = new Destinatario(row[0]);

            return result;
        }


        public static List<Destinatario> ObterPorNome(string param, int limite = 0)
        {
            List<Destinatario> result = new List<Destinatario>();
            NpgsqlCommand cmd = new NpgsqlCommand("select * from sysgestao.tb_cliente_destinatario " +
              $" WHERE nome LIKE '{param}%' ORDER BY nome {(limite > 0 ? "limit " + limite : "")}");

            foreach (DataRow row in PGAccess.ExecuteReader(cmd).Tables[0].Rows)
            {
                result.Add(new Destinatario(row));
            }

            return result;
        }
    }
}
