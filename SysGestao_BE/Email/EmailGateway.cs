using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao.Email
{
    public class EmailGateway
    {


        public ConfigurationEmail ConfigurationEmail { get; set; }

        public EmailGateway(ConfigurationEmail configurationEmail)
        {
            ConfigurationEmail = configurationEmail;

            if (ConfigurationEmail == null)
            {
                ConfigurationEmail = new ConfigurationEmail()
                {
                    Email = "errojoiasmrx@gmail.com",
                    Senha = "erro1234"
                };
            }
        }


        public string EnviaEmailComAnexo(EmailModel email)
        {
            try
            {
                SmtpClient EmailObj = new SmtpClient();
                EmailObj.Credentials = new NetworkCredential(ConfigurationEmail.Email, ConfigurationEmail.Senha);
                EmailObj.Host = ConfigurationEmail.Host;
                EmailObj.Port = ConfigurationEmail.Port;
                EmailObj.EnableSsl = false;
                EmailObj.UseDefaultCredentials = true;
                EmailObj.DeliveryMethod = SmtpDeliveryMethod.Network;

                MailMessage msg = new MailMessage(ConfigurationEmail.Email, email.Destinatario, email.Assunto,
                    email.Mensagem);

                if (email?.Anexos?.Any() ?? false)
                {
                    foreach (var anx in email.Anexos)
                    {
                        Attachment anexo = new Attachment(anx, MediaTypeNames.Application.Octet);
                        msg.Attachments.Add(anexo);
                    }
                }
                EmailObj.Send(msg);

                return "Mensagem enviada com sucesso!";
            }

            
            catch (Exception ex)
            {
                return ex.Message + "\r\n" + (ex.InnerException != null ? ex.InnerException.Message : "");
            }
        }
    }
}
