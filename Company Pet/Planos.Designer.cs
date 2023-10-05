namespace Company_Pet
{
    partial class Planos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Planos));
            button_Voltar = new Button();
            button_Bronze = new Button();
            button_Prata = new Button();
            button_Ouro = new Button();
            SuspendLayout();
            // 
            // button_Voltar
            // 
            button_Voltar.BackColor = Color.Transparent;
            button_Voltar.Cursor = Cursors.Hand;
            button_Voltar.FlatAppearance.BorderSize = 0;
            button_Voltar.FlatStyle = FlatStyle.Flat;
            button_Voltar.Location = new Point(1, 1);
            button_Voltar.Name = "button_Voltar";
            button_Voltar.Size = new Size(47, 45);
            button_Voltar.TabIndex = 1;
            button_Voltar.UseVisualStyleBackColor = false;
            // 
            // button_Bronze
            // 
            button_Bronze.BackColor = Color.Transparent;
            button_Bronze.FlatAppearance.BorderSize = 0;
            button_Bronze.FlatStyle = FlatStyle.Flat;
            button_Bronze.Location = new Point(48, 488);
            button_Bronze.Name = "button_Bronze";
            button_Bronze.Size = new Size(143, 190);
            button_Bronze.TabIndex = 2;
            button_Bronze.UseVisualStyleBackColor = false;
            // 
            // button_Prata
            // 
            button_Prata.BackColor = Color.Transparent;
            button_Prata.FlatAppearance.BorderSize = 0;
            button_Prata.FlatStyle = FlatStyle.Flat;
            button_Prata.Location = new Point(276, 488);
            button_Prata.Name = "button_Prata";
            button_Prata.Size = new Size(143, 190);
            button_Prata.TabIndex = 3;
            button_Prata.UseVisualStyleBackColor = false;
            // 
            // button_Ouro
            // 
            button_Ouro.BackColor = Color.Transparent;
            button_Ouro.FlatAppearance.BorderSize = 0;
            button_Ouro.FlatStyle = FlatStyle.Flat;
            button_Ouro.Location = new Point(504, 488);
            button_Ouro.Name = "button_Ouro";
            button_Ouro.Size = new Size(143, 190);
            button_Ouro.TabIndex = 4;
            button_Ouro.UseVisualStyleBackColor = false;
            // 
            // Planos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(694, 1061);
            Controls.Add(button_Ouro);
            Controls.Add(button_Prata);
            Controls.Add(button_Bronze);
            Controls.Add(button_Voltar);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Planos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Company Pet";
            ResumeLayout(false);
        }

        #endregion

        private Button button_Voltar;
        private Button button_Bronze;
        private Button button_Prata;
        private Button button_Ouro;
    }
}