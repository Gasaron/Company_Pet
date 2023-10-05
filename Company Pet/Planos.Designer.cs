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
            this.button_Voltar = new System.Windows.Forms.Button();
            this.button_Bronze = new System.Windows.Forms.Button();
            this.button_Prata = new System.Windows.Forms.Button();
            this.button_Ouro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Voltar
            // 
            this.button_Voltar.BackColor = System.Drawing.Color.Transparent;
            this.button_Voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Voltar.FlatAppearance.BorderSize = 0;
            this.button_Voltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Voltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Voltar.Location = new System.Drawing.Point(1, 1);
            this.button_Voltar.Name = "button_Voltar";
            this.button_Voltar.Size = new System.Drawing.Size(34, 31);
            this.button_Voltar.TabIndex = 1;
            this.button_Voltar.UseVisualStyleBackColor = false;
            this.button_Voltar.Click += new System.EventHandler(this.button_Voltar_Click);
            // 
            // button_Bronze
            // 
            this.button_Bronze.BackColor = System.Drawing.Color.Transparent;
            this.button_Bronze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Bronze.FlatAppearance.BorderSize = 0;
            this.button_Bronze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Bronze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Bronze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Bronze.Location = new System.Drawing.Point(37, 346);
            this.button_Bronze.Name = "button_Bronze";
            this.button_Bronze.Size = new System.Drawing.Size(99, 140);
            this.button_Bronze.TabIndex = 2;
            this.button_Bronze.UseVisualStyleBackColor = false;
            this.button_Bronze.Click += new System.EventHandler(this.button_Bronze_Click);
            // 
            // button_Prata
            // 
            this.button_Prata.BackColor = System.Drawing.Color.Transparent;
            this.button_Prata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Prata.FlatAppearance.BorderSize = 0;
            this.button_Prata.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Prata.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Prata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Prata.Location = new System.Drawing.Point(201, 346);
            this.button_Prata.Name = "button_Prata";
            this.button_Prata.Size = new System.Drawing.Size(100, 140);
            this.button_Prata.TabIndex = 3;
            this.button_Prata.UseVisualStyleBackColor = false;
            // 
            // button_Ouro
            // 
            this.button_Ouro.BackColor = System.Drawing.Color.Transparent;
            this.button_Ouro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Ouro.FlatAppearance.BorderSize = 0;
            this.button_Ouro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Ouro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Ouro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ouro.Location = new System.Drawing.Point(364, 346);
            this.button_Ouro.Name = "button_Ouro";
            this.button_Ouro.Size = new System.Drawing.Size(100, 140);
            this.button_Ouro.TabIndex = 4;
            this.button_Ouro.UseVisualStyleBackColor = false;
            // 
            // Planos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(499, 711);
            this.Controls.Add(this.button_Ouro);
            this.Controls.Add(this.button_Prata);
            this.Controls.Add(this.button_Bronze);
            this.Controls.Add(this.button_Voltar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Planos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Pet";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_Voltar;
        private Button button_Bronze;
        private Button button_Prata;
        private Button button_Ouro;
    }
}