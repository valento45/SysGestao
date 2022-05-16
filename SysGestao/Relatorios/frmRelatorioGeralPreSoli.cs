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
    public partial class frmRelatorioGeralPreSoli : frmDefault
    {
        public frmRelatorioGeralPreSoli()
        {
            InitializeComponent();
        }

        private PreSolicitacaoModel GetItensSolicitacao(DateTime de, DateTime ate)
        {
            PreSolicitacaoModel result = new PreSolicitacaoModel();
         
            NpgsqlCommand cmd = new NpgsqlCommand($"select codigo_sku, variacao, SUM(quantidade) as quantidade FROM sysgestao.tb_item_pre_solicitacao as I" +
                $" INNER JOIN sysgestao.tb_pre_solicitacao_produto as S ON S.id_pre_solicitacao = I.id_pre_solicitacao" +
                $" WHERE S.data_solicitacao >= to_timestamp('{de.ToString("dd/MM/yyyy")}', 'dd/MM/yyyy')" +
                $" AND S.data_solicitacao <= to_timestamp('{ate.ToString("dd/MM/yyyy")}', 'dd/MM/yyyy')" +
                $" GROUP BY codigo_sku, variacao");


            foreach (DataRow obj in PGAccess.ExecuteReader(cmd).Tables[0].Rows)
            {
                result.Itens.Add(new ItemSolicitacaoModel(obj));
            }

            if (result.Itens.Count > 0)
                result.PeriodoText = de.ToString("dd/MM/yyyy") + " até " + ate.ToString("dd/MM/yyyy");

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

                    var obj = GetItensSolicitacao(de, ate);

                    if (obj.Itens.Count > 0)
                    {
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetItemSolicitacao", obj.Itens));

                        reportViewer1.LocalReport.SetParameters(new List<ReportParameter>()
                        {
                           new ReportParameter("PeriodoSolicitacao", obj.PeriodoText)
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

        private bool ValidaCampos()
        {
            return
                txtDe.MaskFull && txtAte.MaskFull;
        }



        private void btNovo_Click(object sender, EventArgs e)
        {
            GerarRelatorio();
        }          
    }
}
