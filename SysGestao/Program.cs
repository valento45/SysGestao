using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysAux.LOGS;
using SysGestao.Authorization;
using SysGestao.EventosFolder;
using SysGestao_BE.Autenticacao;
using SysAux.Util;
using System.Windows.Forms.Design;
using System.Runtime.InteropServices;

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
            Application.ThreadException += Application_ThreadException;
           

            StartAplicacao();
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            frmErro.Erro_Inesperado(e.Exception, ExceptionLog.Insert(e.Exception, "Program.cs"));
        }

        static void StartAplicacao()
        {
            var licensa = Licensa.ObterLicensa();

            if (licensa != null)
            {
                if (licensa.IsValido())
                {
                    Licensa.DadosLicensa = licensa;
                    Application.Run(new frmLogin());
                }
                else if (MessageBox.Show($"Sua Licença foi expirada em {licensa.DataExpiracao.ToString("dd/MM/yyyy HH:mm:ss")} " +
                    $"\r\n\r\nDeseja atualizar sua licença agora ? ",
                    "Validação de licença",  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (frmLicense frm = new frmLicense())
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            Application.Run(new frmLogin());
                        }
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Não foram localizados dados de licença! \r\n\r\nDeseja entrar com uma nova licença ?", "Licença não encontrada!!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (frmLicense frm = new frmLicense())
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            Application.Run(new frmLogin());
                        }
                    }
                }
            }
        }
    }
}
