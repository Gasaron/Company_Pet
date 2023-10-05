using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Company_Pet
{
    public partial class Entrar : Form
    {
        public Entrar()
        {
            InitializeComponent();
        }

        private void textBox1_Nome_TextChanged(object sender, EventArgs e)
        {
            string nome = Nome.Text;

        }

        private void Senha_TextChanged(object sender, EventArgs e)
        {
            string senha = Senha.Text;
            Senha.PasswordChar = '●';

        }

        private void button_voltar_2_Click(object sender, EventArgs e)
        {
            Entrar_Cadastrar voltar = new Entrar_Cadastrar();
            this.Hide();
            voltar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nome.Text) || string.IsNullOrWhiteSpace(Senha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Menu voltar = new Menu();
                this.Hide();
                voltar.ShowDialog();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu voltar = new Menu();
            this.Hide();
            voltar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu voltar = new Menu();
            this.Hide();
            voltar.ShowDialog();
        }
    }
}
