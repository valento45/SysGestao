using Access;
using Npgsql;
using SysAux.Response;
using SysGestao_BE.Produto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao.Relatorios.DataSourcesModels
{
    public class ItemSolicitacaoModel
    {
        public int IdItem { get; set; }
        public int IdProduto { get; set; }
        public string CodigoSKU { get; set; }
        public string Variacao { get; set; }
        public int Quantidade { get; set; }
        public string PeriodoText { get; set; }
        public string Localizacao { get; set; }
        public ItemSolicitacaoModel()
        {

        }
        public ItemSolicitacaoModel(DataRow row)
        {
            CodigoSKU = row["codigo_sku"].ToString();
            Variacao = row["variacao"].ToString();
            Quantidade = row["quantidade"]?.ToString() != string.Empty ? Convert.ToInt32(row["quantidade"].ToString()) : int.MinValue;
   
        }

        public static List<ItemSolicitacaoModel> GetByIdSolicitacao(int id)
        {
            List<ItemSolicitacaoModel> result = new List<ItemSolicitacaoModel>();
            NpgsqlCommand cmd = new NpgsqlCommand($"SELECT * FROM sysgestao.tb_item_pre_solicitacao WHERE id_pre_solicitacao = {id};");

            foreach (DataRow dr in PGAccess.ExecuteReader(cmd).Tables[0].Rows)
            {
                var obj = new ItemSolicitacaoModel(dr);
                obj.Localizacao = Produto.GetLocalizacaoPorSKU(obj.CodigoSKU);
                result.Add(obj);
            }
            return result;

           
        }


        public static List<ItemSolicitacaoModel> ConvertObj(List<ProdutoResponse> produtos)
        {            
            if (produtos != null)
            {
                List<ItemSolicitacaoModel> result = new List<ItemSolicitacaoModel>();
                foreach (var produto in produtos)
                {                    
                    result.Add(new ItemSolicitacaoModel
                    {
                        CodigoSKU = produto.CodigoSKU,
                        Variacao = produto.Variacao,
                        Quantidade = produto.Quantidade,
                        IdProduto = produto.Id
                    });
                }                
                return result;
            }
            else
                return null;
        }
    }
}
