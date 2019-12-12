using System;
using Sistema_Control_Estudiantil.DataBaseConexion;
using Sistema_Control_Estudiantil.Resources;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace Sistema_Control_Estudiantil
{
    public partial class SectionTeacherInterface : Form
    {
        public NewTeacherInterface NewTeacherInterface { get; set; }
        public SectionTeacherInterface(NewTeacherInterface newTeacherInterface)
        {
            InitializeComponent();

            NewTeacherInterface = newTeacherInterface;

            Conexion cn = new Conexion(TypeOfCommand.SelectProcedure, "spBringTeacherSection", Sections.teacher.Teacher_ID);
            bringData(cn);
        }

        public void bringData(Conexion cn)
        {
            cn.BringData(DgvSectionData);
        }

        private void SectionTeacherInterface_Load(object sender, EventArgs e)
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

            DgvSectionData.Font = new Font("Times", 15);

            foreach (DataGridViewColumn column in DgvSectionData.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            Image copy = button2.BackgroundImage;
            button2.BackgroundImage = GetGrayscale(button2.BackgroundImage);

            button2.BackgroundImage = copy;
        }

        private void btnGetTeacherSections(object sender, EventArgs e)
        {
            Conexion cn = new Conexion(TypeOfCommand.SelectProcedure, "spBringTeacherSection", Sections.teacher.Teacher_ID);
            bringData(cn);
        }

        public void btnGetStudent_Click(object sender, EventArgs e)
        {
            string[] values = new string[2];

            foreach (DataGridViewRow row in DgvSectionData.SelectedRows)
            {
                values[0] = row.Cells[0].Value.ToString();
                values[1] = NewTeacherInterface.LabelForID.Text;
            }

            Conexion cn = new Conexion(TypeOfCommand.SelectProcedureValues, "spGetAllStudentsFromSection", values);
            bringData(cn);
        }

        private void btnGetStudentFromSection(object sender, EventArgs e)
        {
            string[] values = new string[2];

            foreach (DataGridViewRow row in DgvSectionData.SelectedRows)
            {
                values[0] = row.Cells[0].Value.ToString();
                values[1] = row.Cells[1].Value.ToString();
            }

            Conexion cn = new Conexion(TypeOfCommand.SelectProcedureValues, "spGetQASpecificStudentFromSection", values);
            bringData(cn);
        }
        Image GetGrayscale(Image img)
        {
            //create a copy of img,
            // also fix the problem of indexed pixel format (if any)
            MemoryStream mem = new MemoryStream();
            img.Save(mem, ImageFormat.Jpeg);
            Image imag = Image.FromStream(mem);
            Bitmap imge = new Bitmap(imag);

            //create graphics
            Graphics g = Graphics.FromImage(imge);
            //draw disabled image
            System.Windows.Forms.ControlPaint.DrawImageDisabled(g, img, 0, 0, Color.Transparent);

            //retrun result
            return imge;
        }

        private void ControlMouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Panel panel = (Panel)button.Parent;

            panel.BackColor = Color.WhiteSmoke;
        }

        private void ControlMouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Panel panel = (Panel)button.Parent;

            panel.BackColor = Color.White;
        }

        private void ControlMouseDown(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            Panel panel = (Panel)button.Parent;

            panel.BackColor = Color.GhostWhite;
        }

        private void ControlMouseUp(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            Panel panel = (Panel)button.Parent;

            panel.BackColor = Color.WhiteSmoke;
        }
    }
}

