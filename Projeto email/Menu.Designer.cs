namespace Projeto_email
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.corpo = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novosEmailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(310, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 298);
            this.button1.TabIndex = 10;
            this.button1.Text = "Enviar para todos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // corpo
            // 
            this.corpo.Location = new System.Drawing.Point(7, 116);
            this.corpo.Name = "corpo";
            this.corpo.Size = new System.Drawing.Size(287, 241);
            this.corpo.TabIndex = 9;
            this.corpo.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Corpo do email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Título do email:";
            // 
            // titulo
            // 
            this.titulo.Location = new System.Drawing.Point(7, 59);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(287, 23);
            this.titulo.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novosEmailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(468, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novosEmailsToolStripMenuItem
            // 
            this.novosEmailsToolStripMenuItem.Name = "novosEmailsToolStripMenuItem";
            this.novosEmailsToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.novosEmailsToolStripMenuItem.Text = "Novos emails";
            this.novosEmailsToolStripMenuItem.Click += new System.EventHandler(this.novosEmailsToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 369);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.corpo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(484, 408);
            this.MinimumSize = new System.Drawing.Size(484, 408);
            this.Name = "Menu";
            this.Text = "Emails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private RichTextBox corpo;
        private Label label2;
        private Label label1;
        private TextBox titulo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem novosEmailsToolStripMenuItem;
    }
}