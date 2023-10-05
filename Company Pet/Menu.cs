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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            Entrar_Cadastrar voltar2 = new Entrar_Cadastrar();
            this.Hide();
            voltar2.ShowDialog();
        }

        private void button_Plantao_Click(object sender, EventArgs e)
        {
            Plantao plantao = new Plantao();
            this.Hide();
            plantao.ShowDialog();
        }

        private void button_Loja_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja();
            this.Hide();
            loja.ShowDialog();
        }

        private void button_Consulta_Click(object sender, EventArgs e)
        {
            Consultar consulta = new Consultar();
            this.Hide(); 
            consulta.ShowDialog();
        }

        private void button_Planos_Click(object sender, EventArgs e)
        {
            Planos plano = new Planos();
            this.Hide();
            plano.ShowDialog();
        }

        private void button_Avisos_Click(object sender, EventArgs e)
        {
            Avisos avisos = new Avisos();
            this.Hide(); 
            avisos.ShowDialog();
        }

        private void button_Domicilio_Click(object sender, EventArgs e)
        {
            Domicilio domicilio = new Domicilio();
            this.Hide();
            domicilio.ShowDialog();
        }
    }
}
