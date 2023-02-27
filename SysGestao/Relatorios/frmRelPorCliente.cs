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
        public PreSolicitacaoModel Solicitacao { get; }

        public frmRelPorCliente()
        {
            InitializeComponent();
        }

        public frmRelPorCliente(PreSolicitacaoModel solicitacao) : this()
        {
            Solicitacao = solicitacao;
        }


        public void AdicionaValor(List<PreSolicitacaoModel> result, PreSolicitacaoModel obj)
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
                if (Solicitacao != null)
                {

                    if (Solicitacao.Itens.Count > 0)
                    {
                        reportViewer1.LocalReport.DataSources.Clear();

                        reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DsItens", Solicitacao.Itens));


                        reportViewer1.LocalReport.SetParameters(new List<ReportParameter>()
                        {
                           new ReportParameter("PeriodoSolicitacao", $"Relatório gerado em: {DateTime.Now.ToString()}"),
                           new ReportParameter("NomeCliente", Solicitacao.Destinatario.Nome)
                        });


                        reportViewer1.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Não há itens para a solicitação selecionada!", "Buscar registros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Nenhuma solicitação selecionada!", "Erro ao gerar relatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível gerar o relatório!\r\n\r\n\r\n" + ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmRelPorCliente_Load(object sender, EventArgs e)
        {
            GerarRelatorio();
        }

        private void btnSair1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
