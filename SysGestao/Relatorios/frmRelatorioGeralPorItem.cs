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
    public partial class frmRelatorioGeralPorItem : frmDefault
    {
        public frmRelatorioGeralPorItem()
        {
            InitializeComponent();
        }

        private void frmRelatorioGeralPorItem_Load(object sender, EventArgs e)
        {

        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            GerarRelatorio();
        }

        private List<ItemSolicitacaoModel> GetItens(DateTime de, DateTime ate)
        {
            List<ItemSolicitacaoModel> result = new List<ItemSolicitacaoModel>();

            NpgsqlCommand cmd = new NpgsqlCommand($"select codigo_sku, variacao, I.quantidade FROM sysgestao.tb_produto as P" +
                $" INNER JOIN sysgestao.tb_item_solicitacao as I ON P.id_produto = I.id_produto" +
                $" INNER JOIN sysgestao.tb_solicitacao_produto as S ON S.id_solicitacao = I.id_solicitacao" +
                $" WHERE S.data_solicitacao >= to_timestamp('{de.ToString("dd/MM/yyyy")}', 'dd/MM/yyyy') " +
                $"AND S.data_solicitacao <= to_timestamp('{ate.ToString("dd/MM/yyyy")}', 'dd/MM/yyyy');");


            foreach (DataRow obj in PGAccess.ExecuteReader(cmd).Tables[0].Rows)
            {
                result.Add(new ItemSolicitacaoModel(obj));
            }

            if (result.Count > 0)
                result[0].PeriodoText = de.ToString("dd/MM/yyyy") + " até " + ate.ToString("dd/MM/yyyy");


            return result;
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

                    var itens = GetItens(de, ate);

                    if (itens.Count > 0)
                    {
                        //reportViewer1.Reset();
                        reportViewer1.LocalReport.DataSources.Clear();

                        reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetItemSolicitacao", itens));

                        reportViewer1.LocalReport.SetParameters(new List<ReportParameter>()
                        {
                           new ReportParameter("PeriodoSolicitacao", itens[0].PeriodoText)
                        });
                    }
                    reportViewer1.RefreshReport();
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

        private bool ValidaCampos()
        {
            return
                txtDe.MaskFull && txtAte.MaskFull;
        }
    }
}
