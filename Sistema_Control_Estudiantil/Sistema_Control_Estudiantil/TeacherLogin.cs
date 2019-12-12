using System;
using System.Windows.Forms;
using System.Drawing;

namespace Sistema_Control_Estudiantil
{
    public partial class TeacherLogin : Form
    {
        private Sections Sections { get; set; }

        public TeacherLogin(Sections sections)
        {
            Sections = sections;
            InitializeComponent();
        }

        private void btnTeacherOptionLogin_Click(object sender, EventArgs e)
        {
            Sections.LoginTeacherEvent(txtUsuario.Text);
        }
    }
}
