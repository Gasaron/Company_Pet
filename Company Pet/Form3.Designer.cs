namespace Company_Pet
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            textBox1_Nome = new TextBox();
            textBox2_Senha = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox1_Nome
            // 
            textBox1_Nome.BackColor = Color.FromArgb(240, 240, 240);
            textBox1_Nome.BorderStyle = BorderStyle.None;
            textBox1_Nome.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1_Nome.Location = new Point(221, 374);
            textBox1_Nome.Name = "textBox1_Nome";
            textBox1_Nome.Size = new Size(779, 36);
            textBox1_Nome.TabIndex = 0;
            // 
            // textBox2_Senha
            // 
            textBox2_Senha.BackColor = Color.FromArgb(240, 240, 240);
            textBox2_Senha.BorderStyle = BorderStyle.None;
            textBox2_Senha.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2_Senha.Location = new Point(221, 465);
            textBox2_Senha.Name = "textBox2_Senha";
            textBox2_Senha.Size = new Size(779, 36);
            textBox2_Senha.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(497, 558);
            button1.Name = "button1";
            button1.Size = new Size(189, 53);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(469, 627);
            button2.Name = "button2";
            button2.Size = new Size(247, 32);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(469, 677);
            button3.Name = "button3";
            button3.Size = new Size(247, 32);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 761);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2_Senha);
            Controls.Add(textBox1_Nome);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "Company Pet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1_Nome;
        private TextBox textBox2_Senha;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}