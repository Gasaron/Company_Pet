namespace Company_Pet
{
    partial class Domicilio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Domicilio));
            button_Voltar = new Button();
            SuspendLayout();
            // 
            // button_Voltar
            // 
            button_Voltar.BackColor = Color.Transparent;
            button_Voltar.Cursor = Cursors.Hand;
            button_Voltar.FlatAppearance.BorderSize = 0;
            button_Voltar.FlatStyle = FlatStyle.Flat;
            button_Voltar.Location = new Point(2, 1);
            button_Voltar.Name = "button_Voltar";
            button_Voltar.Size = new Size(47, 45);
            button_Voltar.TabIndex = 1;
            button_Voltar.UseVisualStyleBackColor = false;
            // 
            // Domicilio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(656, 1061);
            Controls.Add(button_Voltar);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Domicilio";
            Text = "Company Pet";
            ResumeLayout(false);
        }

        #endregion

        private Button button_Voltar;
    }
}