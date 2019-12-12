namespace Sistema_Control_Estudiantil
{
    partial class InformationStudentInterface
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
            this.LoadPanel = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtLastName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDate = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrimaryNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSecondaryNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtContactEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDOB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPOB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDocumentID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label11 = new System.Windows.Forms.Label();
            this.ckM = new MaterialSkin.Controls.MaterialCheckBox();
            this.ckF = new MaterialSkin.Controls.MaterialCheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LoadPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadPanel
            // 
            this.LoadPanel.Controls.Add(this.ckF);
            this.LoadPanel.Controls.Add(this.ckM);
            this.LoadPanel.Controls.Add(this.txtAddress);
            this.LoadPanel.Controls.Add(this.txtContactEmail);
            this.LoadPanel.Controls.Add(this.txtDocumentID);
            this.LoadPanel.Controls.Add(this.txtSecondaryNumber);
            this.LoadPanel.Controls.Add(this.txtPOB);
            this.LoadPanel.Controls.Add(this.txtPrimaryNumber);
            this.LoadPanel.Controls.Add(this.txtDOB);
            this.LoadPanel.Controls.Add(this.txtDate);
            this.LoadPanel.Controls.Add(this.txtLastName);
            this.LoadPanel.Controls.Add(this.txtName);
            this.LoadPanel.Controls.Add(this.btnCancelar);
            this.LoadPanel.Controls.Add(this.btnGuardar);
            this.LoadPanel.Controls.Add(this.btnEditar);
            this.LoadPanel.Controls.Add(this.label10);
            this.LoadPanel.Controls.Add(this.label3);
            this.LoadPanel.Controls.Add(this.label11);
            this.LoadPanel.Controls.Add(this.label9);
            this.LoadPanel.Controls.Add(this.label4);
            this.LoadPanel.Controls.Add(this.label8);
            this.LoadPanel.Controls.Add(this.label2);
            this.LoadPanel.Controls.Add(this.label5);
            this.LoadPanel.Controls.Add(this.label6);
            this.LoadPanel.Controls.Add(this.label7);
            this.LoadPanel.Controls.Add(this.label1);
            this.LoadPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadPanel.Location = new System.Drawing.Point(0, 0);
            this.LoadPanel.Name = "LoadPanel";
            this.LoadPanel.Size = new System.Drawing.Size(898, 555);
            this.LoadPanel.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(393, 498);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(166, 45);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(207, 498);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(166, 45);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(21, 498);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(166, 45);
            this.btnEditar.TabIndex = 24;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "Secondary number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 31);
            this.label4.TabIndex = 19;
            this.label4.Text = "Contact email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "Primary number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(452, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 31);
            this.label6.TabIndex = 21;
            this.label6.Text = "Last name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Active since:";
            // 
            // txtName
            // 
            this.txtName.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.txtName.Depth = 0;
            this.txtName.Enabled = false;
            this.txtName.Hint = "";
            this.txtName.Location = new System.Drawing.Point(29, 60);
            this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(235, 23);
            this.txtName.TabIndex = 18;
            this.txtName.TabStop = false;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // txtLastName
            // 
            this.txtLastName.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.txtLastName.Depth = 0;
            this.txtLastName.Enabled = false;
            this.txtLastName.Hint = "";
            this.txtLastName.Location = new System.Drawing.Point(458, 60);
            this.txtLastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.SelectedText = "";
            this.txtLastName.SelectionLength = 0;
            this.txtLastName.SelectionStart = 0;
            this.txtLastName.Size = new System.Drawing.Size(235, 23);
            this.txtLastName.TabIndex = 18;
            this.txtLastName.TabStop = false;
            this.txtLastName.UseSystemPasswordChar = false;
            // 
            // txtDate
            // 
            this.txtDate.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.txtDate.Depth = 0;
            this.txtDate.Enabled = false;
            this.txtDate.Hint = "";
            this.txtDate.Location = new System.Drawing.Point(29, 136);
            this.txtDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDate.Name = "txtDate";
            this.txtDate.PasswordChar = '\0';
            this.txtDate.SelectedText = "";
            this.txtDate.SelectionLength = 0;
            this.txtDate.SelectionStart = 0;
            this.txtDate.Size = new System.Drawing.Size(235, 23);
            this.txtDate.TabIndex = 18;
            this.txtDate.TabStop = false;
            this.txtDate.UseSystemPasswordChar = false;
            // 
            // txtPrimaryNumber
            // 
            this.txtPrimaryNumber.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.txtPrimaryNumber.Depth = 0;
            this.txtPrimaryNumber.Hint = "(800)-123-4567";
            this.txtPrimaryNumber.Location = new System.Drawing.Point(29, 217);
            this.txtPrimaryNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrimaryNumber.Name = "txtPrimaryNumber";
            this.txtPrimaryNumber.PasswordChar = '\0';
            this.txtPrimaryNumber.SelectedText = "";
            this.txtPrimaryNumber.SelectionLength = 0;
            this.txtPrimaryNumber.SelectionStart = 0;
            this.txtPrimaryNumber.Size = new System.Drawing.Size(235, 23);
            this.txtPrimaryNumber.TabIndex = 18;
            this.txtPrimaryNumber.TabStop = false;
            this.txtPrimaryNumber.UseSystemPasswordChar = false;
            // 
            // txtSecondaryNumber
            // 
            this.txtSecondaryNumber.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.txtSecondaryNumber.Depth = 0;
            this.txtSecondaryNumber.Hint = "(800)-123-4567";
            this.txtSecondaryNumber.Location = new System.Drawing.Point(29, 301);
            this.txtSecondaryNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSecondaryNumber.Name = "txtSecondaryNumber";
            this.txtSecondaryNumber.PasswordChar = '\0';
            this.txtSecondaryNumber.SelectedText = "";
            this.txtSecondaryNumber.SelectionLength = 0;
            this.txtSecondaryNumber.SelectionStart = 0;
            this.txtSecondaryNumber.Size = new System.Drawing.Size(235, 23);
            this.txtSecondaryNumber.TabIndex = 18;
            this.txtSecondaryNumber.TabStop = false;
            this.txtSecondaryNumber.UseSystemPasswordChar = false;
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.txtContactEmail.Depth = 0;
            this.txtContactEmail.Hint = "YourEmail@Email.com";
            this.txtContactEmail.Location = new System.Drawing.Point(29, 383);
            this.txtContactEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.PasswordChar = '\0';
            this.txtContactEmail.SelectedText = "";
            this.txtContactEmail.SelectionLength = 0;
            this.txtContactEmail.SelectionStart = 0;
            this.txtContactEmail.Size = new System.Drawing.Size(235, 23);
            this.txtContactEmail.TabIndex = 18;
            this.txtContactEmail.TabStop = false;
            this.txtContactEmail.UseSystemPasswordChar = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(452, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 31);
            this.label7.TabIndex = 23;
            this.label7.Text = "Date of birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(452, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 31);
            this.label8.TabIndex = 20;
            this.label8.Text = "Place of birth";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(452, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 31);
            this.label9.TabIndex = 19;
            this.label9.Text = "Gender";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(452, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 31);
            this.label10.TabIndex = 18;
            this.label10.Text = "Document ID";
            // 
            // txtDOB
            // 
            this.txtDOB.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.txtDOB.Depth = 0;
            this.txtDOB.Hint = "Month / Day / Year";
            this.txtDOB.Location = new System.Drawing.Point(458, 136);
            this.txtDOB.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.PasswordChar = '\0';
            this.txtDOB.SelectedText = "";
            this.txtDOB.SelectionLength = 0;
            this.txtDOB.SelectionStart = 0;
            this.txtDOB.Size = new System.Drawing.Size(235, 23);
            this.txtDOB.TabIndex = 18;
            this.txtDOB.TabStop = false;
            this.txtDOB.UseSystemPasswordChar = false;
            // 
            // txtPOB
            // 
            this.txtPOB.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.txtPOB.Depth = 0;
            this.txtPOB.Hint = "Where is your birth place?";
            this.txtPOB.Location = new System.Drawing.Point(458, 217);
            this.txtPOB.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPOB.Name = "txtPOB";
            this.txtPOB.PasswordChar = '\0';
            this.txtPOB.SelectedText = "";
            this.txtPOB.SelectionLength = 0;
            this.txtPOB.SelectionStart = 0;
            this.txtPOB.Size = new System.Drawing.Size(235, 23);
            this.txtPOB.TabIndex = 18;
            this.txtPOB.TabStop = false;
            this.txtPOB.UseSystemPasswordChar = false;
            // 
            // txtDocumentID
            // 
            this.txtDocumentID.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.txtDocumentID.Depth = 0;
            this.txtDocumentID.Hint = "000-0000000-0";
            this.txtDocumentID.Location = new System.Drawing.Point(458, 301);
            this.txtDocumentID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDocumentID.Name = "txtDocumentID";
            this.txtDocumentID.PasswordChar = '\0';
            this.txtDocumentID.SelectedText = "";
            this.txtDocumentID.SelectionLength = 0;
            this.txtDocumentID.SelectionStart = 0;
            this.txtDocumentID.Size = new System.Drawing.Size(235, 23);
            this.txtDocumentID.TabIndex = 18;
            this.txtDocumentID.TabStop = false;
            this.txtDocumentID.UseSystemPasswordChar = false;
            // 
            // txtAddress
            // 
            this.txtAddress.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.txtAddress.Depth = 0;
            this.txtAddress.Hint = "Street, Sector, City, Country, Zip";
            this.txtAddress.Location = new System.Drawing.Point(29, 456);
            this.txtAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.Size = new System.Drawing.Size(664, 23);
            this.txtAddress.TabIndex = 18;
            this.txtAddress.TabStop = false;
            this.txtAddress.UseSystemPasswordChar = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 422);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 31);
            this.label11.TabIndex = 19;
            this.label11.Text = "Address";
            // 
            // ckM
            // 
            this.ckM.AutoSize = true;
            this.ckM.Depth = 0;
            this.ckM.Font = new System.Drawing.Font("Roboto", 15F);
            this.ckM.Location = new System.Drawing.Point(458, 393);
            this.ckM.Margin = new System.Windows.Forms.Padding(0);
            this.ckM.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckM.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckM.Name = "ckM";
            this.ckM.Ripple = true;
            this.ckM.Size = new System.Drawing.Size(93, 30);
            this.ckM.TabIndex = 25;
            this.ckM.Text = "Masculine";
            this.ckM.UseVisualStyleBackColor = true;
            this.ckM.CheckedChanged += new System.EventHandler(this.ckM_CheckedChanged);
            // 
            // ckF
            // 
            this.ckF.AutoSize = true;
            this.ckF.Depth = 0;
            this.ckF.Font = new System.Drawing.Font("Roboto", 15F);
            this.ckF.Location = new System.Drawing.Point(603, 393);
            this.ckF.Margin = new System.Windows.Forms.Padding(0);
            this.ckF.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckF.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckF.Name = "ckF";
            this.ckF.Ripple = true;
            this.ckF.Size = new System.Drawing.Size(90, 30);
            this.ckF.TabIndex = 25;
            this.ckF.Text = "Femenine";
            this.ckF.UseVisualStyleBackColor = true;
            this.ckF.CheckedChanged += new System.EventHandler(this.ckF_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 31);
            this.label5.TabIndex = 21;
            this.label5.Text = "Name";
            // 
            // InformationStudentInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 555);
            this.Controls.Add(this.LoadPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(898, 555);
            this.Name = "InformationStudentInterface";
            this.Text = "InformationStudentInterface";
            this.Load += new System.EventHandler(this.InformationStudentInterface_Load);
            this.LoadPanel.ResumeLayout(false);
            this.LoadPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoadPanel;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLastName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContactEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSecondaryNumber;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrimaryNumber;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDate;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDocumentID;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPOB;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDOB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAddress;
        private System.Windows.Forms.Label label11;
        private MaterialSkin.Controls.MaterialCheckBox ckF;
        private MaterialSkin.Controls.MaterialCheckBox ckM;
        private System.Windows.Forms.Label label5;
    }
}