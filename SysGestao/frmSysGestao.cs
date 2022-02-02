using SysAux.Interfaces;
using SysAux.IOPdf;
using SysAux.Response;
using SysAux.Util;
using SysGestao.Produtos;
using SysGestao.Usuarios;
using SysGestao.Util;
using SysGestao_BE.SolicitacaoProdut;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestao
{
    public partial class frmSysGestao : Form
    {
        private int childFormNumber = 0;
        private bool autenticado;
        public frmSysGestao()
        {
            InitializeComponent();
#if (!DEBUG)//Irá executar o login apenas se for em produção
            using (frmLogin frm = new frmLogin())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    autenticado = true;
                }
                else
                    Process.GetCurrentProcess().Kill();

            }        
#endif
        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarProduto frm = new frmCadastrarProduto();
            frm.MdiParent = this;
            if (frm.Visible)
                frm.Focus();
            else
                frm.Show();

        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAlterarSenha frm = new frmAlterarSenha();
            frm.MdiParent = this;
            if (frm.Visible)
                frm.Focus();
            else
                frm.Show();

        }
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarProdutos frm = new frmConsultarProdutos();
            frm.MdiParent = this;
            if (frm.Visible)
                frm.Focus();
            else
                frm.Show();
        }

        private void importaçãoPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fil = new OpenFileDialog())
            {
                fil.Title = "Buscar declaração de conteúdo";
                fil.Filter = "Arquivo Excel (*.xlsx)|*.xlsx";
                if (fil.ShowDialog() == DialogResult.OK)
                {                 
                    int erros;
                    string base64 = FilesMetodosUtil.ConvertFileToBase64(fil.FileName);

                    string arquivo_origem =  new FileInfo(fil.FileName).Name;
                    if (PreSolicitacao.ArquivoJaImportado(arquivo_origem))
                    {
                        if (MessageBox.Show($"O arquivo {arquivo_origem} já foi importado. Deseja importá-lo novamente ?", "Atenção",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.No)
                        {
                            return;
                        }
                    }
                  
                    frmLoadingBar.IniciarLoading("Carregando declaração de conteúdo...");
                   
                    var solicitacoes = XlsxFactory.ImportarXlsxSolicitacao(base64, out erros);

                    foreach (var x in solicitacoes)
                    {
                        x.ArquivoOrigem = arquivo_origem;
                        PreSolicitacao.Inserir(x);
                    }

                    frmLoadingBar.CloseLoading();

                    MessageBox.Show("Importação realizada com sucesso! Verifique o painel de solicitações." + (erros > 0 ? string.Format("\r\n\r\nItens encontrados com erro: {0}. Por favor, verifique,", erros) : ""), "Importação realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    #region OLD
                    /*string textoPdf = PdfLeitor.ExtrairTexto(fil.FileName);
                    int quantidadeDeclaracoes = PdfLeitor.CountDeclaracaoInTextoPDF(textoPdf);

                    List<Solicitacao> solicitacoes = new List<Solicitacao>();
                    
                    for (int i = 0; i < quantidadeDeclaracoes; i++)
                    {
                        string textoRetorno;

                        var Destinatario = PdfLeitor.GetDestinatarioNomeFromText(textoPdf, out textoRetorno);
                        var produtos = PdfLeitor.GetProdutosFromText(textoPdf, out textoRetorno);

                        solicitacoes.Add(new Solicitacao
                        {
                            Destinatario = Destinatario,
                            Produtos = produtos.ToList()
                        });
                    }*/
                    #endregion
                }
            }
        }

        private void sairtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar o sistema ?", "Encerrando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void consultarOrdensToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void préSolicitaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSolicitacoes frm = new frmSolicitacoes(PreSolicitacao.GetPreSolicitacao());
            frm.MdiParent = this;
            if (frm.Visible)
                frm.Focus();
            else
                frm.Show();
        }
    }
}
