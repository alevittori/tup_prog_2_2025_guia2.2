namespace Ejercicio1
{
    partial class FRegistroEncuesta
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
            this.cbBicicleta = new System.Windows.Forms.CheckBox();
            this.cbAuto = new System.Windows.Forms.CheckBox();
            this.cbTp = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKm = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbContactable = new System.Windows.Forms.CheckBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTp);
            this.groupBox1.Controls.Add(this.cbAuto);
            this.groupBox1.Controls.Add(this.cbBicicleta);
            this.groupBox1.Location = new System.Drawing.Point(43, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modo de transporte habitual";
            // 
            // cbBicicleta
            // 
            this.cbBicicleta.AutoSize = true;
            this.cbBicicleta.Location = new System.Drawing.Point(108, 49);
            this.cbBicicleta.Name = "cbBicicleta";
            this.cbBicicleta.Size = new System.Drawing.Size(100, 17);
            this.cbBicicleta.TabIndex = 0;
            this.cbBicicleta.Text = "¿Usa Bicibleta?";
            this.cbBicicleta.UseVisualStyleBackColor = true;
            // 
            // cbAuto
            // 
            this.cbAuto.AutoSize = true;
            this.cbAuto.Location = new System.Drawing.Point(108, 92);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(105, 17);
            this.cbAuto.TabIndex = 1;
            this.cbAuto.Text = "¿Usa automovil?";
            this.cbAuto.UseVisualStyleBackColor = true;
            // 
            // cbTp
            // 
            this.cbTp.AutoSize = true;
            this.cbTp.Location = new System.Drawing.Point(108, 135);
            this.cbTp.Name = "cbTp";
            this.cbTp.Size = new System.Drawing.Size(144, 17);
            this.cbTp.TabIndex = 2;
            this.cbTp.Text = "¿Usa transporte publico?";
            this.cbTp.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbKm);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(447, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 202);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sobre el destino al trabajo/estudio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distancia en (km) ";
            // 
            // tbKm
            // 
            this.tbKm.Location = new System.Drawing.Point(149, 86);
            this.tbKm.Name = "tbKm";
            this.tbKm.Size = new System.Drawing.Size(109, 20);
            this.tbKm.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbEmail);
            this.groupBox3.Controls.Add(this.cbContactable);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(45, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 81);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contacto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // cbContactable
            // 
            this.cbContactable.AutoSize = true;
            this.cbContactable.Location = new System.Drawing.Point(130, 16);
            this.cbContactable.Name = "cbContactable";
            this.cbContactable.Size = new System.Drawing.Size(143, 17);
            this.cbContactable.TabIndex = 1;
            this.cbContactable.Text = "¿Puede ser contactado?";
            this.cbContactable.UseVisualStyleBackColor = true;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(83, 46);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(190, 20);
            this.tbEmail.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(447, 252);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(288, 65);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "CONFIRMAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(598, 396);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 42);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FRegistroEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 453);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRegistroEncuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FRegistroEncuesta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.CheckBox cbTp;
        public System.Windows.Forms.CheckBox cbAuto;
        public System.Windows.Forms.CheckBox cbBicicleta;
        public System.Windows.Forms.CheckBox cbContactable;
        public System.Windows.Forms.TextBox tbEmail;
        public System.Windows.Forms.TextBox tbKm;
    }
}