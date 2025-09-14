namespace Ejercicio3
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
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.btnExtraer = new System.Windows.Forms.Button();
            this.btnReponer = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lbExistencia = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbProductos
            // 
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(20, 96);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(348, 24);
            this.cbProductos.TabIndex = 0;
            this.cbProductos.SelectedIndexChanged += new System.EventHandler(this.cbProductos_SelectedIndexChanged);
            // 
            // btnExtraer
            // 
            this.btnExtraer.Location = new System.Drawing.Point(783, 208);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(109, 56);
            this.btnExtraer.TabIndex = 1;
            this.btnExtraer.Text = "Extraer";
            this.btnExtraer.UseVisualStyleBackColor = true;
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // btnReponer
            // 
            this.btnReponer.Location = new System.Drawing.Point(783, 357);
            this.btnReponer.Name = "btnReponer";
            this.btnReponer.Size = new System.Drawing.Size(109, 56);
            this.btnReponer.TabIndex = 2;
            this.btnReponer.Text = "Reponer";
            this.btnReponer.UseVisualStyleBackColor = true;
            this.btnReponer.Click += new System.EventHandler(this.btnReponer_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(315, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 56);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(783, 284);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(109, 56);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lbExistencia
            // 
            this.lbExistencia.FormattingEnabled = true;
            this.lbExistencia.ItemHeight = 16;
            this.lbExistencia.Location = new System.Drawing.Point(6, 21);
            this.lbExistencia.Name = "lbExistencia";
            this.lbExistencia.Size = new System.Drawing.Size(552, 308);
            this.lbExistencia.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbExistencia);
            this.groupBox1.Location = new System.Drawing.Point(30, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 345);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Existencia";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cbProductos);
            this.groupBox2.Location = new System.Drawing.Point(35, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(857, 173);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.tbBuscar);
            this.groupBox3.Location = new System.Drawing.Point(395, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(456, 99);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(208, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 20);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Indice";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(207, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 20);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Codigo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(27, 40);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(155, 22);
            this.tbBuscar.TabIndex = 0;
            this.tbBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscar_KeyPress);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(783, 481);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 56);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consultar Existencia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 606);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnReponer);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExtraer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.Button btnExtraer;
        private System.Windows.Forms.Button btnReponer;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ListBox lbExistencia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
    }
}

