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

        private void Entrar_Carregar_Load(object sender, EventArgs e)
        {

        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            Entrar entrar = new Entrar();
            this.Hide();
            entrar.ShowDialog();

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            Cadastro entrar = new Cadastro();
            this.Hide();
            entrar.Show();
        }

        private void Entrar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
