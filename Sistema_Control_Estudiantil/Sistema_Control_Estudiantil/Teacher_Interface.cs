using Sistema_Control_Estudiantil.DataBaseConexion;
using Sistema_Control_Estudiantil.Resources;
using System;
using System.Drawing;
using System.Drawing.Configuration;
using System.Windows.Forms;

namespace Sistema_Control_Estudiantil
{
    public partial class Teacher_Interface : Form
    {
        //exec spGetQASpecificStudentFromSection 9, '2019-2421'

        public Teacher_Interface(string teacherID)
        {
            InitializeComponent();

            //Conexion cn = new Conexion("Hector-PC", "SchooSystemDB", "True", TypeOfCommand.SelectProcedure, "spBringTeacherSection", "'576-666'");
            Conexion cn = new Conexion(TypeOfCommand.SelectProcedure, "spBringTeacherSection", teacherID);
            bringData(cn);
        }

        private void bringData(Conexion cn)
        {
            cn.BringData(DgvSectionData);
        }

        private void Teacher_Interface_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < DgvSectionData.RowCount; i++)
            {
                if ((i % 2) == 0)
                {
                    DgvSectionData.Rows[i].DefaultCellStyle.BackColor = SystemColors.InactiveCaption;
                }
                else
                {
                    DgvSectionData.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }

            this.DgvSectionData.Font = new Font("Times", 15);

            foreach (DataGridViewColumn column in DgvSectionData.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            LabelForID.Text = Sections.teacher.Teacher_ID;
            txtNameTeacher.Text = Sections.teacher.Name;
            txtLastNameTeacher.Text = Sections.teacher.Last_Name;
            txtDateTeacher.Value = Convert.ToDateTime(Sections.teacher.Date_Of_Admission);
            txtpNumber.Text = Sections.teacher.Primary_Number;
            txtsNumber.Text = Sections.teacher.Secondary_Number;
            txtcontactEmail.Text = Sections.teacher.Contact_Email;
        }

        private void btnGetStudent_Click(object sender, EventArgs e)
        {

            string[] values = new string[2];

            foreach (DataGridViewRow row in DgvSectionData.SelectedRows)
            {
                values[0] = row.Cells[0].Value.ToString();
                values[1] = LabelForID.Text;

            }

            Conexion cn = new Conexion(TypeOfCommand.SelectProcedureValues, "spGetAllStudentsFromSection", values);
            bringData(cn);
        }

        private void btnCerrrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
