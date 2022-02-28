using SysAux.BarCode;
using SysGestao_BE.Auxx;
using SysGestao_BE.Impressao.Interrfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestao.Produtos
{
    public partial class frmConfiguraImpressao : frmDefault
    {
        public int QuantidadeEtiquetas { get; set; }
        private IPrintObjeto _printObjeto;

        public frmConfiguraImpressao(IPrintObjeto print)
        {
            InitializeComponent();
            _printObjeto = print;
        }

        private void btnMarcaDesmarca_Click(object sender, EventArgs e)
        {
            try
            {
                SetQuantidade();
                PrintEtiquetas();
                MessageBox.Show("Importação das etiquetas realizado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro! Por favor tente novamente.\r\n\r\n\r\nDetalhamento: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.Retry;
            }
            finally
            {
                this.Close();
            }
        }

        private void SetQuantidade()
        {
            int _quantidade;
            int.TryParse(txtQuantidade.Value.ToString(), out _quantidade);
            QuantidadeEtiquetas = _quantidade;
        }

        private void PrintEtiquetas()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ConverteImage);
            pd.Print();
        }

        private void ConverteImage(object o, PrintPageEventArgs e)
        {
            int pontoImageX = 0;
            int pontoImageY = 67;
            int pontoTextX = 10;
            int pontoTextY = 30;

            int quantidade = 0;
            //  e.PageSettings.PaperSize = new PaperSize($"impressao {DateTime.Now}", 150, 100);

            int quantidadeSelecionada = QuantidadeEtiquetas * _printObjeto.EtiquetasPrint.Count;
            if(quantidadeSelecionada > 18)
            {
                MessageBox.Show("Número de etiquetas excedido! \r\n\r\n\r\n" +
                    "Por favor, selecione apenas 18 etiquetas por vez, a impressão será concluída.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Font fontPrint = new Font(new FontFamily("Microsoft Sans Serif"), 10.2f);
            for (int qtd = 0; qtd < QuantidadeEtiquetas; qtd++)
            {
                foreach (var x in _printObjeto.EtiquetasPrint)
                {
                    quantidade++;
                    string texto = $"{x.sku.ToUpper()} {x.Variacao.ToUpper()}".QuebraLinha(22);
                    var bytes = Convert.FromBase64String(CodigoBarras.GerarBarCodeLib(x.CodigoBarrasText));
                    using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        Image img = Image.FromStream(ms);
                        Point pImage = new Point(pontoImageX, pontoImageY);
                        Point pText = new Point(pontoTextX, pontoTextY);
                        e.Graphics.DrawImage(img, pImage);
                        e.Graphics.DrawString(texto, fontPrint, Brushes.Black, pText);
                    }

                    //Posiciona o código de barras
                    if (pontoImageX < 300)
                    {
                        pontoImageX += 220;//400;//220;
                        pontoTextX += 220;//400;//220;
                    }
                    else
                    {
                        pontoImageX = 0;
                        pontoTextX = 10;
                        pontoImageY += 170;//250;//150;
                        pontoTextY += 170;//250;//150;
                    }
                    if (quantidade == 18)
                        break;
                }
                if (quantidade == 18)
                    break;
            }
        }
    }
}
