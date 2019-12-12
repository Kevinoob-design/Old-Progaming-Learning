namespace Sistema_Control_Estudiantil
{
    partial class Login
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
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMainWindow = new System.Windows.Forms.Panel();
            this.btnStudentOption = new System.Windows.Forms.Button();
            this.btnTeacherOption = new System.Windows.Forms.Button();
            this.lblChoise = new System.Windows.Forms.Label();
            this.btnStudentLoginTogle = new System.Windows.Forms.Button();
            this.btnTeacherLoginTogle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panelMainWindow.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCreateAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCreateAccount.FlatAppearance.BorderSize = 0;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.ForeColor = System.Drawing.Color.Black;
            this.btnCreateAccount.Location = new System.Drawing.Point(0, 314);
            this.btnCreateAccount.MaximumSize = new System.Drawing.Size(380, 253);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(380, 41);
            this.btnCreateAccount.TabIndex = 1;
            this.btnCreateAccount.Text = "Create an account.";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.MaximumSize = new System.Drawing.Size(380, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 61);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // panelMainWindow
            // 
            this.panelMainWindow.BackColor = System.Drawing.SystemColors.Control;
            this.panelMainWindow.Controls.Add(this.btnStudentOption);
            this.panelMainWindow.Controls.Add(this.btnTeacherOption);
            this.panelMainWindow.Controls.Add(this.lblChoise);
            this.panelMainWindow.Controls.Add(this.btnStudentLoginTogle);
            this.panelMainWindow.Controls.Add(this.btnTeacherLoginTogle);
            this.panelMainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainWindow.Location = new System.Drawing.Point(0, 61);
            this.panelMainWindow.MaximumSize = new System.Drawing.Size(380, 253);
            this.panelMainWindow.Name = "panelMainWindow";
            this.panelMainWindow.Size = new System.Drawing.Size(380, 253);
            this.panelMainWindow.TabIndex = 2;
            // 
            // btnStudentOption
            // 
            this.btnStudentOption.BackColor = System.Drawing.Color.SeaGreen;
            this.btnStudentOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentOption.FlatAppearance.BorderSize = 0;
            this.btnStudentOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentOption.ForeColor = System.Drawing.Color.White;
            this.btnStudentOption.Location = new System.Drawing.Point(52, 151);
            this.btnStudentOption.Name = "btnStudentOption";
            this.btnStudentOption.Size = new System.Drawing.Size(265, 47);
            this.btnStudentOption.TabIndex = 6;
            this.btnStudentOption.Text = "As a student";
            this.btnStudentOption.UseVisualStyleBackColor = false;
            this.btnStudentOption.Click += new System.EventHandler(this.btnStudentOption_Click);
            // 
            // btnTeacherOption
            // 
            this.btnTeacherOption.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTeacherOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeacherOption.FlatAppearance.BorderSize = 0;
            this.btnTeacherOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherOption.ForeColor = System.Drawing.Color.White;
            this.btnTeacherOption.Location = new System.Drawing.Point(53, 85);
            this.btnTeacherOption.Name = "btnTeacherOption";
            this.btnTeacherOption.Size = new System.Drawing.Size(265, 47);
            this.btnTeacherOption.TabIndex = 5;
            this.btnTeacherOption.Text = "As a teacher";
            this.btnTeacherOption.UseVisualStyleBackColor = false;
            this.btnTeacherOption.Click += new System.EventHandler(this.btnTeacherOption_Click);
            // 
            // lblChoise
            // 
            this.lblChoise.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChoise.AutoSize = true;
            this.lblChoise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoise.Location = new System.Drawing.Point(49, 51);
            this.lblChoise.Name = "lblChoise";
            this.lblChoise.Size = new System.Drawing.Size(269, 24);
            this.lblChoise.TabIndex = 4;
            this.lblChoise.Text = "Choose how you want to Login";
            // 
            // btnStudentLoginTogle
            // 
            this.btnStudentLoginTogle.BackColor = System.Drawing.Color.SeaGreen;
            this.btnStudentLoginTogle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentLoginTogle.FlatAppearance.BorderSize = 0;
            this.btnStudentLoginTogle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentLoginTogle.ForeColor = System.Drawing.Color.White;
            this.btnStudentLoginTogle.Location = new System.Drawing.Point(193, 3);
            this.btnStudentLoginTogle.Name = "btnStudentLoginTogle";
            this.btnStudentLoginTogle.Size = new System.Drawing.Size(184, 45);
            this.btnStudentLoginTogle.TabIndex = 6;
            this.btnStudentLoginTogle.Text = "Student";
            this.btnStudentLoginTogle.UseVisualStyleBackColor = false;
            this.btnStudentLoginTogle.Visible = false;
            this.btnStudentLoginTogle.Click += new System.EventHandler(this.btnStudentLoginTogle_Click);
            // 
            // btnTeacherLoginTogle
            // 
            this.btnTeacherLoginTogle.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTeacherLoginTogle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeacherLoginTogle.FlatAppearance.BorderSize = 0;
            this.btnTeacherLoginTogle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherLoginTogle.ForeColor = System.Drawing.Color.White;
            this.btnTeacherLoginTogle.Location = new System.Drawing.Point(3, 3);
            this.btnTeacherLoginTogle.Name = "btnTeacherLoginTogle";
            this.btnTeacherLoginTogle.Size = new System.Drawing.Size(184, 45);
            this.btnTeacherLoginTogle.TabIndex = 6;
            this.btnTeacherLoginTogle.Text = "Teacher";
            this.btnTeacherLoginTogle.UseVisualStyleBackColor = false;
            this.btnTeacherLoginTogle.Visible = false;
            this.btnTeacherLoginTogle.Click += new System.EventHandler(this.btnTeacherLoginTogle_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.panelMainWindow);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCreateAccount);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(380, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 355);
            this.panel1.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(380, 355);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(380, 355);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelMainWindow.ResumeLayout(false);
            this.panelMainWindow.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panelMainWindow;
        public System.Windows.Forms.Button btnStudentOption;
        public System.Windows.Forms.Button btnTeacherOption;
        public System.Windows.Forms.Label lblChoise;
        private System.Windows.Forms.Button btnStudentLoginTogle;
        private System.Windows.Forms.Button btnTeacherLoginTogle;
        private System.Windows.Forms.Panel panel1;
    }
}