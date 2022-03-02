using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Access;
using Newtonsoft.Json;
using Npgsql;
using SysGestao_BE.Produto;

namespace SysGestao_BE.AlertasEstoque
{
    public class ConfiguracaoDeAlertas
    {
        public bool EmitirAlertas { get; set; }
        public int QuantidadeMinima { get; set; }
        private bool Run { get; set; } = true;
        public List<Produto.Produto> Produtos { get; set; }


        public ConfiguracaoDeAlertas()
        {

        }
        public ConfiguracaoDeAlertas(bool emitir, int quantidadeMin)
        {
            EmitirAlertas = emitir;
            QuantidadeMinima = quantidadeMin;
            Run = true;
        }
   

        public void PararAlertas() => Run = false;

        public void AtualizaAlertaProdutos()
        {

            try
            {
                Produtos = GetProdutosEstoqueMinimo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static ConfiguracaoDeAlertas CarregarConfiguracoes()
        {
            ConfiguracaoDeAlertas result;
            try
            {
                string filename = GetFullPath();
                string json = File.ReadAllText(filename);

                if (json != string.Empty)
                    result = JsonConvert.DeserializeObject<ConfiguracaoDeAlertas>(json);
                else
                {
                    result = GetConfiguracoesPadrao();
                    SalvarConfiguracoes(result);
                }
            }
            catch (Exception ex)
            {
                result = GetConfiguracoesPadrao();
                SalvarConfiguracoes(result);
            }
            return result;
        }


        private static ConfiguracaoDeAlertas GetConfiguracoesPadrao()
        {
            return new ConfiguracaoDeAlertas { EmitirAlertas = true, QuantidadeMinima = 10 };
        }

        public static void SalvarConfiguracoes(ConfiguracaoDeAlertas obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            File.WriteAllText(GetFullPath(), json);
        }

        public static string GetFullPath()
        {

            string path = AppDomain.CurrentDomain.BaseDirectory + "Config.txt";

            return path;
        }

        public List<Produto.Produto> GetProdutosEstoqueMinimo()
        {
            List<Produto.Produto> result = new List<Produto.Produto>();

            NpgsqlCommand cmd = new NpgsqlCommand($"select * from sysgestao.tb_produto WHERE quantidade <= " + QuantidadeMinima + ";");
            foreach (DataRow row in PGAccess.ExecuteReader(cmd).Tables[0].Rows)
            {
                result.Add(new Produto.Produto(row));
            }
            return result;
        }

        public bool IsRun() => Run;
    }
}
