using System;
using System.Windows.Forms;

namespace Company_Pet
{
    public partial class Form1_Inicial : Form
    {
        private System.Windows.Forms.Timer timer1;

        public Form1_Inicial()
        {
            InitializeComponent();

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 2000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            AbrirForm2();
            this.Hide();
        }

        private void AbrirForm2()
        {
            Form2 form2 = new Form2();
            form2.FormClosed += Form2_FormClosed;
            form2.Show();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
