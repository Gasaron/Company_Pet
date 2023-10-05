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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }
        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string senha = Senha.Text;
            Senha.PasswordChar = '●';
        }

        private void button_Cadastro_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nome.Text) || string.IsNullOrWhiteSpace(Senha.Text) || string.IsNullOrWhiteSpace(Email.Text) || string.IsNullOrWhiteSpace(CEP.Text) || string.IsNullOrWhiteSpace(CPF.Text))
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

        private void CPF_TextChanged(object sender, EventArgs e)
        {
            string cpfDigitado = CPF.Text.Replace(".", "").Replace("-", "");

            if (cpfDigitado.Length == 11)
            {
                string cpfFormatado = $"{cpfDigitado.Substring(0, 3)}.{cpfDigitado.Substring(3, 3)}.{cpfDigitado.Substring(6, 3)}-{cpfDigitado.Substring(9)}";
                CPF.Text = cpfFormatado;
            }
            else
            {

            }
        }

        private void button_voltar_1_Click(object sender, EventArgs e)
        {
            Entrar_Cadastrar voltar = new Entrar_Cadastrar();
            this.Hide();
            voltar.ShowDialog();
        }
    }
}
