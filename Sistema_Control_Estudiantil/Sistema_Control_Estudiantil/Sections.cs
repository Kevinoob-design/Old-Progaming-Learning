using Sistema_Control_Estudiantil.Entities;
using Sistema_Control_Estudiantil.DataBaseConexion;
using Sistema_Control_Estudiantil.Resources;
using System.Windows.Forms;
using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Media;

namespace Sistema_Control_Estudiantil
{
    public partial class Sections : Form
    {
        public static Teacher teacher { get; set; }
        public static Student student { get; set; }

        public Sections()
        {
            InitializeComponent();
            this.Padding = new Padding(2);
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        /// <summary>
        /// This section controls all the drawing event in the main form.
        /// </summary>
        #region WinControls
        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();
        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //private void panelTopMenu_MouseDown(object sender, MouseEventArgs e)
        //{
        //    ReleaseCapture();
        //    SendMessage(this.Handle, 0x112, 0xf012, 0);
        //}

        //private const int cGrip = 16;
        //private const int cCaption = 32;

        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == 0x84)
        //    {
        //        Point pos = new Point(m.LParam.ToInt32());
        //        pos = this.PointToClient(pos);
        //        if (pos.Y < cCaption)
        //        {
        //            m.Result = (IntPtr)2;
        //            return;
        //        }
        //        if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
        //        {
        //            m.Result = (IntPtr)17;
        //            return;
        //        }
        //    }
        //    base.WndProc(ref m);
        //}
        #endregion

        public void BringFormChild(object FormHijo)
        {
            if (this.panelMainWindow.Controls.Count > 0)
            {
                this.panelMainWindow.Controls.RemoveAt(0);
            }

            Form NewForm = FormHijo as Form;
            NewForm.TopLevel = false;
            NewForm.Dock = DockStyle.Fill;
            this.panelMainWindow.Controls.Add(NewForm);
            this.panelMainWindow.Tag = NewForm;
            NewForm.Show();
        }
        public void LoginTeacherEvent(string Login)
        {
            if (Login.Length == 0 && !Login.Contains(" "))
            {
                MessageBox.Show("You need to provide a Teacher ID");
            }
            else
            {
                Conexion cn = new Conexion("Teachers", TypeOfCommand.SelectCommand);

                string[] myDataTable = cn.VerifyData($"'{Login}'", "Teacher_ID");

                if (myDataTable != null)
                {
                    teacher = new Teacher(myDataTable[0], myDataTable[1], myDataTable[2],
                    myDataTable[3], myDataTable[4], myDataTable[5], myDataTable[6],
                    myDataTable[7], myDataTable[8],
                    myDataTable[9], myDataTable[10], myDataTable[11]);

                    BringFormChild(new NewTeacherInterface(teacher.Teacher_ID, this));
                }
                else
                {
                    MessageBox.Show("The ID enterred was not correct");
                }
            }
        }

        //2019-2421
        public void LoginStudentEvent(string Login)
        {
            if (Login.Length == 0 && !Login.Contains(" "))
            {
                MessageBox.Show("You need to provide a Student ID");
            }
            else
            {
                Conexion cn = new Conexion("Students", TypeOfCommand.SelectCommand);

                string[] myDataTable = cn.VerifyData($"'{Login}'", "Student_ID");

                if (myDataTable != null)
                {

                    student = new Student(myDataTable[0], myDataTable[1], myDataTable[2],
                    myDataTable[3], myDataTable[4], myDataTable[5], myDataTable[6],
                    myDataTable[7], myDataTable[8], myDataTable[9],
                    myDataTable[10], myDataTable[11], myDataTable[12]);

                    BringFormChild(new Student_Interface(student.Student_ID, this));
                }
                else
                {
                    MessageBox.Show("The ID enterred was not correct");
                }
            }
        }

        private void Sections_Load(object sender, EventArgs e)
        {
            BringFormChild(new Login(this));
        }
                
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMax.Visible = false;
            btnRes.Visible = true;
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1300, 650);
            this.CenterToScreen();
            btnMax.Visible = true;
            btnRes.Visible = false;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
