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
                if (_nome == string.Empty)
                {
                    var obj = Destinatario.ObterPorID(IdClienteDestinatario);

                    _nome = obj.Nome;
                    this.CpfCnpj = obj.CpfCnpj;
                    this.Endereco = obj.Endereco;
                    this.IdEstrangeiro = obj.IdEstrangeiro;                   
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

        public Destinatario(DataRow dr)
        {

            IdClienteDestinatario = int.Parse(dr["id_cliente_destinatario"].ToString());
            Nome = dr["nome"].ToString();
            Endereco = dr["endereco"].ToString();

            long cpfcnpj;
            long.TryParse(dr["cpfcnpj"].ToString(), out cpfcnpj);
            CpfCnpj = cpfcnpj;

            int idEstrangeiro;
            int.TryParse(dr["id_estrangeiro"].ToString(), out idEstrangeiro);
            IdEstrangeiro = idEstrangeiro;


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

            int result = PGAccess.ExecuteNonQuery(cmd);
            return result > 0;

        }


        public static bool Deletar(int id)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM sysgestao.tb_cliente_destinatario " +
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
            NpgsqlCommand cmd = new NpgsqlCommand("select * from sysgestao.tb_cliente_destinatario " +
              $" WHERE id_cliente_destinatario = {id} ;");

            DataRow row = PGAccess.ExecuteReader(cmd).Tables[0].Rows[0];
            var result = new Destinatario(row);

            return result;
        }

        public static Destinatario ObterPorCPF(long cpfCnpj)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("select * from sysgestao.tb_cliente_destinatario " +
              $" WHERE cpfcnpj = {cpfCnpj} ;");

            DataRow row = PGAccess.ExecuteReader(cmd).Tables[0].Rows[0];
            var result = new Destinatario(row);

            return result;
        }
    }
}
