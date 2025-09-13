namespace Ejercicio2
{
    partial class FIngresoEmbarque
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.tbNEmbarque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCargaVechiculos = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCargarVehiculo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbCargaVechiculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAlta);
            this.groupBox1.Controls.Add(this.tbNEmbarque);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(568, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del embarque ingresante";
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(388, 36);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(137, 75);
            this.btnAlta.TabIndex = 2;
            this.btnAlta.Text = "Dar de Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // tbNEmbarque
            // 
            this.tbNEmbarque.Location = new System.Drawing.Point(183, 60);
            this.tbNEmbarque.Margin = new System.Windows.Forms.Padding(4);
            this.tbNEmbarque.Name = "tbNEmbarque";
            this.tbNEmbarque.Size = new System.Drawing.Size(136, 22);
            this.tbNEmbarque.TabIndex = 1;
            this.tbNEmbarque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Embarque: ";
            // 
            // gbCargaVechiculos
            // 
            this.gbCargaVechiculos.Controls.Add(this.textBox3);
            this.gbCargaVechiculos.Controls.Add(this.textBox2);
            this.gbCargaVechiculos.Controls.Add(this.btnCargarVehiculo);
            this.gbCargaVechiculos.Controls.Add(this.label3);
            this.gbCargaVechiculos.Controls.Add(this.label2);
            this.gbCargaVechiculos.Location = new System.Drawing.Point(25, 167);
            this.gbCargaVechiculos.Margin = new System.Windows.Forms.Padding(4);
            this.gbCargaVechiculos.Name = "gbCargaVechiculos";
            this.gbCargaVechiculos.Padding = new System.Windows.Forms.Padding(4);
            this.gbCargaVechiculos.Size = new System.Drawing.Size(564, 202);
            this.gbCargaVechiculos.TabIndex = 1;
            this.gbCargaVechiculos.TabStop = false;
            this.gbCargaVechiculos.Text = "Carga de Vehiculos";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(183, 117);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(183, 60);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 4;
            // 
            // btnCargarVehiculo
            // 
            this.btnCargarVehiculo.Location = new System.Drawing.Point(388, 64);
            this.btnCargarVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargarVehiculo.Name = "btnCargarVehiculo";
            this.btnCargarVehiculo.Size = new System.Drawing.Size(137, 75);
            this.btnCargarVehiculo.TabIndex = 3;
            this.btnCargarVehiculo.Text = "Cargar Vehiculo al Embarque";
            this.btnCargarVehiculo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Monto de fabricacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Año de fabricacion";
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(25, 414);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(196, 80);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar y Finalizar Embarque";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(393, 414);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(196, 80);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar Embarque";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FIngresoEmbarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 519);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbCargaVechiculos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FIngresoEmbarque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FIngresoEmbarque";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCargaVechiculos.ResumeLayout(false);
            this.gbCargaVechiculos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.TextBox tbNEmbarque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCargaVechiculos;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCargarVehiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}