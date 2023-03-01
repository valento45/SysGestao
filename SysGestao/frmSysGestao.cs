using SysAux.Interfaces;
using SysAux.Response;
using SysAux.Util;
using SysAux.Util.Enums;
using SysGestao.Clientes;
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

        public frmSysGestao(bool autenticado)
        {
            this.autenticado = autenticado;


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
            frm.Show();

        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAlterarSenha frm = new frmAlterarSenha();

            frm.Show();

        }
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarProdutos frm = new frmConsultarProdutos();

            frm.Show();
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
            frm.Show();
        }

        private void solicitaçõesFinalizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarSolicitacoesFinalizadas frm = new frmConsultarSolicitacoesFinalizadas();
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
            AtivarTimerDataHora();
            lbUsuarioLogado.Text = Login.usuarioLogado.Usuario_;
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

        private void relatórioPorClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSolicitacoes frm = new frmSolicitacoes(PreSolicitacao.GetPreSolicitacao(0, true), true) { IsPreSolicitacao = true };
            frm.Show();
        }

        private void leituraDePlanilhasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmConfiguraLeituraPlanilhas frm = new frmConfiguraLeituraPlanilhas())
            {
                frm.ShowDialog();
            }
        }

        private void ImportDocumento(TipoDocumento tipo)
        {
            try
            {
                using (OpenFileDialog fil = new OpenFileDialog())
                {
                    fil.Title = "Buscar declaração de conteúdo";
                    fil.Filter = "Arquivo Excel (*.xlsx)|*.xlsx";
                    if (fil.ShowDialog() == DialogResult.OK)
                    {
                        int erros = 0;
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

                        IEnumerable<Solicitacao> solicitacoes = null;

                        if (tipo == TipoDocumento.DECLARACAO_CONTEUDO)
                            solicitacoes = XlsxFactory.ImportarXlsxSolicitacaoDeclaracaoConteudo(base64,
                                ConfiguracaoLeituras.GetDeclaracaoConteudo(), out erros);

                        else if (tipo == TipoDocumento.DANFE)
                            solicitacoes = XlsxFactory.ImportarXlsxSolicitacaoDANFESimplificada(base64,
                                ConfiguracaoLeituras.GetDanfe(), out erros);

                        foreach (var x in solicitacoes)
                        {
                            x.ArquivoOrigem = arquivo_origem;
                            PreSolicitacao.Inserir(x);
                        }

                        frmLoadingBar.CloseLoading();

                        MessageBox.Show("Importação realizada com sucesso! Verifique o painel de solicitações." + (erros > 0 ? string.Format("\r\n\r\nItens encontrados com erro: {0}. Por favor, verifique,", erros) : ""), "Importação realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (FileLoadException fileEx)
            {
                MessageBox.Show("Ocorreu um erro ao efetuar a leitura do arquivo !\r\n\r\n" + fileEx.Message,
                    "OPS!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Ocorreu um erro ao efetuar a leitura do arquivo !\r\n\r\n" + ex.Message,
                   "OPS!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro ao efetuar a leitura do arquivo !\r\n\r\nVerifique a configuração das colunas em: 'Solicitação de produto -> Configurações -> Leitura de planilhas '.\r\n\r\nSe Persistir, solicite " +
                    "suporte ao densevolvedor do sistema." + ex.Message,
                    "OPS!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void declaraçãoDeConteúdoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportDocumento(TipoDocumento.DECLARACAO_CONTEUDO);
        }

        private void relatórioPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmSolicitacoes frm = new frmSolicitacoes(SolicitacaoProduto.GetSolicitacao(0, true), true, true) { IsPreSolicitacao = false };

            frm.Show();
        }

        private void notaFiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConfiguracaoLeituras.GetDanfe() == null)
            {
                MessageBox.Show("Para poder usar este recurso é necessário que configure a leitura de colunas XLSX em: Solicitação de produto -> Configurações -> Leitura de planilhas.",
                    "Não foram localizadas configurações !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ImportDocumento(TipoDocumento.DANFE);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("HH:mm:ss\r\ndd/MM//yyyy");
            txtDate.TextAlign = HorizontalAlignment.Center;
        }

        private void AtivarTimerDataHora()
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar o sistema ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            using (frmCliente frm = new frmCliente())
                frm.ShowDialog();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void windowsMenu_Click(object sender, EventArgs e)
        {

        }

        private void contatoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            using (frmConsultarProdutos frm = new frmConsultarProdutos())
            {
                frm.ShowDialog();
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            using (frmCliente frm = new frmCliente())
            {
                frm.ShowDialog();
            }
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            using (frmConfiguraLeituraPlanilhas frm = new frmConfiguraLeituraPlanilhas())
            {
                frm.ShowDialog();
            }
        }
    }
}
