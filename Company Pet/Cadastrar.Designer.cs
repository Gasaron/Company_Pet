namespace Company_Pet
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button_Cadastro = new Button();
            button_voltar_1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(240, 240, 240);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(371, 373);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(549, 16);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(240, 240, 240);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(368, 432);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(552, 16);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(240, 240, 240);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Location = new Point(371, 499);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(549, 16);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(240, 240, 240);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Cursor = Cursors.IBeam;
            textBox4.Location = new Point(352, 562);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(568, 16);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(240, 240, 240);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Cursor = Cursors.IBeam;
            textBox5.Location = new Point(352, 624);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(568, 16);
            textBox5.TabIndex = 4;
            // 
            // button_Cadastro
            // 
            button_Cadastro.BackColor = Color.Transparent;
            button_Cadastro.BackgroundImageLayout = ImageLayout.Stretch;
            button_Cadastro.Cursor = Cursors.Hand;
            button_Cadastro.FlatAppearance.BorderSize = 0;
            button_Cadastro.FlatStyle = FlatStyle.Flat;
            button_Cadastro.Location = new Point(555, 690);
            button_Cadastro.Name = "button_Cadastro";
            button_Cadastro.Size = new Size(118, 41);
            button_Cadastro.TabIndex = 5;
            button_Cadastro.UseVisualStyleBackColor = false;
            button_Cadastro.Click += button_Cadastro_Click;
            // 
            // button_voltar_1
            // 
            button_voltar_1.BackColor = Color.Transparent;
            button_voltar_1.Cursor = Cursors.Hand;
            button_voltar_1.FlatAppearance.BorderSize = 0;
            button_voltar_1.FlatStyle = FlatStyle.Flat;
            button_voltar_1.Location = new Point(-1, -1);
            button_voltar_1.Name = "button_voltar_1";
            button_voltar_1.Size = new Size(80, 80);
            button_voltar_1.TabIndex = 6;
            button_voltar_1.UseVisualStyleBackColor = false;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 761);
            Controls.Add(button_voltar_1);
            Controls.Add(button_Cadastro);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Company Pet";
            Load += Cadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button_Cadastro;
        private Button button_voltar_1;
    }
}