namespace Ejercicio2
{
    partial class FConsesionaria
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
            this.btnAltaEmbarque = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTodosLosEmbarques = new System.Windows.Forms.Button();
            this.btnEmbarqueMayor = new System.Windows.Forms.Button();
            this.btnResumenDelDia = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarEmbarque = new System.Windows.Forms.Button();
            this.tbNumEmbarque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAltaEmbarque
            // 
            this.btnAltaEmbarque.Location = new System.Drawing.Point(400, 15);
            this.btnAltaEmbarque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAltaEmbarque.Name = "btnAltaEmbarque";
            this.btnAltaEmbarque.Size = new System.Drawing.Size(251, 63);
            this.btnAltaEmbarque.TabIndex = 0;
            this.btnAltaEmbarque.Text = "Alta Embarque";
            this.btnAltaEmbarque.UseVisualStyleBackColor = true;
            this.btnAltaEmbarque.Click += new System.EventHandler(this.btnAltaEmbarque_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTodosLosEmbarques);
            this.groupBox1.Controls.Add(this.btnEmbarqueMayor);
            this.groupBox1.Controls.Add(this.btnResumenDelDia);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(17, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1039, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informe";
            // 
            // btnTodosLosEmbarques
            // 
            this.btnTodosLosEmbarques.Location = new System.Drawing.Point(892, 343);
            this.btnTodosLosEmbarques.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTodosLosEmbarques.Name = "btnTodosLosEmbarques";
            this.btnTodosLosEmbarques.Size = new System.Drawing.Size(96, 55);
            this.btnTodosLosEmbarques.TabIndex = 4;
            this.btnTodosLosEmbarques.Text = "Todos los embarque";
            this.btnTodosLosEmbarques.UseVisualStyleBackColor = true;
            // 
            // btnEmbarqueMayor
            // 
            this.btnEmbarqueMayor.Location = new System.Drawing.Point(892, 265);
            this.btnEmbarqueMayor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmbarqueMayor.Name = "btnEmbarqueMayor";
            this.btnEmbarqueMayor.Size = new System.Drawing.Size(96, 55);
            this.btnEmbarqueMayor.TabIndex = 3;
            this.btnEmbarqueMayor.Text = "Embarque Mayor";
            this.btnEmbarqueMayor.UseVisualStyleBackColor = true;
            // 
            // btnResumenDelDia
            // 
            this.btnResumenDelDia.Location = new System.Drawing.Point(892, 190);
            this.btnResumenDelDia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResumenDelDia.Name = "btnResumenDelDia";
            this.btnResumenDelDia.Size = new System.Drawing.Size(96, 55);
            this.btnResumenDelDia.TabIndex = 2;
            this.btnResumenDelDia.Text = "Resumen del dia";
            this.btnResumenDelDia.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(17, 177);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(845, 260);
            this.listBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarEmbarque);
            this.groupBox2.Controls.Add(this.tbNumEmbarque);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(16, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1009, 140);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ver Embarque";
            // 
            // btnBuscarEmbarque
            // 
            this.btnBuscarEmbarque.Location = new System.Drawing.Point(711, 55);
            this.btnBuscarEmbarque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarEmbarque.Name = "btnBuscarEmbarque";
            this.btnBuscarEmbarque.Size = new System.Drawing.Size(228, 39);
            this.btnBuscarEmbarque.TabIndex = 2;
            this.btnBuscarEmbarque.Text = "Buscar Embarque";
            this.btnBuscarEmbarque.UseVisualStyleBackColor = true;
            // 
            // tbNumEmbarque
            // 
            this.tbNumEmbarque.Location = new System.Drawing.Point(261, 64);
            this.tbNumEmbarque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNumEmbarque.Name = "tbNumEmbarque";
            this.tbNumEmbarque.Size = new System.Drawing.Size(227, 22);
            this.tbNumEmbarque.TabIndex = 1;
            this.tbNumEmbarque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumEmbarque_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de embarque";
            // 
            // FConsesionaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAltaEmbarque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FConsesionaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FConsesionaria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaEmbarque;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTodosLosEmbarques;
        private System.Windows.Forms.Button btnEmbarqueMayor;
        private System.Windows.Forms.Button btnResumenDelDia;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnBuscarEmbarque;
        private System.Windows.Forms.TextBox tbNumEmbarque;
    }
}