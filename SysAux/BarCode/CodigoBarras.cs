using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAux.BarCode
{
    public class CodigoBarras
    {
        /// <summary>
        /// Gera código de barras no padrão C128
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static string GerarCodigo(string texto)
        {
            //TextBox teste = new TextBox();
            //teste.Text = texto;
            //teste.Font = new Font("Code 128", 20);
            //string codeBar = _produto.CodigoBarras;
            //MessageBox.Show("Código de barras gerado: " + codeBar);

            string pathfilename;
            using (MemoryStream ms = new MemoryStream())
            {
                //A imagem é desenhada baseada no tamanho do texto
                using (Bitmap bitMap = new Bitmap(texto.Length * 40, 80))
                {
                    //O objeto Graphics é gerado para a imagem
                    using (Graphics graphics = Graphics.FromImage(bitMap))
                    {
                        //Usamos a fonte Barcode
                        Font oFont = new Font("Code 128", 80);
                        PointF point = new PointF(2f, 2f);
                        //Um objeto White Brush é usado para preencher a imagem com a cor branca
                        SolidBrush whiteBrush = new SolidBrush(Color.White);
                        graphics.FillRectangle(whiteBrush, 0, 0, bitMap.Width, bitMap.Height);
                        //Um objeto Black Brush é usado para desenhar o codigo de barras
                        SolidBrush blackBrush = new SolidBrush(Color.Black);
                        graphics.DrawString("*" + texto + "*", oFont, blackBrush, point);
                    }
                    //O Bitmap é salvo na Memory Stream.
                   // pathfilename = GetDirectory() + $"{texto}.png";
                    bitMap.Save(ms , ImageFormat.Png);
                    pathfilename = Convert.ToBase64String(ms.ToArray());
                }
            }
            return pathfilename;
        }
        public static string GetDirectory()
        {
            return AppDomain.CurrentDomain.BaseDirectory + @"codigosBar\produtos\";

        }
    }
}
