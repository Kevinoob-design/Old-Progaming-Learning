namespace Mi_Nueva_Calculadora_En_Form
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
            this.btnvalidar = new System.Windows.Forms.Button();
            this.numcantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.numcreditos7 = new System.Windows.Forms.NumericUpDown();
            this.numcreditos6 = new System.Windows.Forms.NumericUpDown();
            this.numcreditos5 = new System.Windows.Forms.NumericUpDown();
            this.numcreditos4 = new System.Windows.Forms.NumericUpDown();
            this.numcreditos3 = new System.Windows.Forms.NumericUpDown();
            this.numcreditos2 = new System.Windows.Forms.NumericUpDown();
            this.numcreditos1 = new System.Windows.Forms.NumericUpDown();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmateria7 = new System.Windows.Forms.TextBox();
            this.txtmateria6 = new System.Windows.Forms.TextBox();
            this.txtmateria5 = new System.Windows.Forms.TextBox();
            this.txtmateria4 = new System.Windows.Forms.TextBox();
            this.txtmateria3 = new System.Windows.Forms.TextBox();
            this.txtmateria2 = new System.Windows.Forms.TextBox();
            this.txtmateria1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtpromedio = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtliteral4 = new System.Windows.Forms.TextBox();
            this.txtliteral3 = new System.Windows.Forms.TextBox();
            this.txtliteral6 = new System.Windows.Forms.TextBox();
            this.txtliteral7 = new System.Windows.Forms.TextBox();
            this.txtliteral5 = new System.Windows.Forms.TextBox();
            this.txtliteral2 = new System.Windows.Forms.TextBox();
            this.txtliteral1 = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numcantidad)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numcreditos7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numcreditos6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numcreditos5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numcreditos4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numcreditos3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numcreditos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numcreditos1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnvalidar);
            this.groupBox1.Controls.Add(this.numcantidad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnvalidar
            // 
            this.btnvalidar.BackColor = System.Drawing.Color.Aqua;
            this.btnvalidar.Location = new System.Drawing.Point(56, 35);
            this.btnvalidar.Name = "btnvalidar";
            this.btnvalidar.Size = new System.Drawing.Size(136, 23);
            this.btnvalidar.TabIndex = 2;
            this.btnvalidar.Text = "VALIDAR MATERIAS";
            this.btnvalidar.UseVisualStyleBackColor = false;
            this.btnvalidar.Click += new System.EventHandler(this.btnvalidar_Click);
            // 
            // numcantidad
            // 
            this.numcantidad.Location = new System.Drawing.Point(10, 38);
            this.numcantidad.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numcantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numcantidad.Name = "numcantidad";
            this.numcantidad.Size = new System.Drawing.Size(40, 20);
            this.numcantidad.TabIndex = 1;
            this.numcantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Cantidad De Materias Seleccionadas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.numcreditos7);
            this.groupBox2.Controls.Add(this.numcreditos6);
            this.groupBox2.Controls.Add(this.numcreditos5);
            this.groupBox2.Controls.Add(this.numcreditos4);
            this.groupBox2.Controls.Add(this.numcreditos3);
            this.groupBox2.Controls.Add(this.numcreditos2);
            this.groupBox2.Controls.Add(this.numcreditos1);
            this.groupBox2.Controls.Add(this.btnnuevo);
            this.groupBox2.Controls.Add(this.btncalcular);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtmateria7);
            this.groupBox2.Controls.Add(this.txtmateria6);
            this.groupBox2.Controls.Add(this.txtmateria5);
            this.groupBox2.Controls.Add(this.txtmateria4);
            this.groupBox2.Controls.Add(this.txtmateria3);
            this.groupBox2.Controls.Add(this.txtmateria2);
            this.groupBox2.Controls.Add(this.txtmateria1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(297, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 251);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entrada De Datos";
            // 
            // listBox2
            // 
            this.listBox2.Enabled = false;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Items.AddRange(new object[] {
            "Ingrese ",
            "El",
            "Valor",
            "De",
            "Los",
            "Creditos",
            "Al Lado",
            "De Cada",
            "Materia"});
            this.listBox2.Location = new System.Drawing.Point(242, 16);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(84, 184);
            this.listBox2.TabIndex = 6;
            // 
            // numcreditos7
            // 
            this.numcreditos7.Enabled = false;
            this.numcreditos7.Location = new System.Drawing.Point(200, 180);
            this.numcreditos7.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numcreditos7.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numcreditos7.Name = "numcreditos7";
            this.numcreditos7.Size = new System.Drawing.Size(36, 21);
            this.numcreditos7.TabIndex = 22;
            this.numcreditos7.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numcreditos6
            // 
            this.numcreditos6.Enabled = false;
            this.numcreditos6.Location = new System.Drawing.Point(200, 154);
            this.numcreditos6.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numcreditos6.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numcreditos6.Name = "numcreditos6";
            this.numcreditos6.Size = new System.Drawing.Size(36, 21);
            this.numcreditos6.TabIndex = 21;
            this.numcreditos6.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numcreditos5
            // 
            this.numcreditos5.Enabled = false;
            this.numcreditos5.Location = new System.Drawing.Point(200, 126);
            this.numcreditos5.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numcreditos5.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numcreditos5.Name = "numcreditos5";
            this.numcreditos5.Size = new System.Drawing.Size(36, 21);
            this.numcreditos5.TabIndex = 20;
            this.numcreditos5.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numcreditos4
            // 
            this.numcreditos4.Enabled = false;
            this.numcreditos4.Location = new System.Drawing.Point(200, 100);
            this.numcreditos4.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numcreditos4.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numcreditos4.Name = "numcreditos4";
            this.numcreditos4.Size = new System.Drawing.Size(36, 21);
            this.numcreditos4.TabIndex = 19;
            this.numcreditos4.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numcreditos3
            // 
            this.numcreditos3.Enabled = false;
            this.numcreditos3.Location = new System.Drawing.Point(200, 70);
            this.numcreditos3.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numcreditos3.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numcreditos3.Name = "numcreditos3";
            this.numcreditos3.Size = new System.Drawing.Size(36, 21);
            this.numcreditos3.TabIndex = 18;
            this.numcreditos3.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numcreditos2
            // 
            this.numcreditos2.Enabled = false;
            this.numcreditos2.Location = new System.Drawing.Point(200, 44);
            this.numcreditos2.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numcreditos2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numcreditos2.Name = "numcreditos2";
            this.numcreditos2.Size = new System.Drawing.Size(36, 21);
            this.numcreditos2.TabIndex = 17;
            this.numcreditos2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numcreditos1
            // 
            this.numcreditos1.Enabled = false;
            this.numcreditos1.Location = new System.Drawing.Point(200, 19);
            this.numcreditos1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numcreditos1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numcreditos1.Name = "numcreditos1";
            this.numcreditos1.Size = new System.Drawing.Size(36, 21);
            this.numcreditos1.TabIndex = 16;
            this.numcreditos1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.Lime;
            this.btnnuevo.Location = new System.Drawing.Point(157, 222);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(132, 23);
            this.btnnuevo.TabIndex = 15;
            this.btnnuevo.Text = "NUEVO INDICE";
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.Lime;
            this.btncalcular.Location = new System.Drawing.Point(10, 222);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(141, 23);
            this.btncalcular.TabIndex = 14;
            this.btncalcular.Text = "CALCULAR INDICE";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Materia 7:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Materia 6:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Materia 5:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Materia 4:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Materia 3:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Materia 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Materia 1:";
            // 
            // txtmateria7
            // 
            this.txtmateria7.Enabled = false;
            this.txtmateria7.Location = new System.Drawing.Point(94, 180);
            this.txtmateria7.Name = "txtmateria7";
            this.txtmateria7.Size = new System.Drawing.Size(100, 21);
            this.txtmateria7.TabIndex = 6;
            this.txtmateria7.Text = "No Disponible";
            // 
            // txtmateria6
            // 
            this.txtmateria6.Enabled = false;
            this.txtmateria6.Location = new System.Drawing.Point(94, 153);
            this.txtmateria6.Name = "txtmateria6";
            this.txtmateria6.Size = new System.Drawing.Size(100, 21);
            this.txtmateria6.TabIndex = 5;
            this.txtmateria6.Text = "No Disponible";
            // 
            // txtmateria5
            // 
            this.txtmateria5.Enabled = false;
            this.txtmateria5.Location = new System.Drawing.Point(94, 126);
            this.txtmateria5.Name = "txtmateria5";
            this.txtmateria5.Size = new System.Drawing.Size(100, 21);
            this.txtmateria5.TabIndex = 4;
            this.txtmateria5.Text = "No Disponible";
            // 
            // txtmateria4
            // 
            this.txtmateria4.Enabled = false;
            this.txtmateria4.Location = new System.Drawing.Point(94, 99);
            this.txtmateria4.Name = "txtmateria4";
            this.txtmateria4.Size = new System.Drawing.Size(100, 21);
            this.txtmateria4.TabIndex = 3;
            this.txtmateria4.Text = "No Disponible";
            // 
            // txtmateria3
            // 
            this.txtmateria3.Enabled = false;
            this.txtmateria3.Location = new System.Drawing.Point(94, 72);
            this.txtmateria3.Name = "txtmateria3";
            this.txtmateria3.Size = new System.Drawing.Size(100, 21);
            this.txtmateria3.TabIndex = 2;
            this.txtmateria3.Text = "No Disponible";
            // 
            // txtmateria2
            // 
            this.txtmateria2.Enabled = false;
            this.txtmateria2.Location = new System.Drawing.Point(94, 48);
            this.txtmateria2.Name = "txtmateria2";
            this.txtmateria2.Size = new System.Drawing.Size(100, 21);
            this.txtmateria2.TabIndex = 1;
            this.txtmateria2.Text = "No Disponible";
            // 
            // txtmateria1
            // 
            this.txtmateria1.Enabled = false;
            this.txtmateria1.Location = new System.Drawing.Point(94, 20);
            this.txtmateria1.Name = "txtmateria1";
            this.txtmateria1.Size = new System.Drawing.Size(100, 21);
            this.txtmateria1.TabIndex = 0;
            this.txtmateria1.Text = "No Disponible";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtpromedio);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtliteral4);
            this.groupBox3.Controls.Add(this.txtliteral3);
            this.groupBox3.Controls.Add(this.txtliteral6);
            this.groupBox3.Controls.Add(this.txtliteral7);
            this.groupBox3.Controls.Add(this.txtliteral5);
            this.groupBox3.Controls.Add(this.txtliteral2);
            this.groupBox3.Controls.Add(this.txtliteral1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 242);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salida De Datos";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(45, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(206, 15);
            this.label17.TabIndex = 16;
            this.label17.Text = "IMPRESION DE NOTA LITERAL";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 15);
            this.label16.TabIndex = 15;
            this.label16.Text = "Su Promedio Es De:";
            // 
            // txtpromedio
            // 
            this.txtpromedio.Location = new System.Drawing.Point(146, 47);
            this.txtpromedio.Name = "txtpromedio";
            this.txtpromedio.ReadOnly = true;
            this.txtpromedio.Size = new System.Drawing.Size(59, 21);
            this.txtpromedio.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(160, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 15);
            this.label15.TabIndex = 13;
            this.label15.Text = "Materia 7:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(160, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "Materia 6:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(159, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 15);
            this.label13.TabIndex = 11;
            this.label13.Text = "Materia 5:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "Materia 4:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Materia 3:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Materia 2:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Materia 1:";
            // 
            // txtliteral4
            // 
            this.txtliteral4.Location = new System.Drawing.Point(84, 216);
            this.txtliteral4.Name = "txtliteral4";
            this.txtliteral4.ReadOnly = true;
            this.txtliteral4.Size = new System.Drawing.Size(40, 21);
            this.txtliteral4.TabIndex = 6;
            // 
            // txtliteral3
            // 
            this.txtliteral3.Location = new System.Drawing.Point(84, 190);
            this.txtliteral3.Name = "txtliteral3";
            this.txtliteral3.ReadOnly = true;
            this.txtliteral3.Size = new System.Drawing.Size(40, 21);
            this.txtliteral3.TabIndex = 5;
            // 
            // txtliteral6
            // 
            this.txtliteral6.Location = new System.Drawing.Point(239, 168);
            this.txtliteral6.Name = "txtliteral6";
            this.txtliteral6.ReadOnly = true;
            this.txtliteral6.Size = new System.Drawing.Size(40, 21);
            this.txtliteral6.TabIndex = 4;
            // 
            // txtliteral7
            // 
            this.txtliteral7.Location = new System.Drawing.Point(239, 197);
            this.txtliteral7.Name = "txtliteral7";
            this.txtliteral7.ReadOnly = true;
            this.txtliteral7.Size = new System.Drawing.Size(40, 21);
            this.txtliteral7.TabIndex = 3;
            // 
            // txtliteral5
            // 
            this.txtliteral5.Location = new System.Drawing.Point(239, 142);
            this.txtliteral5.Name = "txtliteral5";
            this.txtliteral5.ReadOnly = true;
            this.txtliteral5.Size = new System.Drawing.Size(40, 21);
            this.txtliteral5.TabIndex = 2;
            // 
            // txtliteral2
            // 
            this.txtliteral2.Location = new System.Drawing.Point(84, 164);
            this.txtliteral2.Name = "txtliteral2";
            this.txtliteral2.ReadOnly = true;
            this.txtliteral2.Size = new System.Drawing.Size(40, 21);
            this.txtliteral2.TabIndex = 1;
            // 
            // txtliteral1
            // 
            this.txtliteral1.Location = new System.Drawing.Point(84, 138);
            this.txtliteral1.Name = "txtliteral1";
            this.txtliteral1.ReadOnly = true;
            this.txtliteral1.Size = new System.Drawing.Size(40, 21);
            this.txtliteral1.TabIndex = 0;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Red;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(416, 309);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.btnsalir);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(645, 346);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Calculadora De Indice ITSC.";
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Para desbloquear la entrada de Datos. Primero:",
            "Debe ingresar la cantidad de materias cursadas."});
            this.listBox1.Location = new System.Drawing.Point(12, 364);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(399, 44);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(659, 414);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numcantidad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numcreditos7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numcreditos6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numcreditos5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numcreditos4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numcreditos3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numcreditos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numcreditos1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtpromedio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtliteral4;
        private System.Windows.Forms.TextBox txtliteral3;
        private System.Windows.Forms.TextBox txtliteral6;
        private System.Windows.Forms.TextBox txtliteral7;
        private System.Windows.Forms.TextBox txtliteral5;
        private System.Windows.Forms.TextBox txtliteral2;
        private System.Windows.Forms.TextBox txtliteral1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmateria7;
        private System.Windows.Forms.TextBox txtmateria6;
        private System.Windows.Forms.TextBox txtmateria5;
        private System.Windows.Forms.TextBox txtmateria4;
        private System.Windows.Forms.TextBox txtmateria3;
        private System.Windows.Forms.TextBox txtmateria2;
        private System.Windows.Forms.TextBox txtmateria1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnvalidar;
        private System.Windows.Forms.NumericUpDown numcantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown numcreditos7;
        private System.Windows.Forms.NumericUpDown numcreditos6;
        private System.Windows.Forms.NumericUpDown numcreditos5;
        private System.Windows.Forms.NumericUpDown numcreditos4;
        private System.Windows.Forms.NumericUpDown numcreditos3;
        private System.Windows.Forms.NumericUpDown numcreditos2;
        private System.Windows.Forms.NumericUpDown numcreditos1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

