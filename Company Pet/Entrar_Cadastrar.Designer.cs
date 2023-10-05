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
            this.Entrar = new System.Windows.Forms.Button();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Entrar
            // 
            this.Entrar.BackColor = System.Drawing.Color.Transparent;
            this.Entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Entrar.FlatAppearance.BorderSize = 0;
            this.Entrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Entrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Entrar.Location = new System.Drawing.Point(294, 576);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(290, 73);
            this.Entrar.TabIndex = 0;
            this.Entrar.UseVisualStyleBackColor = false;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click_1);
            // 
            // Cadastrar
            // 
            this.Cadastrar.BackColor = System.Drawing.Color.Transparent;
            this.Cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cadastrar.FlatAppearance.BorderSize = 0;
            this.Cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cadastrar.Location = new System.Drawing.Point(605, 576);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(290, 73);
            this.Cadastrar.TabIndex = 1;
            this.Cadastrar.UseVisualStyleBackColor = false;
            // 
            // Entrar_Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.Entrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Entrar_Cadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Pet";
            this.ResumeLayout(false);

        }

        #endregion
        private Button Cadastrar;
        public Button Entrar;
    }
}