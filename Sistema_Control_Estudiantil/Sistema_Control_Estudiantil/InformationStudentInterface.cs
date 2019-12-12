using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Control_Estudiantil
{
    public partial class InformationStudentInterface : Form
    {
        public InformationStudentInterface()
        {
            InitializeComponent();
        }

        private void InformationStudentInterface_Load(object sender, EventArgs e)
        {
            DateTime test = Convert.ToDateTime(Sections.student.Date_Of_Birth);

            txtName.Text = Sections.student.Name;
            txtLastName.Text = Sections.student.Last_Name;
            txtDate.Text = Sections.student.Date_Of_Admission;
            txtPrimaryNumber.Text = Sections.student.Primary_Number;
            txtSecondaryNumber.Text = Sections.student.Secondary_Number;
            txtContactEmail.Text = Sections.student.Contact_Email;

            txtDOB.Text = Sections.student.Date_Of_Birth;
            txtPOB.Text = Sections.student.Place_Of_Birth;
            txtDocumentID.Text = Sections.student.Document_ID;

            txtDOB.Text = Convert.ToString(test.ToShortDateString());

            if (Sections.student.Gender == "M")
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

        private void ckM_CheckedChanged(object sender, EventArgs e)
        {
            if (ckF.Checked == true)
            {
                ckF.Checked = false;
            }
        }

        private void ckF_CheckedChanged(object sender, EventArgs e)
        {
            if (ckM.Checked == true)
            {
                ckM.Checked = false;
            }
        }
    }
}
