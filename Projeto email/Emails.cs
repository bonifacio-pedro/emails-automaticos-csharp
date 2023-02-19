using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_email
{
    public partial class Emails : Form
    {
        public Emails()
        {
            InitializeComponent();
            EncheTabela();
        }

        public void EncheTabela()
        {
            dt.Rows.Clear();
            foreach(string email in Menu.emails)
            {
                dt.Rows.Add(email);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (emailNovo.Text.Contains(".com") && emailNovo.Text.Contains("@"))
            {
                Menu.emails.Add(emailNovo.Text);
                EncheTabela();
            }
            else
            {
                MessageBox.Show("Insira um email válido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
