using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_email
{
    internal class Smtp
    {
        public static void Cliente(ref SmtpClient client, string email, string senha)
        {
            client = new SmtpClient();
            client.Host = "smtp.office365.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(email, senha);
        }
    }
}
