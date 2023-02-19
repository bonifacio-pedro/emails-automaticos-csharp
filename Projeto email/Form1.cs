using System.Net.Mail;

namespace Projeto_email
{
    public partial class Form1 : Form
    {
        public static string emailEnvio;
        public static string senhaEnvio;
        public static SmtpClient cliente;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!email.Text.Contains("@") && !email.Text.Contains("."))
            {
                MessageBox.Show("Insira um email válido!","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if(!email.Text.Contains("outlook") && !email.Text.Contains("hotmail"))
                {
                    MessageBox.Show("Insira um email microsoft!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        Smtp.Cliente(ref cliente, email.Text, senha.Text);

                        Menu menu = new Menu();
                        menu.Name = "menuForm";
                        emailEnvio = email.Text;
                        senhaEnvio = senha.Text;

                        this.Hide();
                        menu.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao conectar! " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}