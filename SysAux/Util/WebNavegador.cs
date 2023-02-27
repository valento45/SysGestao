using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysAux.Util
{
    public  class WebNavegador
    {
        public  static WebBrowser AbrirPaginaWeb(string url)
        {
            WebBrowser wb = new WebBrowser();
            wb.Navigate(url);

            return wb;
        }
    }
}
