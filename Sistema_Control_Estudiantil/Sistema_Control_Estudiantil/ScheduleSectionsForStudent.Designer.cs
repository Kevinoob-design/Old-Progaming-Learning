namespace Sistema_Control_Estudiantil
{
    partial class ScheduleSectionsForStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvSectionData = new DevComponents.DotNetBar.Controls.DataGridViewX();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSectionData)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvSectionData
            // 
            this.DgvSectionData.AllowUserToAddRows = false;
            this.DgvSectionData.AllowUserToDeleteRows = false;
            this.DgvSectionData.AllowUserToResizeColumns = false;
            this.DgvSectionData.AllowUserToResizeRows = false;
            this.DgvSectionData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSectionData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvSectionData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvSectionData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSectionData.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvSectionData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvSectionData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DgvSectionData.Location = new System.Drawing.Point(0, 0);
            this.DgvSectionData.Name = "DgvSectionData";
            this.DgvSectionData.ReadOnly = true;
            this.DgvSectionData.RowHeadersVisible = false;
            this.DgvSectionData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSectionData.Size = new System.Drawing.Size(898, 455);
            this.DgvSectionData.TabIndex = 2;
            // 
            // ScheduleSectionsForStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 455);
            this.Controls.Add(this.DgvSectionData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(898, 455);
            this.Name = "ScheduleSectionsForStudent";
            this.Text = "ScheduleSectionsForStudent";
            this.Load += new System.EventHandler(this.ScheduleSectionsForStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSectionData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.Controls.DataGridViewX DgvSectionData;
    }
}