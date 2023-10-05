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
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }

        private void button_Voltar_Click(object sender, EventArgs e)
        {
            Menu voltar= new Menu();
            this.Hide();
            voltar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agendamento agendar = new Agendamento();
            this.Hide();
            agendar.ShowDialog();
        }
    }
}
