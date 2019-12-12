namespace Sistema_Control_Estudiantil
{
    partial class StudentLogin
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
            this.btnTeacherOption = new System.Windows.Forms.Button();
            this.txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // btnTeacherOption
            // 
            this.btnTeacherOption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTeacherOption.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTeacherOption.FlatAppearance.BorderSize = 0;
            this.btnTeacherOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherOption.ForeColor = System.Drawing.Color.White;
            this.btnTeacherOption.Location = new System.Drawing.Point(57, 187);
            this.btnTeacherOption.Name = "btnTeacherOption";
            this.btnTeacherOption.Size = new System.Drawing.Size(265, 47);
            this.btnTeacherOption.TabIndex = 11;
            this.btnTeacherOption.Text = "Login";
            this.btnTeacherOption.UseVisualStyleBackColor = false;
            this.btnTeacherOption.Click += new System.EventHandler(this.btnStudentOption_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Hint = "Student ID";
            this.txtUsuario.Location = new System.Drawing.Point(57, 92);
            this.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(267, 23);
            this.txtUsuario.TabIndex = 16;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.Text = "2019-2421";
            this.txtUsuario.UseSystemPasswordChar = false;
            // 
            // txtPass
            // 
            this.txtPass.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.txtPass.Depth = 0;
            this.txtPass.Hint = "Password";
            this.txtPass.Location = new System.Drawing.Point(59, 151);
            this.txtPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.Size = new System.Drawing.Size(267, 23);
            this.txtPass.TabIndex = 16;
            this.txtPass.TabStop = false;
            this.txtPass.UseSystemPasswordChar = false;
            // 
            // StudentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 253);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnTeacherOption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(380, 253);
            this.MinimumSize = new System.Drawing.Size(380, 253);
            this.Name = "StudentLogin";
            this.Text = "StudentLogin";
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btnTeacherOption;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPass;
    }
}