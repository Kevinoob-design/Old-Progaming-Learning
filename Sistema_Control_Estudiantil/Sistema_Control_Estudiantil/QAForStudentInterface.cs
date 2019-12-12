using Sistema_Control_Estudiantil.DataBaseConexion;
using Sistema_Control_Estudiantil.Resources;
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
    public partial class QAForStudentInterface : Form
    {
        public QAForStudentInterface()
        {
            InitializeComponent();

            Conexion cn = new Conexion(TypeOfCommand.SelectProcedure, "spGetQAStudentClases", Sections.student.Student_ID);
            bringData(cn);
        }
        public void bringData(Conexion cn)
        {
            cn.BringData(DgvSectionData);
        }

        private void QAForStudentInterface_Load(object sender, EventArgs e)
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
