using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysAux.LOGS;
using SysGestao.EventosFolder;

namespace SysGestao
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frmSysGestao());
        }

        static void  Application_ThreadException (object sender, ThreadExceptionEventArgs e)
        {
            frmErro.Erro_Inesperado(e.Exception, ExceptionLog.Insert(e.Exception, "Program.cs"));
        }
    }
}
