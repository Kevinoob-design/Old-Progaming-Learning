namespace ElIfenForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CHKbono = new System.Windows.Forms.CheckBox();
            this.NPHijos = new System.Windows.Forms.NumericUpDown();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.txtpagohextra = new System.Windows.Forms.TextBox();
            this.txtpagohnormal = new System.Windows.Forms.TextBox();
            this.txthorasextra = new System.Windows.Forms.TextBox();
            this.txthorasnormales = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtneto = new System.Windows.Forms.TextBox();
            this.txtbono = new System.Windows.Forms.TextBox();
            this.txtsueldobruto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NPHijos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsalir);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btncalcular);
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Controls.Add(this.txtpagohextra);
            this.groupBox1.Controls.Add(this.txtpagohnormal);
            this.groupBox1.Controls.Add(this.txthorasextra);
            this.groupBox1.Controls.Add(this.txthorasnormales);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jornada Laboral";
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Firebrick;
            this.btnsalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsalir.Location = new System.Drawing.Point(336, 265);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(85, 34);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.CHKbono);
            this.groupBox3.Controls.Add(this.NPHijos);
            this.groupBox3.Location = new System.Drawing.Point(23, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(548, 71);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bonificacion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Cantidad De Hijos:";
            // 
            // CHKbono
            // 
            this.CHKbono.AutoSize = true;
            this.CHKbono.Location = new System.Drawing.Point(303, 29);
            this.CHKbono.Name = "CHKbono";
            this.CHKbono.Size = new System.Drawing.Size(140, 17);
            this.CHKbono.TabIndex = 2;
            this.CHKbono.Text = "Recibir Bonificacion";
            this.CHKbono.UseVisualStyleBackColor = true;
            // 
            // NPHijos
            // 
            this.NPHijos.Location = new System.Drawing.Point(126, 31);
            this.NPHijos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NPHijos.Name = "NPHijos";
            this.NPHijos.Size = new System.Drawing.Size(68, 20);
            this.NPHijos.TabIndex = 1;
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.Green;
            this.btncalcular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncalcular.Location = new System.Drawing.Point(146, 265);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(88, 34);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "CALCULAR";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.Green;
            this.btnnuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnnuevo.Location = new System.Drawing.Point(23, 265);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(83, 34);
            this.btnnuevo.TabIndex = 3;
            this.btnnuevo.Text = "NUEVO";
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // txtpagohextra
            // 
            this.txtpagohextra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpagohextra.Location = new System.Drawing.Point(336, 134);
            this.txtpagohextra.Name = "txtpagohextra";
            this.txtpagohextra.Size = new System.Drawing.Size(100, 20);
            this.txtpagohextra.TabIndex = 7;
            // 
            // txtpagohnormal
            // 
            this.txtpagohnormal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpagohnormal.Location = new System.Drawing.Point(336, 57);
            this.txtpagohnormal.Name = "txtpagohnormal";
            this.txtpagohnormal.Size = new System.Drawing.Size(100, 20);
            this.txtpagohnormal.TabIndex = 6;
            // 
            // txthorasextra
            // 
            this.txthorasextra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthorasextra.Location = new System.Drawing.Point(6, 134);
            this.txthorasextra.Name = "txthorasextra";
            this.txthorasextra.Size = new System.Drawing.Size(100, 20);
            this.txthorasextra.TabIndex = 5;
            // 
            // txthorasnormales
            // 
            this.txthorasnormales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthorasnormales.Location = new System.Drawing.Point(6, 57);
            this.txthorasnormales.Name = "txthorasnormales";
            this.txthorasnormales.Size = new System.Drawing.Size(100, 20);
            this.txthorasnormales.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pago Por Horas Extras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pago Por Hora Normal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horas Extras";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Horas Normales Trabajadas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtneto);
            this.groupBox2.Controls.Add(this.txtbono);
            this.groupBox2.Controls.Add(this.txtsueldobruto);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 167);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sueldo";
            // 
            // txtneto
            // 
            this.txtneto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtneto.Location = new System.Drawing.Point(140, 140);
            this.txtneto.Name = "txtneto";
            this.txtneto.Size = new System.Drawing.Size(100, 20);
            this.txtneto.TabIndex = 5;
            // 
            // txtbono
            // 
            this.txtbono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbono.Location = new System.Drawing.Point(140, 89);
            this.txtbono.Name = "txtbono";
            this.txtbono.Size = new System.Drawing.Size(100, 20);
            this.txtbono.TabIndex = 4;
            // 
            // txtsueldobruto
            // 
            this.txtsueldobruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsueldobruto.Location = new System.Drawing.Point(140, 40);
            this.txtsueldobruto.Name = "txtsueldobruto";
            this.txtsueldobruto.Size = new System.Drawing.Size(100, 20);
            this.txtsueldobruto.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Sueldo Neto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Bonificacion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sueldo Bruto:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(616, 503);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "La Cagita del IF";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NPHijos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown NPHijos;
        private System.Windows.Forms.TextBox txtpagohextra;
        private System.Windows.Forms.TextBox txtpagohnormal;
        private System.Windows.Forms.TextBox txthorasextra;
        private System.Windows.Forms.TextBox txthorasnormales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox CHKbono;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox txtneto;
        private System.Windows.Forms.TextBox txtbono;
        private System.Windows.Forms.TextBox txtsueldobruto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
    }
}

