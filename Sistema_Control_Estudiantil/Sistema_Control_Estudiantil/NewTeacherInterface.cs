using Sistema_Control_Estudiantil.DataBaseConexion;
using Sistema_Control_Estudiantil.Resources;
using System;
using System.Drawing;
using System.Drawing.Configuration;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Sistema_Control_Estudiantil
{
    //public partial class NewTeacherInterface : DevComponents.DotNetBar.Office2007RibbonForm
    public partial class NewTeacherInterface : Form
    {
        SectionTeacherInterface SectionTeacherInterface;
        Sections sections;
        public string teacherID { get; set; }

        public NewTeacherInterface(string teacherID, Sections sections)
        {
            InitializeComponent();

            this.teacherID = teacherID;
            this.sections = sections;

            BringFormChild(SectionTeacherInterface = new SectionTeacherInterface(this));
        }
        private void BringFormChild(object FormHijo)
        {

            if (this.DivisorPanel.Controls.Count > 1)
            {
                this.DivisorPanel.Controls.RemoveAt(1);
            }

            Form NewForm = FormHijo as Form;
            NewForm.TopLevel = false;
            NewForm.Dock = DockStyle.Fill;
            this.DivisorPanel.Controls.Add(NewForm);
            this.DivisorPanel.Tag = NewForm;
            NewForm.Show();
        }

        private void NewTeacherInterface_Load(object sender, EventArgs e)
        {
            LabelForID.Text = Sections.teacher.Teacher_ID;
            LabelForName.Text = $"{Sections.teacher.Name}  {Sections.teacher.Last_Name}";

            SelectedButton1.BackColor = Color.FromArgb(30, 150, 229);

            SelectedButton2.BackColor = Color.Transparent;
        }

        private void btnCerrrar_Click(object sender, EventArgs e)
        {
            this.Close();
            sections.BringFormChild(new Login(sections));
        }

        private void btnBringSection_Click(object sender, EventArgs e)
        {
            BringFormChild(SectionTeacherInterface = new SectionTeacherInterface(this));
            SelectedButton1.BackColor = Color.FromArgb(30, 150, 229);
            SelectedButton2.BackColor = Color.Transparent;
        }

        private void btnBringInfo_Click(object sender, EventArgs e)
        {
            BringFormChild(new InformationTeacherIntercace());
            SelectedButton1.BackColor = Color.Transparent;
            SelectedButton2.BackColor = Color.FromArgb(30, 150, 229);
        }
    }
}
