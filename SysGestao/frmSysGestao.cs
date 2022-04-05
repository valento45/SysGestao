using SysAux.Interfaces;
using SysAux.Response;
using SysAux.Util;
using SysGestao.Produtos;
using SysGestao.Produtos.ConfigAlertasEstoque;
using SysGestao.Relatorios;
using SysGestao.Usuarios;
using SysGestao.Util;
using SysGestao_BE;
using SysGestao_BE.AlertasEstoque;
using SysGestao_BE.Produto;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestao
{
    public partial class frmSysGestao : Form
    {
        private bool autenticado;
        private ConfiguracaoDeAlertas _configuracaoAlertas;

        public delegate void DelegateExibirProdutosEstoqueMin(List<Produto> produtos);

        public frmSysGestao()
        {
            InitializeComponent();
            //Irá executar o login apenas se for em produção
            if (!autenticado)
            {
                AutenticarLogin();
            }
        }

        private void AutenticarLogin()
        {
            using (frmLogin frm = new frmLogin())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    autenticado = true;
                    lbUsuarioLogado.Text = Login.usuarioLogado.Usuario_;
                }
                else
                    Process.GetCurrentProcess().Kill();
            }
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

                    string arquivo_origem = new FileInfo(fil.FileName).Name;
                    if (PreSolicitacao.ArquivoJaImportado(arquivo_origem))
                    {
                        if (MessageBox.Show($"O arquivo {arquivo_origem} já foi importado. Deseja importá-lo novamente ?", "Atenção!",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.No)
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

        private void solicitaçõesFinalizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarSolicitacoesFinalizadas frm = new frmConsultarSolicitacoesFinalizadas();
            frm.MdiParent = this;
            if (frm.Visible)
                frm.Focus();
            else
                frm.Show();
        }

        private void configuraçãoDeAlertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmConfigurarAlertaEstoque frm = new frmConfigurarAlertaEstoque(_configuracaoAlertas))
            {
                frm.ShowDialog();
                ConfiguraAlertasEstoque();
            }
        }

        private void frmSysGestao_Load(object sender, EventArgs e)
        {

        }


        private void ExibeProdutosEstoqueMin(List<Produto> produtos)
        {
            if (produtos?.Count > 0)
            {
                pnlAlertasEstoque.Visible = true;
            }
            else
            {
                pnlAlertasEstoque.Visible = false;
            }
        }

        private void ConfiguraAlertasEstoque()
        {
            _configuracaoAlertas = ConfiguracaoDeAlertas.CarregarConfiguracoes();

            if (_configuracaoAlertas.EmitirAlertas)
            {
                IniciaDisparaAlerta();
            }
        }

        private void IniciaDisparaAlerta()
        {
            new Thread(() =>
            {
                DelegateExibirProdutosEstoqueMin callBack = ExibeProdutosEstoqueMin;

                while (_configuracaoAlertas.IsRun())
                {
                    _configuracaoAlertas.AtualizaAlertaProdutos();
                    Invoke(callBack, _configuracaoAlertas.Produtos);
                    Thread.Sleep(10000);
                }

            }).Start();
        }

        private void btFecharPnlAlerta_Click(object sender, EventArgs e)
        {
            if (chkNaoMostrarNovamente.Checked)
                _configuracaoAlertas.PararAlertas();

            pnlAlertasEstoque.Visible = false;
        }

        private void btVerProdutosAlertaEstoque_Click(object sender, EventArgs e)
        {
            using (frmVerProdutosEstoqueMin frm = new frmVerProdutosEstoqueMin(_configuracaoAlertas))
            {
                frm.ShowDialog();
                ExibeProdutosEstoqueMin(_configuracaoAlertas.Produtos);
            }
        }

        private void frmSysGestao_Shown(object sender, EventArgs e)
        {
            ConfiguraAlertasEstoque();
        }

        private void frmSysGestao_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void relatórioGeralToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void relatórioGeralToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            using (frmRelatorioGeralPorItem frm = new frmRelatorioGeralPorItem())
            {
                frm.ShowDialog();
            }
        }

        private void relatórioGeralToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (frmRelatorioGeralPreSoli frm = new frmRelatorioGeralPreSoli())
            {
                frm.ShowDialog();
            }
        }
    }
}
