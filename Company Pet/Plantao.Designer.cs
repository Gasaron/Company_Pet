namespace Company_Pet
{
    partial class Plantao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plantao));
            this.button_Voltar = new System.Windows.Forms.Button();
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
            this.button_Voltar.Location = new System.Drawing.Point(1, 2);
            this.button_Voltar.Name = "button_Voltar";
            this.button_Voltar.Size = new System.Drawing.Size(32, 30);
            this.button_Voltar.TabIndex = 0;
            this.button_Voltar.UseVisualStyleBackColor = false;
            this.button_Voltar.Click += new System.EventHandler(this.button_Voltar_Click);
            // 
            // Plantao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(499, 711);
            this.Controls.Add(this.button_Voltar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Plantao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Pet";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_Voltar;
    }
}