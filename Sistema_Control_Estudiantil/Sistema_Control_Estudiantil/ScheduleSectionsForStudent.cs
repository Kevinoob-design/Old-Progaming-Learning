using Sistema_Control_Estudiantil.DataBaseConexion;
using Sistema_Control_Estudiantil.Resources;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema_Control_Estudiantil
{
    public partial class ScheduleSectionsForStudent : Form
    {
        public ScheduleSectionsForStudent()
        {
            InitializeComponent();

            Conexion cn = new Conexion(TypeOfCommand.SelectProcedure, "spBringStudentSection", Sections.student.Student_ID);
            bringData(cn);
        }
        public void bringData(Conexion cn)
        {
            cn.BringData(DgvSectionData);
        }

        private void ScheduleSectionsForStudent_Load(object sender, System.EventArgs e)
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
        }
    }
}
