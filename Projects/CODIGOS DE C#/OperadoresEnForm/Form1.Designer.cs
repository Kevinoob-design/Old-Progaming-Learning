namespace OperadoresEnForm
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
            this.LIMPIAR = new System.Windows.Forms.Button();
            this.CALCULAR = new System.Windows.Forms.Button();
            this.NumeroDos = new System.Windows.Forms.TextBox();
            this.NumeroUno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtraiz = new System.Windows.Forms.TextBox();
            this.txtpot = new System.Windows.Forms.TextBox();
            this.txtdiv = new System.Windows.Forms.TextBox();
            this.txtmulti = new System.Windows.Forms.TextBox();
            this.txtres = new System.Windows.Forms.TextBox();
            this.txtsum = new System.Windows.Forms.TextBox();
            this.sndjasd = new System.Windows.Forms.Label();
            this.ejnsd = new System.Windows.Forms.Label();
            this.asdas = new System.Windows.Forms.Label();
            this.lababa = new System.Windows.Forms.Label();
            this.labaelll = new System.Windows.Forms.Label();
            this.labael = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LIMPIAR);
            this.groupBox1.Controls.Add(this.CALCULAR);
            this.groupBox1.Controls.Add(this.NumeroDos);
            this.groupBox1.Controls.Add(this.NumeroUno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPERADORES";
            // 
            // LIMPIAR
            // 
            this.LIMPIAR.Location = new System.Drawing.Point(333, 77);
            this.LIMPIAR.Name = "LIMPIAR";
            this.LIMPIAR.Size = new System.Drawing.Size(84, 24);
            this.LIMPIAR.TabIndex = 5;
            this.LIMPIAR.Text = "LIMPIAR";
            this.LIMPIAR.UseVisualStyleBackColor = true;
            this.LIMPIAR.Click += new System.EventHandler(this.LIMPIAR_Click);
            // 
            // CALCULAR
            // 
            this.CALCULAR.Location = new System.Drawing.Point(333, 36);
            this.CALCULAR.Name = "CALCULAR";
            this.CALCULAR.Size = new System.Drawing.Size(84, 23);
            this.CALCULAR.TabIndex = 4;
            this.CALCULAR.Text = "CALCULAR";
            this.CALCULAR.UseVisualStyleBackColor = true;
            this.CALCULAR.Click += new System.EventHandler(this.CALCULAR_Click);
            // 
            // NumeroDos
            // 
            this.NumeroDos.Location = new System.Drawing.Point(126, 81);
            this.NumeroDos.Name = "NumeroDos";
            this.NumeroDos.Size = new System.Drawing.Size(142, 20);
            this.NumeroDos.TabIndex = 3;
            // 
            // NumeroUno
            // 
            this.NumeroUno.Location = new System.Drawing.Point(126, 36);
            this.NumeroUno.Name = "NumeroUno";
            this.NumeroUno.Size = new System.Drawing.Size(142, 20);
            this.NumeroUno.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtraiz);
            this.groupBox2.Controls.Add(this.txtpot);
            this.groupBox2.Controls.Add(this.txtdiv);
            this.groupBox2.Controls.Add(this.txtmulti);
            this.groupBox2.Controls.Add(this.txtres);
            this.groupBox2.Controls.Add(this.txtsum);
            this.groupBox2.Controls.Add(this.sndjasd);
            this.groupBox2.Controls.Add(this.ejnsd);
            this.groupBox2.Controls.Add(this.asdas);
            this.groupBox2.Controls.Add(this.lababa);
            this.groupBox2.Controls.Add(this.labaelll);
            this.groupBox2.Controls.Add(this.labael);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 162);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txtraiz
            // 
            this.txtraiz.Location = new System.Drawing.Point(383, 109);
            this.txtraiz.Name = "txtraiz";
            this.txtraiz.Size = new System.Drawing.Size(100, 20);
            this.txtraiz.TabIndex = 11;
            // 
            // txtpot
            // 
            this.txtpot.Location = new System.Drawing.Point(383, 73);
            this.txtpot.Name = "txtpot";
            this.txtpot.Size = new System.Drawing.Size(100, 20);
            this.txtpot.TabIndex = 10;
            // 
            // txtdiv
            // 
            this.txtdiv.Location = new System.Drawing.Point(383, 38);
            this.txtdiv.Name = "txtdiv";
            this.txtdiv.Size = new System.Drawing.Size(100, 20);
            this.txtdiv.TabIndex = 9;
            // 
            // txtmulti
            // 
            this.txtmulti.Location = new System.Drawing.Point(162, 109);
            this.txtmulti.Name = "txtmulti";
            this.txtmulti.Size = new System.Drawing.Size(100, 20);
            this.txtmulti.TabIndex = 8;
            // 
            // txtres
            // 
            this.txtres.Location = new System.Drawing.Point(162, 66);
            this.txtres.Name = "txtres";
            this.txtres.Size = new System.Drawing.Size(100, 20);
            this.txtres.TabIndex = 7;
            // 
            // txtsum
            // 
            this.txtsum.Location = new System.Drawing.Point(162, 31);
            this.txtsum.Name = "txtsum";
            this.txtsum.Size = new System.Drawing.Size(100, 20);
            this.txtsum.TabIndex = 6;
            // 
            // sndjasd
            // 
            this.sndjasd.AutoSize = true;
            this.sndjasd.Location = new System.Drawing.Point(268, 116);
            this.sndjasd.Name = "sndjasd";
            this.sndjasd.Size = new System.Drawing.Size(36, 13);
            this.sndjasd.TabIndex = 5;
            this.sndjasd.Text = "RAIZ";
            // 
            // ejnsd
            // 
            this.ejnsd.AutoSize = true;
            this.ejnsd.Location = new System.Drawing.Point(268, 73);
            this.ejnsd.Name = "ejnsd";
            this.ejnsd.Size = new System.Drawing.Size(69, 13);
            this.ejnsd.TabIndex = 4;
            this.ejnsd.Text = "POTENCIA";
            // 
            // asdas
            // 
            this.asdas.AutoSize = true;
            this.asdas.Location = new System.Drawing.Point(268, 38);
            this.asdas.Name = "asdas";
            this.asdas.Size = new System.Drawing.Size(62, 13);
            this.asdas.TabIndex = 3;
            this.asdas.Text = "DIVISION";
            // 
            // lababa
            // 
            this.lababa.AutoSize = true;
            this.lababa.Location = new System.Drawing.Point(19, 116);
            this.lababa.Name = "lababa";
            this.lababa.Size = new System.Drawing.Size(110, 13);
            this.lababa.TabIndex = 2;
            this.lababa.Text = "MULTIPLICACION";
            // 
            // labaelll
            // 
            this.labaelll.AutoSize = true;
            this.labaelll.Location = new System.Drawing.Point(16, 73);
            this.labaelll.Name = "labaelll";
            this.labaelll.Size = new System.Drawing.Size(48, 13);
            this.labaelll.TabIndex = 1;
            this.labaelll.Text = "RESTA";
            // 
            // labael
            // 
            this.labael.AutoSize = true;
            this.labael.Location = new System.Drawing.Point(16, 34);
            this.labael.Name = "labael";
            this.labael.Size = new System.Drawing.Size(42, 13);
            this.labael.TabIndex = 0;
            this.labael.Text = "SUMA";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(504, 349);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "La Cagita Calculadora";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LIMPIAR;
        private System.Windows.Forms.Button CALCULAR;
        private System.Windows.Forms.TextBox NumeroDos;
        private System.Windows.Forms.TextBox NumeroUno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtraiz;
        private System.Windows.Forms.TextBox txtpot;
        private System.Windows.Forms.TextBox txtdiv;
        private System.Windows.Forms.TextBox txtmulti;
        private System.Windows.Forms.TextBox txtres;
        private System.Windows.Forms.TextBox txtsum;
        private System.Windows.Forms.Label sndjasd;
        private System.Windows.Forms.Label ejnsd;
        private System.Windows.Forms.Label asdas;
        private System.Windows.Forms.Label lababa;
        private System.Windows.Forms.Label labaelll;
        private System.Windows.Forms.Label labael;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

