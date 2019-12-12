using System;
using System.Windows.Forms;
using System.Drawing;
using Sistema_Control_Estudiantil.Entities;
using Sistema_Control_Estudiantil.DataBaseConexion;
using Sistema_Control_Estudiantil.Resources;

namespace Sistema_Control_Estudiantil
{
    public partial class Login : Form
    {
        public TeacherLogin teacherLogin { get; set; }
        public StudentLogin studentLogin { get; set; }

        private Sections Sections { get; set; }
        public Login(Sections sections)
        {
            Sections = sections;
            InitializeComponent();
        }

        public void BringFormChild(object FormHijo)
        {
            if (this.panelMainWindow.Controls.Count > 0)
            {
                this.panelMainWindow.Controls.RemoveAt(0);
            }

            Form TI = FormHijo as Form;
            TI.TopLevel = false;
            TI.Dock = DockStyle.Fill;
            this.panelMainWindow.Controls.Add(TI);
            this.panelMainWindow.Tag = TI;
            TI.Show();
        }

        private void btnTeacherOption_Click(object sender, EventArgs e)
        {
            BringFormChild(teacherLogin = new TeacherLogin(Sections));
            btnStudentOption.Visible = false;
            btnTeacherOption.Visible = false;
            lblChoise.Visible = false;

            btnTeacherLoginTogle.BackColor = Color.FromArgb(0, 212, 255);
            btnTeacherLoginTogle.Enabled = false;

            btnTeacherLoginTogle.Visible = true;
            btnStudentLoginTogle.Visible = true;
        }

        private void btnStudentOption_Click(object sender, EventArgs e)
        {
            BringFormChild(studentLogin = new StudentLogin(Sections));
            btnStudentOption.Visible = false;
            btnTeacherOption.Visible = false;
            lblChoise.Visible = false;

            btnStudentLoginTogle.BackColor = Color.FromArgb(0, 212, 255);
            btnStudentLoginTogle.Enabled = false;

            btnTeacherLoginTogle.Visible = true;
            btnStudentLoginTogle.Visible = true;
        }

        private void btnTeacherLoginTogle_Click(object sender, EventArgs e)
        {
            btnTeacherLoginTogle.BackColor = Color.FromArgb(0, 212, 255);
            btnStudentLoginTogle.BackColor = Color.FromArgb(46, 139, 87);
            btnTeacherLoginTogle.Enabled = false;
            btnStudentLoginTogle.Enabled = true;

            studentLogin.Close();
            BringFormChild(teacherLogin = new TeacherLogin(Sections));
        }

        private void btnStudentLoginTogle_Click(object sender, EventArgs e)
        {

            btnStudentLoginTogle.BackColor = Color.FromArgb(0, 212, 255);
            btnTeacherLoginTogle.BackColor = Color.FromArgb(46, 139, 87);
            btnStudentLoginTogle.Enabled = false;
            btnTeacherLoginTogle.Enabled = true;

            teacherLogin.Close();
            BringFormChild(studentLogin = new StudentLogin(Sections));
        }
    }
}
