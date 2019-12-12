namespace DobleIfEnForm
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
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtladoB = new System.Windows.Forms.TextBox();
            this.txtladoA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtperimetro = new System.Windows.Forms.TextBox();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pxcuadrado = new System.Windows.Forms.PictureBox();
            this.pxrectangulo = new System.Windows.Forms.PictureBox();
            this.btnsiguiente2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxcuadrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxrectangulo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsiguiente2);
            this.groupBox1.Controls.Add(this.btnsalir);
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Controls.Add(this.btncalcular);
            this.groupBox1.Controls.Add(this.txtladoB);
            this.groupBox1.Controls.Add(this.txtladoA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese Lados Del Cuadrilatero";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(370, 142);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(206, 142);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 5;
            this.btnnuevo.Text = "NUEVO";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(83, 142);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "CALCULAR";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtladoB
            // 
            this.txtladoB.Location = new System.Drawing.Point(83, 79);
            this.txtladoB.Name = "txtladoB";
            this.txtladoB.Size = new System.Drawing.Size(100, 20);
            this.txtladoB.TabIndex = 3;
            // 
            // txtladoA
            // 
            this.txtladoA.Location = new System.Drawing.Point(83, 38);
            this.txtladoA.Name = "txtladoA";
            this.txtladoA.Size = new System.Drawing.Size(100, 20);
            this.txtladoA.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lado B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lado A:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtperimetro);
            this.groupBox2.Controls.Add(this.txtarea);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(320, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txtperimetro
            // 
            this.txtperimetro.Location = new System.Drawing.Point(83, 67);
            this.txtperimetro.Name = "txtperimetro";
            this.txtperimetro.Size = new System.Drawing.Size(100, 20);
            this.txtperimetro.TabIndex = 3;
            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(83, 20);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(100, 20);
            this.txtarea.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Perimetro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Area:";
            // 
            // pxcuadrado
            // 
            this.pxcuadrado.BackColor = System.Drawing.Color.Red;
            this.pxcuadrado.Location = new System.Drawing.Point(96, 191);
            this.pxcuadrado.Name = "pxcuadrado";
            this.pxcuadrado.Size = new System.Drawing.Size(114, 99);
            this.pxcuadrado.TabIndex = 2;
            this.pxcuadrado.TabStop = false;
            // 
            // pxrectangulo
            // 
            this.pxrectangulo.BackColor = System.Drawing.Color.Green;
            this.pxrectangulo.Location = new System.Drawing.Point(70, 227);
            this.pxrectangulo.Name = "pxrectangulo";
            this.pxrectangulo.Size = new System.Drawing.Size(170, 50);
            this.pxrectangulo.TabIndex = 3;
            this.pxrectangulo.TabStop = false;
            // 
            // btnsiguiente2
            // 
            this.btnsiguiente2.Location = new System.Drawing.Point(369, 20);
            this.btnsiguiente2.Name = "btnsiguiente2";
            this.btnsiguiente2.Size = new System.Drawing.Size(175, 38);
            this.btnsiguiente2.TabIndex = 7;
            this.btnsiguiente2.Text = "Ir Al Siguiente Form";
            this.btnsiguiente2.UseVisualStyleBackColor = true;
            this.btnsiguiente2.Click += new System.EventHandler(this.btnsiguiente2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(575, 303);
            this.Controls.Add(this.pxrectangulo);
            this.Controls.Add(this.pxcuadrado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Figuiritas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxcuadrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxrectangulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtladoB;
        private System.Windows.Forms.TextBox txtladoA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtperimetro;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pxcuadrado;
        private System.Windows.Forms.PictureBox pxrectangulo;
        private System.Windows.Forms.Button btnsiguiente2;
    }
}

