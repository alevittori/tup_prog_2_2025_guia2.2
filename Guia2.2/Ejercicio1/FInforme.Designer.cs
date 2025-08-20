namespace Ejercicio1
{
    partial class FInforme
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
            this.lboxInforme = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboxInforme
            // 
            this.lboxInforme.FormattingEnabled = true;
            this.lboxInforme.Location = new System.Drawing.Point(12, 26);
            this.lboxInforme.Name = "lboxInforme";
            this.lboxInforme.Size = new System.Drawing.Size(744, 394);
            this.lboxInforme.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lboxInforme);
            this.Name = "FInforme";
            this.Text = "FInforme";
            this.Load += new System.EventHandler(this.FInforme_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox lboxInforme;
    }
}