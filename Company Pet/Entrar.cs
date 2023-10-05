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
        }

        private void button_voltar_2_Click(object sender, EventArgs e)
        {
            Entrar_Cadastrar voltar = new Entrar_Cadastrar();
            this.Hide();
            voltar.Show();
        }
    }
}
