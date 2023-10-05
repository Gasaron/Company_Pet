namespace Company_Pet
{
    partial class Entrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrar));
            this.Nome = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_voltar_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nome.Location = new System.Drawing.Point(221, 374);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(779, 36);
            this.Nome.TabIndex = 0;
            this.Nome.TextChanged += new System.EventHandler(this.textBox1_Nome_TextChanged);
            // 
            // Senha
            // 
            this.Senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Senha.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Senha.Location = new System.Drawing.Point(221, 465);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(779, 36);
            this.Senha.TabIndex = 1;
            this.Senha.TextChanged += new System.EventHandler(this.Senha_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(497, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 53);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(469, 627);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 32);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(469, 677);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(247, 32);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button_voltar_2
            // 
            this.button_voltar_2.BackColor = System.Drawing.Color.Transparent;
            this.button_voltar_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_voltar_2.FlatAppearance.BorderSize = 0;
            this.button_voltar_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_voltar_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_voltar_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_voltar_2.Location = new System.Drawing.Point(1, 1);
            this.button_voltar_2.Name = "button_voltar_2";
            this.button_voltar_2.Size = new System.Drawing.Size(75, 75);
            this.button_voltar_2.TabIndex = 7;
            this.button_voltar_2.UseVisualStyleBackColor = false;
            this.button_voltar_2.Click += new System.EventHandler(this.button_voltar_2_Click);
            // 
            // Entrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.button_voltar_2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Nome);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Entrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Pet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Nome;
        private TextBox Senha;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button_voltar_2;
    }
}