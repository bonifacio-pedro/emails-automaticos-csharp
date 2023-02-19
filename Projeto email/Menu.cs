using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_email
{
    
    public partial class Menu : Form
    {
        public static List<string> emails = new List<string>();
        public Menu()
        {
            InitializeComponent();
        }

        private void novosEmailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emails emailsForm = (Emails)Application.OpenForms["EmailsForm"];
            if(emailsForm == null)
            {
                emailsForm = new Emails();
                emailsForm.Name = "EmailsForm";
                emailsForm.Show();
            }
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(titulo.Text != "" && corpo.Text != "")
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(Form1.emailEnvio);

                try
                {
                    if(emails.Count > 0)
                    {
                        foreach (string email in emails)
                        {
                            msg.To.Add(email);
                        }
                        msg.Subject = titulo.Text;
                        msg.Body = corpo.Text;
                        msg.IsBodyHtml = false;
                        Form1.cliente.Send(msg);
                        MessageBox.Show("Emails enviados com sucesso", "Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception("Adicione emails para enviar.");
                    }
                }
                catch (SmtpException ex)
                {
                    MessageBox.Show("Tivemos um erro de conexão, verifique seu login.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Insira um título e/ou corpo válido(s)!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
