﻿namespace Sistema_Control_Estudiantil
{
    partial class NewTeacherInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTeacherInterface));
            this.ParentPanel = new System.Windows.Forms.Panel();
            this.DivisorPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.SideDivisionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBringSection = new System.Windows.Forms.Button();
            this.SelectedButton1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SelectedButton2 = new System.Windows.Forms.Button();
            this.btnBringInfo = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopDivision = new System.Windows.Forms.TableLayoutPanel();
            this.TeacherIDContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelForID = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            this.LabelForName = new System.Windows.Forms.Label();
            this.ParentPanel.SuspendLayout();
            this.DivisorPanel.SuspendLayout();
            this.SidePanel.SuspendLayout();
            this.SideDivisionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.TopDivision.SuspendLayout();
            this.TeacherIDContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParentPanel
            // 
            this.ParentPanel.Controls.Add(this.DivisorPanel);
            this.ParentPanel.Controls.Add(this.TopPanel);
            this.ParentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParentPanel.Location = new System.Drawing.Point(0, 0);
            this.ParentPanel.Name = "ParentPanel";
            this.ParentPanel.Size = new System.Drawing.Size(1010, 602);
            this.ParentPanel.TabIndex = 0;
            // 
            // DivisorPanel
            // 
            this.DivisorPanel.ColumnCount = 2;
            this.DivisorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.DivisorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.DivisorPanel.Controls.Add(this.SidePanel, 0, 0);
            this.DivisorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DivisorPanel.Location = new System.Drawing.Point(0, 41);
            this.DivisorPanel.Name = "DivisorPanel";
            this.DivisorPanel.RowCount = 1;
            this.DivisorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DivisorPanel.Size = new System.Drawing.Size(1010, 561);
            this.DivisorPanel.TabIndex = 4;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.SidePanel.Controls.Add(this.SideDivisionPanel);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SidePanel.Location = new System.Drawing.Point(3, 3);
            this.SidePanel.MinimumSize = new System.Drawing.Size(119, 555);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(119, 555);
            this.SidePanel.TabIndex = 5;
            // 
            // SideDivisionPanel
            // 
            this.SideDivisionPanel.ColumnCount = 1;
            this.SideDivisionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SideDivisionPanel.Controls.Add(this.pictureBox1, 0, 0);
            this.SideDivisionPanel.Controls.Add(this.panel1, 0, 1);
            this.SideDivisionPanel.Controls.Add(this.panel2, 0, 2);
            this.SideDivisionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SideDivisionPanel.Location = new System.Drawing.Point(0, 0);
            this.SideDivisionPanel.Name = "SideDivisionPanel";
            this.SideDivisionPanel.RowCount = 3;
            this.SideDivisionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.93839F));
            this.SideDivisionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.3727F));
            this.SideDivisionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.34446F));
            this.SideDivisionPanel.Size = new System.Drawing.Size(119, 259);
            this.SideDivisionPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBringSection);
            this.panel1.Controls.Add(this.SelectedButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 44);
            this.panel1.TabIndex = 4;
            // 
            // btnBringSection
            // 
            this.btnBringSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBringSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBringSection.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnBringSection.FlatAppearance.BorderSize = 0;
            this.btnBringSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBringSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBringSection.ForeColor = System.Drawing.Color.White;
            this.btnBringSection.Location = new System.Drawing.Point(0, 0);
            this.btnBringSection.Name = "btnBringSection";
            this.btnBringSection.Size = new System.Drawing.Size(113, 41);
            this.btnBringSection.TabIndex = 1;
            this.btnBringSection.Text = "Sections";
            this.btnBringSection.UseVisualStyleBackColor = true;
            this.btnBringSection.Click += new System.EventHandler(this.btnBringSection_Click);
            // 
            // SelectedButton1
            // 
            this.SelectedButton1.BackColor = System.Drawing.Color.Red;
            this.SelectedButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SelectedButton1.Enabled = false;
            this.SelectedButton1.FlatAppearance.BorderSize = 0;
            this.SelectedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectedButton1.ForeColor = System.Drawing.Color.Red;
            this.SelectedButton1.Location = new System.Drawing.Point(0, 41);
            this.SelectedButton1.Name = "SelectedButton1";
            this.SelectedButton1.Size = new System.Drawing.Size(113, 3);
            this.SelectedButton1.TabIndex = 2;
            this.SelectedButton1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SelectedButton2);
            this.panel2.Controls.Add(this.btnBringInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(113, 42);
            this.panel2.TabIndex = 5;
            // 
            // SelectedButton2
            // 
            this.SelectedButton2.BackColor = System.Drawing.Color.Red;
            this.SelectedButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SelectedButton2.Enabled = false;
            this.SelectedButton2.FlatAppearance.BorderSize = 0;
            this.SelectedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectedButton2.ForeColor = System.Drawing.Color.Red;
            this.SelectedButton2.Location = new System.Drawing.Point(0, 39);
            this.SelectedButton2.Name = "SelectedButton2";
            this.SelectedButton2.Size = new System.Drawing.Size(113, 3);
            this.SelectedButton2.TabIndex = 2;
            this.SelectedButton2.UseVisualStyleBackColor = false;
            // 
            // btnBringInfo
            // 
            this.btnBringInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBringInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBringInfo.FlatAppearance.BorderSize = 0;
            this.btnBringInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBringInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBringInfo.ForeColor = System.Drawing.Color.White;
            this.btnBringInfo.Location = new System.Drawing.Point(0, 0);
            this.btnBringInfo.Name = "btnBringInfo";
            this.btnBringInfo.Size = new System.Drawing.Size(113, 39);
            this.btnBringInfo.TabIndex = 0;
            this.btnBringInfo.Text = "Information";
            this.btnBringInfo.UseVisualStyleBackColor = true;
            this.btnBringInfo.Click += new System.EventHandler(this.btnBringInfo_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TopPanel.Controls.Add(this.TopDivision);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1010, 41);
            this.TopPanel.TabIndex = 0;
            // 
            // TopDivision
            // 
            this.TopDivision.ColumnCount = 4;
            this.TopDivision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopDivision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.TopDivision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.TopDivision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TopDivision.Controls.Add(this.TeacherIDContainer, 0, 0);
            this.TopDivision.Controls.Add(this.LabelForID, 2, 0);
            this.TopDivision.Controls.Add(this.btnOut, 3, 0);
            this.TopDivision.Controls.Add(this.LabelForName, 1, 0);
            this.TopDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopDivision.Location = new System.Drawing.Point(0, 0);
            this.TopDivision.Name = "TopDivision";
            this.TopDivision.RowCount = 1;
            this.TopDivision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopDivision.Size = new System.Drawing.Size(1010, 41);
            this.TopDivision.TabIndex = 0;
            // 
            // TeacherIDContainer
            // 
            this.TeacherIDContainer.Controls.Add(this.label1);
            this.TeacherIDContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeacherIDContainer.Location = new System.Drawing.Point(3, 3);
            this.TeacherIDContainer.Name = "TeacherIDContainer";
            this.TeacherIDContainer.Size = new System.Drawing.Size(454, 35);
            this.TeacherIDContainer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Just Some testing text";
            // 
            // LabelForID
            // 
            this.LabelForID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelForID.AutoSize = true;
            this.LabelForID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelForID.ForeColor = System.Drawing.Color.White;
            this.LabelForID.Location = new System.Drawing.Point(771, 8);
            this.LabelForID.Name = "LabelForID";
            this.LabelForID.Size = new System.Drawing.Size(127, 25);
            this.LabelForID.TabIndex = 3;
            this.LabelForID.Text = "LabelForID";
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.DarkRed;
            this.btnOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOut.FlatAppearance.BorderSize = 0;
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.ForeColor = System.Drawing.Color.White;
            this.btnOut.Location = new System.Drawing.Point(913, 3);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(94, 35);
            this.btnOut.TabIndex = 1;
            this.btnOut.Text = "Log out";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnCerrrar_Click);
            // 
            // LabelForName
            // 
            this.LabelForName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelForName.AutoSize = true;
            this.LabelForName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelForName.ForeColor = System.Drawing.Color.White;
            this.LabelForName.Location = new System.Drawing.Point(527, 8);
            this.LabelForName.Name = "LabelForName";
            this.LabelForName.Size = new System.Drawing.Size(165, 25);
            this.LabelForName.TabIndex = 3;
            this.LabelForName.Text = "LabelForName";
            // 
            // NewTeacherInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 602);
            this.Controls.Add(this.ParentPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1010, 602);
            this.Name = "NewTeacherInterface";
            this.Text = "s";
            this.Load += new System.EventHandler(this.NewTeacherInterface_Load);
            this.ParentPanel.ResumeLayout(false);
            this.DivisorPanel.ResumeLayout(false);
            this.SidePanel.ResumeLayout(false);
            this.SideDivisionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopDivision.ResumeLayout(false);
            this.TopDivision.PerformLayout();
            this.TeacherIDContainer.ResumeLayout(false);
            this.TeacherIDContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ParentPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.TableLayoutPanel TopDivision;
        private System.Windows.Forms.Panel TeacherIDContainer;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Label LabelForName;
        private System.Windows.Forms.TableLayoutPanel DivisorPanel;
        private System.Windows.Forms.Panel SidePanel;
        public System.Windows.Forms.Label LabelForID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel SideDivisionPanel;
        private System.Windows.Forms.Button SelectedButton2;
        private System.Windows.Forms.Button btnBringInfo;
        private System.Windows.Forms.Button btnBringSection;
        private System.Windows.Forms.Button SelectedButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}