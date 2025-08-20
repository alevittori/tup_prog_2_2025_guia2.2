namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnResultados = new System.Windows.Forms.Button();
            this.bntListarContactables = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(139, 47);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(153, 53);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Resgistro De Encuesta";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnResultados
            // 
            this.btnResultados.Location = new System.Drawing.Point(139, 147);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(153, 53);
            this.btnResultados.TabIndex = 1;
            this.btnResultados.Text = "Resultados";
            this.btnResultados.UseVisualStyleBackColor = true;
            // 
            // bntListarContactables
            // 
            this.bntListarContactables.Location = new System.Drawing.Point(139, 247);
            this.bntListarContactables.Name = "bntListarContactables";
            this.bntListarContactables.Size = new System.Drawing.Size(153, 53);
            this.bntListarContactables.TabIndex = 2;
            this.bntListarContactables.Text = "Listado Contactables";
            this.bntListarContactables.UseVisualStyleBackColor = true;
            this.bntListarContactables.Click += new System.EventHandler(this.bntListarContactables_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(450, 370);
            this.Controls.Add(this.bntListarContactables);
            this.Controls.Add(this.btnResultados);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnResultados;
        private System.Windows.Forms.Button bntListarContactables;
    }
}

