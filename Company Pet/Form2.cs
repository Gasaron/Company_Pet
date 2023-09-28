using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company_Pet
{
    public partial class Entrar_Cadastrar : Form
    {
        public Entrar_Cadastrar()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrar_Cadastrar));
            this.button_Entrar = new System.Windows.Forms.Button();
            this.button_Cadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Entrar
            // 
            this.button_Entrar.BackColor = System.Drawing.Color.Transparent;
            this.button_Entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Entrar.FlatAppearance.BorderSize = 0;
            this.button_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Entrar.Location = new System.Drawing.Point(294, 574);
            this.button_Entrar.Name = "button_Entrar";
            this.button_Entrar.Size = new System.Drawing.Size(290, 76);
            this.button_Entrar.TabIndex = 0;
            this.button_Entrar.UseVisualStyleBackColor = false;
            // 
            // button_Cadastro
            // 
            this.button_Cadastro.BackColor = System.Drawing.Color.Transparent;
            this.button_Cadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Cadastro.FlatAppearance.BorderSize = 0;
            this.button_Cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cadastro.ForeColor = System.Drawing.Color.Transparent;
            this.button_Cadastro.Location = new System.Drawing.Point(605, 574);
            this.button_Cadastro.Name = "button_Cadastro";
            this.button_Cadastro.Size = new System.Drawing.Size(290, 76);
            this.button_Cadastro.TabIndex = 1;
            this.button_Cadastro.UseVisualStyleBackColor = false;
            // 
            // Entrar_Cadastrar
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.button_Cadastro);
            this.Controls.Add(this.button_Entrar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Entrar_Cadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Pet";
            this.Load += new System.EventHandler(this.Entrar_Cadastrar_Load);
            this.ResumeLayout(false);

        }

        private Button button_Entrar;
        private Button button_Cadastro;

        private void Entrar_Cadastrar_Load(object sender, EventArgs e)
        {

        }
    }
}
