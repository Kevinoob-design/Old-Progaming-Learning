namespace Metodo_Dentro_De_Evento
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
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.NumPad7 = new System.Windows.Forms.Button();
            this.NumPad8 = new System.Windows.Forms.Button();
            this.NumPad9 = new System.Windows.Forms.Button();
            this.NumPad4 = new System.Windows.Forms.Button();
            this.NumPad5 = new System.Windows.Forms.Button();
            this.NumPad6 = new System.Windows.Forms.Button();
            this.NumPad1 = new System.Windows.Forms.Button();
            this.NumPad2 = new System.Windows.Forms.Button();
            this.NumPad3 = new System.Windows.Forms.Button();
            this.NumPad0 = new System.Windows.Forms.Button();
            this.LaDelFoco = new System.Windows.Forms.GroupBox();
            this.LaDelFoco.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEntrada
            // 
            this.txtEntrada.Enabled = false;
            this.txtEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.Location = new System.Drawing.Point(6, 19);
            this.txtEntrada.Multiline = true;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEntrada.Size = new System.Drawing.Size(225, 38);
            this.txtEntrada.TabIndex = 0;
            this.txtEntrada.Text = "0";
            // 
            // NumPad7
            // 
            this.NumPad7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumPad7.Location = new System.Drawing.Point(6, 63);
            this.NumPad7.Name = "NumPad7";
            this.NumPad7.Size = new System.Drawing.Size(71, 61);
            this.NumPad7.TabIndex = 1;
            this.NumPad7.Text = "7";
            this.NumPad7.UseVisualStyleBackColor = true;
            this.NumPad7.Click += new System.EventHandler(this.ClickNormal);
            // 
            // NumPad8
            // 
            this.NumPad8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumPad8.Location = new System.Drawing.Point(83, 63);
            this.NumPad8.Name = "NumPad8";
            this.NumPad8.Size = new System.Drawing.Size(71, 61);
            this.NumPad8.TabIndex = 2;
            this.NumPad8.Text = "8";
            this.NumPad8.UseVisualStyleBackColor = true;
            this.NumPad8.Click += new System.EventHandler(this.ClickNormal);
            // 
            // NumPad9
            // 
            this.NumPad9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumPad9.Location = new System.Drawing.Point(160, 63);
            this.NumPad9.Name = "NumPad9";
            this.NumPad9.Size = new System.Drawing.Size(71, 61);
            this.NumPad9.TabIndex = 3;
            this.NumPad9.Text = "9";
            this.NumPad9.UseVisualStyleBackColor = true;
            this.NumPad9.Click += new System.EventHandler(this.ClickNormal);
            // 
            // NumPad4
            // 
            this.NumPad4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumPad4.Location = new System.Drawing.Point(6, 130);
            this.NumPad4.Name = "NumPad4";
            this.NumPad4.Size = new System.Drawing.Size(71, 61);
            this.NumPad4.TabIndex = 4;
            this.NumPad4.Text = "4";
            this.NumPad4.UseVisualStyleBackColor = true;
            this.NumPad4.Click += new System.EventHandler(this.ClickNormal);
            // 
            // NumPad5
            // 
            this.NumPad5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumPad5.Location = new System.Drawing.Point(83, 130);
            this.NumPad5.Name = "NumPad5";
            this.NumPad5.Size = new System.Drawing.Size(71, 61);
            this.NumPad5.TabIndex = 5;
            this.NumPad5.Text = "5";
            this.NumPad5.UseVisualStyleBackColor = true;
            this.NumPad5.Click += new System.EventHandler(this.ClickNormal);
            // 
            // NumPad6
            // 
            this.NumPad6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumPad6.Location = new System.Drawing.Point(160, 130);
            this.NumPad6.Name = "NumPad6";
            this.NumPad6.Size = new System.Drawing.Size(71, 61);
            this.NumPad6.TabIndex = 6;
            this.NumPad6.Text = "6";
            this.NumPad6.UseVisualStyleBackColor = true;
            this.NumPad6.Click += new System.EventHandler(this.ClickNormal);
            // 
            // NumPad1
            // 
            this.NumPad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumPad1.Location = new System.Drawing.Point(6, 197);
            this.NumPad1.Name = "NumPad1";
            this.NumPad1.Size = new System.Drawing.Size(71, 61);
            this.NumPad1.TabIndex = 7;
            this.NumPad1.Text = "1";
            this.NumPad1.UseVisualStyleBackColor = true;
            this.NumPad1.Click += new System.EventHandler(this.ClickNormal);
            // 
            // NumPad2
            // 
            this.NumPad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumPad2.Location = new System.Drawing.Point(83, 197);
            this.NumPad2.Name = "NumPad2";
            this.NumPad2.Size = new System.Drawing.Size(71, 61);
            this.NumPad2.TabIndex = 8;
            this.NumPad2.Text = "2";
            this.NumPad2.UseVisualStyleBackColor = true;
            this.NumPad2.Click += new System.EventHandler(this.ClickNormal);
            // 
            // NumPad3
            // 
            this.NumPad3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumPad3.Location = new System.Drawing.Point(160, 197);
            this.NumPad3.Name = "NumPad3";
            this.NumPad3.Size = new System.Drawing.Size(71, 61);
            this.NumPad3.TabIndex = 9;
            this.NumPad3.Text = "3";
            this.NumPad3.UseVisualStyleBackColor = true;
            this.NumPad3.Click += new System.EventHandler(this.ClickNormal);
            // 
            // NumPad0
            // 
            this.NumPad0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumPad0.Location = new System.Drawing.Point(83, 264);
            this.NumPad0.Name = "NumPad0";
            this.NumPad0.Size = new System.Drawing.Size(71, 61);
            this.NumPad0.TabIndex = 10;
            this.NumPad0.Text = "0";
            this.NumPad0.UseVisualStyleBackColor = true;
            this.NumPad0.Click += new System.EventHandler(this.ClickNormal);
            // 
            // LaDelFoco
            // 
            this.LaDelFoco.Controls.Add(this.txtEntrada);
            this.LaDelFoco.Controls.Add(this.NumPad0);
            this.LaDelFoco.Controls.Add(this.NumPad7);
            this.LaDelFoco.Controls.Add(this.NumPad3);
            this.LaDelFoco.Controls.Add(this.NumPad8);
            this.LaDelFoco.Controls.Add(this.NumPad2);
            this.LaDelFoco.Controls.Add(this.NumPad9);
            this.LaDelFoco.Controls.Add(this.NumPad1);
            this.LaDelFoco.Controls.Add(this.NumPad4);
            this.LaDelFoco.Controls.Add(this.NumPad6);
            this.LaDelFoco.Controls.Add(this.NumPad5);
            this.LaDelFoco.Location = new System.Drawing.Point(9, 12);
            this.LaDelFoco.Name = "LaDelFoco";
            this.LaDelFoco.Size = new System.Drawing.Size(239, 331);
            this.LaDelFoco.TabIndex = 11;
            this.LaDelFoco.TabStop = false;
            this.LaDelFoco.Text = "groupBox1";
            this.LaDelFoco.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FOCO);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 353);
            this.Controls.Add(this.LaDelFoco);
            this.Name = "Form1";
            this.Text = "Form1";
            this.LaDelFoco.ResumeLayout(false);
            this.LaDelFoco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Button NumPad7;
        private System.Windows.Forms.Button NumPad8;
        private System.Windows.Forms.Button NumPad9;
        private System.Windows.Forms.Button NumPad4;
        private System.Windows.Forms.Button NumPad5;
        private System.Windows.Forms.Button NumPad6;
        private System.Windows.Forms.Button NumPad1;
        private System.Windows.Forms.Button NumPad2;
        private System.Windows.Forms.Button NumPad3;
        private System.Windows.Forms.Button NumPad0;
        private System.Windows.Forms.GroupBox LaDelFoco;
    }
}

