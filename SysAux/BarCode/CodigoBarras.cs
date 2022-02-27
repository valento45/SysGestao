using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarcodeLib.BarcodeXMLTableAdapters;
using BarcodeLib;
namespace SysAux.BarCode
{
    public class CodigoBarras
    {
        /// <summary>
        /// Gera código de barras no padrão C128, e retorna em base64
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static string GerarCodigo(string texto)
        {
            string base64;
            using (MemoryStream ms = new MemoryStream())
            {
                //A imagem é desenhada baseada no tamanho do texto
                using (Bitmap bitMap = new Bitmap(texto.Length * 40, 80))
                {                    
                    //O objeto Graphics é gerado para a imagem
                    using (Graphics graphics = Graphics.FromImage(bitMap))
                    {
                        graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                        graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                        //Usamos a fonte Barcode
                        Font oFontCode = new Font("Code 128", 28);
                        Font oFontText = new Font("Arial", 7);
                        PointF pointText = new PointF(5f, 1f);
                        PointF point = new PointF(10f, 10f);
                        //Um objeto White Brush é usado para preencher a imagem com a cor branca
                        SolidBrush whiteBrush = new SolidBrush(Color.White);
                        graphics.FillRectangle(whiteBrush, 0, 0, bitMap.Width, bitMap.Height);
                        //Um objeto Black Brush é usado para desenhar o codigo de barras
                        SolidBrush blackBrush = new SolidBrush(Color.Black);

                        graphics.DrawString(texto, oFontText, blackBrush, pointText);

                        //Escreve o codigo de barra na imagem
                        graphics.DrawString(texto, oFontCode, blackBrush, point);
                    }
                    //O Bitmap é salvo na Memory Stream.

                    bitMap.Save(ms, ImageFormat.Png);
                    base64 = Convert.ToBase64String(ms.ToArray());
                }
            }
            return base64;
        }

        public static string GerarBarCodeLib(string texto)
        {
            string base64 = string.Empty;
            using (MemoryStream ms = new MemoryStream())
            {
                Image codigoBarra = Barcode.DoEncode(TYPE.CODE128, texto, true, 200, 100);
                codigoBarra = new Bitmap(codigoBarra, new Size(200, 100));
                codigoBarra.Save(ms, ImageFormat.Png);
                base64 = Convert.ToBase64String(ms.ToArray());
            }
            return base64;
        }


        public static Image ConvertBase64ToImage(string base64)
        {
            if (base64 != string.Empty)
            {
                return Image.FromStream(new MemoryStream(Convert.FromBase64String(base64)));
            }
            else
                return null;
        }

        public static string ConvertImageToBase64(Image image)
        {
            if (image != null)
                using (MemoryStream m = new MemoryStream())
                {
                    //Salva na memória
                    image.Save(m, image.RawFormat);

                    // Convert byte[] to Base64 String
                    string base64String = Convert.ToBase64String(m.ToArray());
                    return base64String;
                }
            else
                return string.Empty;
        }
        public static string GetDirectory()
        {
            return AppDomain.CurrentDomain.BaseDirectory + @"codigosBar\produtos\";

        }
    }
}
