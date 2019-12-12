using System;
using System.Windows.Forms;

namespace Sistema_Control_Estudiantil
{
    public partial class InformationTeacherIntercace : Form
    {
        public InformationTeacherIntercace()
        {
            InitializeComponent();
        }

        private void InformationTeacherIntercace_Load(object sender, EventArgs e)
        {
            //DateTime test = Convert.ToDateTime(Sections.teacher.Date_Of_Birth);

            txtName.Text = Sections.teacher.Name;
            txtLastName.Text = Sections.teacher.Last_Name;
            txtDate.Text = Sections.teacher.Date_Of_Admission;
            txtPrimaryNumber.Text = Sections.teacher.Primary_Number;
            txtSecondaryNumber.Text = Sections.teacher.Secondary_Number;
            txtContactEmail.Text = Sections.teacher.Contact_Email;

            txtDOB.Text = Sections.teacher.Date_Of_Birth;
            txtPOB.Text = Sections.teacher.Place_Of_Birth;
            txtDocumentID.Text = Sections.teacher.Document_ID;

            //txtDOB.Text = Convert.ToString(test.ToShortDateString());

            if (Sections.teacher.Gender == "M")
            {
                ckM.Checked = true;
                ckF.Checked = false;
            }
            else
            {
                ckF.Checked = true;
                ckM.Checked = false;
            }

        }

        private void ck_CheckedChanged(object sender, EventArgs e)
        {
            if (ckM.Checked == true)
            {
                ckM.Checked = false;
            }
            else if (ckF.Checked == true)
            {
                ckF.Checked = false;
            }
        }
    }
}
