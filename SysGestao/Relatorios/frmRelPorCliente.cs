using Access;
using Microsoft.Reporting.WinForms;
using Npgsql;
using SysGestao.Relatorios.DataSourcesModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestao.Relatorios
{
    public partial class frmRelPorCliente : frmDefault
    {
        public frmRelPorCliente()
        {
            InitializeComponent();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {

        }

        private bool ValidaCampos()
        {
            return
                txtDe.MaskFull && txtAte.MaskFull;
        }

        private List<SolicitacaoModel> GetItens(DateTime de, DateTime ate)
        {
            List<SolicitacaoModel> result = new List<SolicitacaoModel>();

            NpgsqlCommand cmd = new NpgsqlCommand($"select codigo_sku, variacao, I.quantidade FROM sysgestao.tb_produto as P" +
                $" INNER JOIN sysgestao.tb_item_solicitacao as I ON P.id_produto = I.id_produto" +
                $" INNER JOIN sysgestao.tb_solicitacao_produto as S ON S.id_solicitacao = I.id_solicitacao" +
                $" WHERE S.data_solicitacao >= to_timestamp('{de.ToString("dd/MM/yyyy")}', 'dd/MM/yyyy') " +
                $"AND S.data_solicitacao <= to_timestamp('{ate.ToString("dd/MM/yyyy")}', 'dd/MM/yyyy');");


            foreach (DataRow obj in PGAccess.ExecuteReader(cmd).Tables[0].Rows)
            {
                var solicitacao = new SolicitacaoModel(obj);

                AdicionaValor(result, solicitacao);
            }

            return result;
        }

        public void AdicionaValor(List<SolicitacaoModel> result, SolicitacaoModel obj)
        {
            if (result.Count(x => x.IdSolicitacao == obj.IdSolicitacao) > 0)
            {
                var update = result.FirstOrDefault(x => x.IdSolicitacao == obj.IdSolicitacao) ?? throw new Exception("Erro ao instanciar o objeto");

                foreach (var x in obj.Itens)
                    update.Itens.Add(x);
            }
            else
            {
                result.Add(obj);
            }
        }


        private void GerarRelatorio()
        {
            try
            {
                if (ValidaCampos())
                {
                    DateTime de, ate;
                    de = Convert.ToDateTime(txtDe.Text);
                    ate = Convert.ToDateTime(txtAte.Text);

                    var obj = GetItens(de, ate);

                    if (obj.Count > 0)
                    {
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetItemSolicitacao", obj));

                        reportViewer1.LocalReport.SetParameters(new List<ReportParameter>()
                        {
                           new ReportParameter("PeriodoSolicitacao", de.ToString("dd/MM/yyyy") + " até " + ate.ToString("dd/MM/yyyy"))
                        });
                        reportViewer1.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Não há resultados para o período informado!", "Buscar registros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Preencha corretamente o período!", "Validação de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível gerar o relatório!\r\n\r\n\r\n" + ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
