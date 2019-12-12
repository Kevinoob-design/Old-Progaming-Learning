namespace Calculadora_de_Botones_Form
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.btnIGUAL = new System.Windows.Forms.Button();
            this.btnPUNTO = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnNEGATIVO = new System.Windows.Forms.Button();
            this.btnMAS = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnMENOS = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnMULTI = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnDIVIDIR = new System.Windows.Forms.Button();
            this.btnERASE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnANTERIOR = new System.Windows.Forms.Button();
            this.txtENTRADA = new System.Windows.Forms.TextBox();
            this.CajaMagica = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CajaMagica.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIGUAL
            // 
            this.btnIGUAL.BackColor = System.Drawing.Color.Gray;
            this.btnIGUAL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIGUAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIGUAL.ForeColor = System.Drawing.Color.DimGray;
            this.btnIGUAL.Location = new System.Drawing.Point(218, 309);
            this.btnIGUAL.Name = "btnIGUAL";
            this.btnIGUAL.Size = new System.Drawing.Size(65, 45);
            this.btnIGUAL.TabIndex = 19;
            this.btnIGUAL.Text = "=";
            this.btnIGUAL.UseVisualStyleBackColor = false;
            this.btnIGUAL.Click += new System.EventHandler(this.btnIGUAL_Click);
            this.btnIGUAL.MouseEnter += new System.EventHandler(this.Movimiento_Entrada);
            this.btnIGUAL.MouseLeave += new System.EventHandler(this.Movimiento_Salida);
            // 
            // btnPUNTO
            // 
            this.btnPUNTO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPUNTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPUNTO.ForeColor = System.Drawing.Color.DimGray;
            this.btnPUNTO.Location = new System.Drawing.Point(147, 309);
            this.btnPUNTO.Name = "btnPUNTO";
            this.btnPUNTO.Size = new System.Drawing.Size(65, 45);
            this.btnPUNTO.TabIndex = 18;
            this.btnPUNTO.Text = ".";
            this.btnPUNTO.UseVisualStyleBackColor = true;
            this.btnPUNTO.Click += new System.EventHandler(this.btnPUNTO_Click);
            this.btnPUNTO.MouseEnter += new System.EventHandler(this.Movimiento_Entrada);
            this.btnPUNTO.MouseLeave += new System.EventHandler(this.Movimiento_Salida);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.White;
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.DimGray;
            this.btn0.Location = new System.Drawing.Point(76, 309);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(65, 45);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn_Click);
            this.btn0.MouseEnter += new System.EventHandler(this.Movimiento_Entrada);
            this.btn0.MouseLeave += new System.EventHandler(this.Movimiento_Salida);
            // 
            // btnNEGATIVO
            // 
            this.btnNEGATIVO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNEGATIVO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNEGATIVO.ForeColor = System.Drawing.Color.DimGray;
            this.btnNEGATIVO.Location = new System.Drawing.Point(6, 309);
            this.btnNEGATIVO.Name = "btnNEGATIVO";
            this.btnNEGATIVO.Size = new System.Drawing.Size(65, 45);
            this.btnNEGATIVO.TabIndex = 16;
            this.btnNEGATIVO.Text = "+ -";
            this.btnNEGATIVO.UseVisualStyleBackColor = true;
            this.btnNEGATIVO.Click += new System.EventHandler(this.btnNEGATIVO_Click);
            this.btnNEGATIVO.MouseEnter += new System.EventHandler(this.Movimiento_Entrada);
            this.btnNEGATIVO.MouseLeave += new System.EventHandler(this.Movimiento_Salida);
            // 
            // btnMAS
            // 
            this.btnMAS.BackColor = System.Drawing.Color.Gray;
            this.btnMAS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMAS.ForeColor = System.Drawing.Color.DimGray;
            this.btnMAS.Location = new System.Drawing.Point(218, 261);
            this.btnMAS.Name = "btnMAS";
            this.btnMAS.Size = new System.Drawing.Size(65, 45);
            this.btnMAS.TabIndex = 15;
            this.btnMAS.Text = "+";
            this.btnMAS.UseVisualStyleBackColor = false;
            this.btnMAS.Click += new System.EventHandler(this.btnCALCULAR_Click);
            this.btnMAS.MouseEnter += new System.EventHandler(this.Movimiento_Entrada);
            this.btnMAS.MouseLeave += new System.EventHandler(this.Movimiento_Salida);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.DimGray;
            this.btn3.Location = new System.Drawing.Point(147, 261);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(65, 45);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            this.btn3.MouseEnter += new System.EventHandler(this.Movimiento_Entrada);
            this.btn3.MouseLeave += new System.EventHandler(this.Movimiento_Salida);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.DimGray;
            this.btn2.Location = new System.Drawing.Point(76, 261);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(65, 45);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            this.btn2.MouseEnter += new System.EventHandler(this.Movimiento_Entrada);
            this.btn2.MouseLeave += new System.EventHandler(this.Movimiento_Salida);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.DimGray;
            this.btn1.Location = new System.Drawing.Point(6, 261);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(65, 45);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            this.btn1.MouseEnter += new System.EventHandler(this.Movimiento_Entrada);
            this.btn1.MouseLeave += new System.EventHandler(this.Movimiento_Salida);
            // 
            // btnMENOS
            // 
            this.btnMENOS.BackColor = System.Drawing.Color.Gray;
            this.btnMENOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMENOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMENOS.ForeColor = System.Drawing.Color.DimGray;
            this.btnMENOS.Location = new System.Drawing.Point(218, 210);
            this.btnMENOS.Name = "btnMENOS";
            this.btnMENOS.Size = new System.Drawing.Size(65, 45);
            this.btnMENOS.TabIndex = 11;
            this.btnMENOS.Text = "-";
            this.btnMENOS.UseVisualStyleBackColor = false;
            this.btnMENOS.Click += new System.EventHandler(this.btnCALCULAR_Click);
            this.btnMENOS.MouseEnter += new System.EventHandler(this.Movimiento_Entrada);
            this.btnMENOS.MouseLeave += new System.EventHandler(this.Movimiento_Salida);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.White;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.DimGray;
            this.btn6.Location = new System.Drawing.Point(147, 210);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(65, 45);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            this.btn6.MouseEnter += new System.EventHandler(this.Movimiento_Entrada);
            this.btn6.MouseLeave += new System.EventHandler(this.Movimiento_Salida);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.DimGray;
            this.btn5.Location = new System.Drawing.Point(76, 210);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(65, 45);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            this.btn5.MouseEnter += new System.EventHandler(this.Movimiento_Entrada);
            this.btn5.MouseLeave += new System.EventHandler(this.Movimiento_Salida);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.DimGray;
            this.btn4.Location = new System.Drawing.Point(6, 210);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(65, 45);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            this.btn4.MouseEnter += new System.EventHandler(this.Movimiento_Entrada);
            this.btn4.MouseLeave += new System.EventHandler(this.Movimiento_Salida);
            // 
            // btnMULTI
            // 
            this.btnMULTI.BackColor = System.Drawing.Color.Gray;
            this.btnMULTI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMULTI.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMULTI.ForeColor = System.Drawing.Color.DimGray;
            this.btnMULTI.Location = new System.Drawing.Point(218, 159);
            this.btnMULTI.Name = "btnMULTI";
            this.btnMULTI.Size = new System.Drawing.Size(65, 48);
            this.btnMULTI.TabIndex = 7;
            this.btnMULTI.Text = "*";
            this.btnMULTI.UseVisualStyleBackColor = false;
            this.btnMULTI.Click += new System.EventHandler(this.btnCALCULAR_Click);
            this.btnMULTI.MouseEnter += new System.EventHandler(this.Movimiento_Entrada);
            this.btnMULTI.MouseLeave += new System.EventHandler(this.Movimiento_Salida);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.White;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(147, 159);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(65, 45);
            this.btn9.TabIndex = 6;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.White;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(76, 159);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(65, 45);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.White;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(6, 159);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(65, 45);
            this.btn7.TabIndex = 4;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDIVIDIR
            // 
            this.btnDIVIDIR.BackColor = System.Drawing.Color.Gray;
            this.btnDIVIDIR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDIVIDIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDIVIDIR.ForeColor = System.Drawing.Color.DimGray;
            this.btnDIVIDIR.Location = new System.Drawing.Point(218, 108);
            this.btnDIVIDIR.Name = "btnDIVIDIR";
            this.btnDIVIDIR.Size = new System.Drawing.Size(65, 45);
            this.btnDIVIDIR.TabIndex = 3;
            this.btnDIVIDIR.Text = "/";
            this.btnDIVIDIR.UseVisualStyleBackColor = false;
            this.btnDIVIDIR.Click += new System.EventHandler(this.btnCALCULAR_Click);
            this.btnDIVIDIR.MouseEnter += new System.EventHandler(this.Movimiento_Entrada);
            this.btnDIVIDIR.MouseLeave += new System.EventHandler(this.Movimiento_Salida);
            // 
            // btnERASE
            // 
            this.btnERASE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnERASE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnERASE.Location = new System.Drawing.Point(147, 108);
            this.btnERASE.Name = "btnERASE";
            this.btnERASE.Size = new System.Drawing.Size(65, 45);
            this.btnERASE.TabIndex = 2;
            this.btnERASE.Text = "Erase";
            this.btnERASE.UseVisualStyleBackColor = true;
            this.btnERASE.Click += new System.EventHandler(this.btnERASE_Click);
            // 
            // btnC
            // 
            this.btnC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(76, 108);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(65, 45);
            this.btnC.TabIndex = 1;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(6, 108);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(65, 45);
            this.btnCE.TabIndex = 0;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // txtC
            // 
            this.txtC.Enabled = false;
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(236, 10);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(47, 41);
            this.txtC.TabIndex = 4;
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtB
            // 
            this.txtB.Enabled = false;
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(129, 31);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(101, 20);
            this.txtB.TabIndex = 3;
            this.txtB.Text = "0";
            // 
            // txtA
            // 
            this.txtA.Enabled = false;
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(129, 10);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(101, 20);
            this.txtA.TabIndex = 2;
            this.txtA.Text = "0";
            // 
            // btnANTERIOR
            // 
            this.btnANTERIOR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnANTERIOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnANTERIOR.Location = new System.Drawing.Point(9, 10);
            this.btnANTERIOR.Name = "btnANTERIOR";
            this.btnANTERIOR.Size = new System.Drawing.Size(117, 41);
            this.btnANTERIOR.TabIndex = 1;
            this.btnANTERIOR.Text = "RESULTADO ANTERIOR";
            this.btnANTERIOR.UseVisualStyleBackColor = true;
            this.btnANTERIOR.Click += new System.EventHandler(this.btnANTERIOR_Click);
            this.btnANTERIOR.MouseEnter += new System.EventHandler(this.Movimiento3);
            this.btnANTERIOR.MouseLeave += new System.EventHandler(this.Movimiento2);
            this.btnANTERIOR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Movimiento);
            // 
            // txtENTRADA
            // 
            this.txtENTRADA.BackColor = System.Drawing.Color.DarkGray;
            this.txtENTRADA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtENTRADA.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtENTRADA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtENTRADA.Location = new System.Drawing.Point(6, 62);
            this.txtENTRADA.Multiline = true;
            this.txtENTRADA.Name = "txtENTRADA";
            this.txtENTRADA.Size = new System.Drawing.Size(277, 40);
            this.txtENTRADA.TabIndex = 0;
            this.txtENTRADA.Text = "0";
            this.txtENTRADA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtENTRADA.Enter += new System.EventHandler(this.Entrada);
            // 
            // CajaMagica
            // 
            this.CajaMagica.BackColor = System.Drawing.Color.DarkGray;
            this.CajaMagica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CajaMagica.Controls.Add(this.txtC);
            this.CajaMagica.Controls.Add(this.btn6);
            this.CajaMagica.Controls.Add(this.btn5);
            this.CajaMagica.Controls.Add(this.button7);
            this.CajaMagica.Controls.Add(this.btn8);
            this.CajaMagica.Controls.Add(this.btn4);
            this.CajaMagica.Controls.Add(this.btnIGUAL);
            this.CajaMagica.Controls.Add(this.button6);
            this.CajaMagica.Controls.Add(this.btn7);
            this.CajaMagica.Controls.Add(this.txtB);
            this.CajaMagica.Controls.Add(this.btnMULTI);
            this.CajaMagica.Controls.Add(this.txtA);
            this.CajaMagica.Controls.Add(this.btnPUNTO);
            this.CajaMagica.Controls.Add(this.button5);
            this.CajaMagica.Controls.Add(this.btn9);
            this.CajaMagica.Controls.Add(this.btnMENOS);
            this.CajaMagica.Controls.Add(this.button4);
            this.CajaMagica.Controls.Add(this.btnANTERIOR);
            this.CajaMagica.Controls.Add(this.txtENTRADA);
            this.CajaMagica.Controls.Add(this.btn1);
            this.CajaMagica.Controls.Add(this.button3);
            this.CajaMagica.Controls.Add(this.btn0);
            this.CajaMagica.Controls.Add(this.btnCE);
            this.CajaMagica.Controls.Add(this.btn2);
            this.CajaMagica.Controls.Add(this.btnNEGATIVO);
            this.CajaMagica.Controls.Add(this.button2);
            this.CajaMagica.Controls.Add(this.btnDIVIDIR);
            this.CajaMagica.Controls.Add(this.btnC);
            this.CajaMagica.Controls.Add(this.btn3);
            this.CajaMagica.Controls.Add(this.button1);
            this.CajaMagica.Controls.Add(this.btnMAS);
            this.CajaMagica.Controls.Add(this.btnERASE);
            this.CajaMagica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CajaMagica.Location = new System.Drawing.Point(3, 8);
            this.CajaMagica.Name = "CajaMagica";
            this.CajaMagica.Size = new System.Drawing.Size(289, 358);
            this.CajaMagica.TabIndex = 20;
            this.CajaMagica.TabStop = false;
            this.CajaMagica.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LaMagia);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.DimGray;
            this.button7.Location = new System.Drawing.Point(76, 159);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 45);
            this.button7.TabIndex = 5;
            this.button7.Text = "8";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btn_Click);
            this.button7.MouseEnter += new System.EventHandler(this.Movimiento_Entrada);
            this.button7.MouseLeave += new System.EventHandler(this.Movimiento_Salida);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.DimGray;
            this.button6.Location = new System.Drawing.Point(6, 159);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 45);
            this.button6.TabIndex = 4;
            this.button6.Text = "7";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btn_Click);
            this.button6.MouseEnter += new System.EventHandler(this.Movimiento_Entrada);
            this.button6.MouseLeave += new System.EventHandler(this.Movimiento_Salida);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.DimGray;
            this.button5.Location = new System.Drawing.Point(147, 159);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 45);
            this.button5.TabIndex = 6;
            this.button5.Text = "9";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btn_Click);
            this.button5.MouseEnter += new System.EventHandler(this.Movimiento_Entrada);
            this.button5.MouseLeave += new System.EventHandler(this.Movimiento_Salida);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DimGray;
            this.button4.Location = new System.Drawing.Point(9, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 41);
            this.button4.TabIndex = 1;
            this.button4.Text = "RESULTADO ANTERIOR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnANTERIOR_Click);
            this.button4.MouseEnter += new System.EventHandler(this.Movimiento_Entrada);
            this.button4.MouseLeave += new System.EventHandler(this.Movimiento_Salida);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DimGray;
            this.button3.Location = new System.Drawing.Point(6, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 45);
            this.button3.TabIndex = 0;
            this.button3.Text = "CE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnCE_Click);
            this.button3.MouseEnter += new System.EventHandler(this.Movimiento_Entrada);
            this.button3.MouseLeave += new System.EventHandler(this.Movimiento_Salida);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(76, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "C";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnC_Click);
            this.button2.MouseEnter += new System.EventHandler(this.Movimiento_Entrada);
            this.button2.MouseLeave += new System.EventHandler(this.Movimiento_Salida);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(147, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Erase";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnERASE_Click);
            this.button1.MouseEnter += new System.EventHandler(this.Movimiento_Entrada);
            this.button1.MouseLeave += new System.EventHandler(this.Movimiento_Salida);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(298, 371);
            this.Controls.Add(this.CajaMagica);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora :v";
            this.CajaMagica.ResumeLayout(false);
            this.CajaMagica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDIVIDIR;
        private System.Windows.Forms.Button btnERASE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnIGUAL;
        private System.Windows.Forms.Button btnPUNTO;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnNEGATIVO;
        private System.Windows.Forms.Button btnMAS;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnMENOS;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnMULTI;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.TextBox txtENTRADA;
        private System.Windows.Forms.Button btnANTERIOR;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.GroupBox CajaMagica;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

