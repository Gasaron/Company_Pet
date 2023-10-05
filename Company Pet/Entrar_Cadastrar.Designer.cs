namespace Company_Pet
{
    partial class Entrar_Cadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrar_Cadastrar));
            Entrar = new Button();
            Cadastrar = new Button();
            SuspendLayout();
            // 
            // Entrar
            // 
            Entrar.BackColor = Color.Transparent;
            Entrar.Cursor = Cursors.Hand;
            Entrar.FlatAppearance.BorderSize = 0;
            Entrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Entrar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Entrar.FlatStyle = FlatStyle.Flat;
            Entrar.Location = new Point(294, 576);
            Entrar.Name = "Entrar";
            Entrar.Size = new Size(290, 73);
            Entrar.TabIndex = 0;
            Entrar.UseVisualStyleBackColor = false;
            Entrar.Click += Entrar_Click;
            // 
            // Cadastrar
            // 
            Cadastrar.BackColor = Color.Transparent;
            Cadastrar.Cursor = Cursors.Hand;
            Cadastrar.FlatAppearance.BorderSize = 0;
            Cadastrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Cadastrar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Cadastrar.FlatStyle = FlatStyle.Flat;
            Cadastrar.Location = new Point(605, 576);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(290, 73);
            Cadastrar.TabIndex = 1;
            Cadastrar.UseVisualStyleBackColor = false;
            Cadastrar.Click += Cadastrar_Click;
            // 
            // Entrar_Cadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1184, 761);
            Controls.Add(Cadastrar);
            Controls.Add(Entrar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Entrar_Cadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Company Pet";
            Load += Entrar_Carregar_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button Cadastrar;
        public Button Entrar;
    }
}