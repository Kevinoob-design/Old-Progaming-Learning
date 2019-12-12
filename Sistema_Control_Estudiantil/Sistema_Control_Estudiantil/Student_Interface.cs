using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

namespace Sistema_Control_Estudiantil
{
    public partial class Student_Interface : Form
    {
        Sections sections;
        public string studentID { get; set; }
        public Student_Interface(string studentID, Sections sections)
        {
            this.studentID = studentID;
            this.sections = sections;

            InitializeComponent();
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

        private void Student_Interface_Load(object sender, EventArgs e)
        {
            LabelForID.Text = Sections.student.Student_ID;
            LabelForName.Text = $"{Sections.student.Name}  {Sections.student.Last_Name}";
        }

        private void btnCerrrar_Click(object sender, EventArgs e)
        {
            this.Close();
            sections.BringFormChild(new Login(sections));
        }

        private void btnBringInfo_Click(object sender, EventArgs e)
        {
            BringFormChild(new InformationStudentInterface());
        }

        private void btnBringQA_Click(object sender, EventArgs e)
        {
            BringFormChild(new QAForStudentInterface());
        }

        private void btnBringSchedule_Click(object sender, EventArgs e)
        {
            BringFormChild(new ScheduleSectionsForStudent());
        }
    }
}
