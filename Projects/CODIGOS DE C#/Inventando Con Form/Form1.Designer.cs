namespace Inventando_Con_Form
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.repeticiones = new System.Windows.Forms.NumericUpDown();
            this.txtpasos = new System.Windows.Forms.TextBox();
            this.txthasta = new System.Windows.Forms.TextBox();
            this.txtinicio = new System.Windows.Forms.TextBox();
            this.validacion = new System.Windows.Forms.CheckBox();
            this.btndetener = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btninicio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pc1 = new System.Windows.Forms.PictureBox();
            this.pc2 = new System.Windows.Forms.PictureBox();
            this.pc3 = new System.Windows.Forms.PictureBox();
            this.hora = new System.Windows.Forms.Label();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnplay = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txttiempo = new System.Windows.Forms.TextBox();
            this.txtoperaciones = new System.Windows.Forms.TextBox();
            this.impresion = new System.Windows.Forms.ListBox();
            this.opcion2 = new System.Windows.Forms.RadioButton();
            this.opcion1 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repeticiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc3)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.btnsalir);
            this.groupBox1.Controls.Add(this.repeticiones);
            this.groupBox1.Controls.Add(this.txtpasos);
            this.groupBox1.Controls.Add(this.txthasta);
            this.groupBox1.Controls.Add(this.txtinicio);
            this.groupBox1.Controls.Add(this.validacion);
            this.groupBox1.Controls.Add(this.btndetener);
            this.groupBox1.Controls.Add(this.btnlimpiar);
            this.groupBox1.Controls.Add(this.btninicio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada De Datos";
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Red;
            this.btnsalir.Location = new System.Drawing.Point(362, 175);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 12;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // repeticiones
            // 
            this.repeticiones.Location = new System.Drawing.Point(99, 124);
            this.repeticiones.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.repeticiones.Name = "repeticiones";
            this.repeticiones.Size = new System.Drawing.Size(120, 20);
            this.repeticiones.TabIndex = 11;
            // 
            // txtpasos
            // 
            this.txtpasos.Location = new System.Drawing.Point(58, 88);
            this.txtpasos.Name = "txtpasos";
            this.txtpasos.Size = new System.Drawing.Size(100, 20);
            this.txtpasos.TabIndex = 10;
            // 
            // txthasta
            // 
            this.txthasta.Location = new System.Drawing.Point(58, 49);
            this.txthasta.Name = "txthasta";
            this.txthasta.Size = new System.Drawing.Size(100, 20);
            this.txthasta.TabIndex = 9;
            // 
            // txtinicio
            // 
            this.txtinicio.Location = new System.Drawing.Point(58, 17);
            this.txtinicio.Name = "txtinicio";
            this.txtinicio.Size = new System.Drawing.Size(100, 20);
            this.txtinicio.TabIndex = 8;
            // 
            // validacion
            // 
            this.validacion.AutoSize = true;
            this.validacion.Location = new System.Drawing.Point(13, 127);
            this.validacion.Name = "validacion";
            this.validacion.Size = new System.Drawing.Size(65, 17);
            this.validacion.TabIndex = 7;
            this.validacion.Text = "Validar";
            this.validacion.UseVisualStyleBackColor = true;
            // 
            // btndetener
            // 
            this.btndetener.BackColor = System.Drawing.Color.Lime;
            this.btndetener.Location = new System.Drawing.Point(87, 175);
            this.btndetener.Name = "btndetener";
            this.btndetener.Size = new System.Drawing.Size(75, 23);
            this.btndetener.TabIndex = 6;
            this.btndetener.Text = "Detener";
            this.btndetener.UseVisualStyleBackColor = false;
            this.btndetener.Click += new System.EventHandler(this.btndetener_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Lime;
            this.btnlimpiar.Location = new System.Drawing.Point(168, 176);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 5;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btninicio
            // 
            this.btninicio.BackColor = System.Drawing.Color.Lime;
            this.btninicio.Location = new System.Drawing.Point(6, 175);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(75, 23);
            this.btninicio.TabIndex = 4;
            this.btninicio.Text = "Iniciar";
            this.btninicio.UseVisualStyleBackColor = false;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pasos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inicio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.BackgroundImage = global::Inventando_Con_Form.Properties.Resources.IMG_7B504B_B331E0_009FA1_5837B3_C6B38C_AA6F7B;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(437, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 206);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(13, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.pc1);
            this.groupBox3.Controls.Add(this.pc2);
            this.groupBox3.Controls.Add(this.pc3);
            this.groupBox3.Controls.Add(this.hora);
            this.groupBox3.Controls.Add(this.btnstop);
            this.groupBox3.Controls.Add(this.btnplay);
            this.groupBox3.Location = new System.Drawing.Point(333, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 167);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grupo De Animaciones";
            // 
            // pc1
            // 
            this.pc1.BackColor = System.Drawing.Color.Cyan;
            this.pc1.Location = new System.Drawing.Point(66, 44);
            this.pc1.Name = "pc1";
            this.pc1.Size = new System.Drawing.Size(152, 50);
            this.pc1.TabIndex = 5;
            this.pc1.TabStop = false;
            // 
            // pc2
            // 
            this.pc2.BackColor = System.Drawing.Color.LawnGreen;
            this.pc2.Location = new System.Drawing.Point(89, 19);
            this.pc2.Name = "pc2";
            this.pc2.Size = new System.Drawing.Size(100, 108);
            this.pc2.TabIndex = 4;
            this.pc2.TabStop = false;
            // 
            // pc3
            // 
            this.pc3.BackColor = System.Drawing.Color.Red;
            this.pc3.Location = new System.Drawing.Point(89, 44);
            this.pc3.Name = "pc3";
            this.pc3.Size = new System.Drawing.Size(100, 50);
            this.pc3.TabIndex = 3;
            this.pc3.TabStop = false;
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Location = new System.Drawing.Point(225, 19);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(38, 13);
            this.hora.TabIndex = 2;
            this.hora.Text = "HORA";
            // 
            // btnstop
            // 
            this.btnstop.BackColor = System.Drawing.Color.Red;
            this.btnstop.Location = new System.Drawing.Point(89, 138);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(75, 23);
            this.btnstop.TabIndex = 1;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = false;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnplay
            // 
            this.btnplay.BackColor = System.Drawing.Color.Green;
            this.btnplay.Location = new System.Drawing.Point(7, 138);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(75, 23);
            this.btnplay.TabIndex = 0;
            this.btnplay.Text = "Play";
            this.btnplay.UseVisualStyleBackColor = false;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.txttiempo);
            this.groupBox4.Controls.Add(this.txtoperaciones);
            this.groupBox4.Controls.Add(this.impresion);
            this.groupBox4.Controls.Add(this.opcion2);
            this.groupBox4.Controls.Add(this.opcion1);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 167);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Salida De Datos";
            // 
            // txttiempo
            // 
            this.txttiempo.Location = new System.Drawing.Point(158, 134);
            this.txttiempo.Name = "txttiempo";
            this.txttiempo.ReadOnly = true;
            this.txttiempo.Size = new System.Drawing.Size(100, 20);
            this.txttiempo.TabIndex = 12;
            // 
            // txtoperaciones
            // 
            this.txtoperaciones.Location = new System.Drawing.Point(158, 108);
            this.txtoperaciones.Name = "txtoperaciones";
            this.txtoperaciones.ReadOnly = true;
            this.txtoperaciones.Size = new System.Drawing.Size(100, 20);
            this.txtoperaciones.TabIndex = 11;
            // 
            // impresion
            // 
            this.impresion.FormattingEnabled = true;
            this.impresion.HorizontalScrollbar = true;
            this.impresion.Location = new System.Drawing.Point(7, 20);
            this.impresion.Name = "impresion";
            this.impresion.Size = new System.Drawing.Size(145, 134);
            this.impresion.TabIndex = 10;
            // 
            // opcion2
            // 
            this.opcion2.AutoSize = true;
            this.opcion2.Location = new System.Drawing.Point(230, 44);
            this.opcion2.Name = "opcion2";
            this.opcion2.Size = new System.Drawing.Size(68, 17);
            this.opcion2.TabIndex = 9;
            this.opcion2.TabStop = true;
            this.opcion2.Text = "Opcion 2";
            this.opcion2.UseVisualStyleBackColor = true;
            // 
            // opcion1
            // 
            this.opcion1.AutoSize = true;
            this.opcion1.Location = new System.Drawing.Point(230, 20);
            this.opcion1.Name = "opcion1";
            this.opcion1.Size = new System.Drawing.Size(68, 17);
            this.opcion1.TabIndex = 8;
            this.opcion1.TabStop = true;
            this.opcion1.Text = "Opcion 1";
            this.opcion1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(676, 429);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Una Super Cagita Magica";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repeticiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox validacion;
        private System.Windows.Forms.Button btndetener;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox impresion;
        private System.Windows.Forms.RadioButton opcion2;
        private System.Windows.Forms.RadioButton opcion1;
        private System.Windows.Forms.TextBox txtpasos;
        private System.Windows.Forms.TextBox txthasta;
        private System.Windows.Forms.TextBox txtinicio;
        private System.Windows.Forms.TextBox txttiempo;
        private System.Windows.Forms.TextBox txtoperaciones;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NumericUpDown repeticiones;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.PictureBox pc1;
        private System.Windows.Forms.PictureBox pc2;
        private System.Windows.Forms.PictureBox pc3;
        private System.Windows.Forms.Timer timer3;
    }
}

