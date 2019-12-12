using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Registro_Para_BBDD
{
    public partial class Frm_Registros : Form
    {
        public Frm_Registros()
        {
            InitializeComponent();
        }

        private void Frm_Registros_Load(object sender, EventArgs e)
        {
            face_inicial();
        }
        private void face_inicial()
        {
            label1.Enabled = true;
            txtID.Enabled = true;
            btnbuscar.Enabled = true;
            btncancelar.Enabled = true;

            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;

            txtNombre.Enabled = false;
            txtDireccion.Enabled = false;
            txtEdad.Enabled = false;

            btnguardar.Enabled = false;

            txtID.Focus();
        }
        private void face_final()
        {
            label1.Enabled = false;
            txtID.Enabled = false;
            btnbuscar.Enabled = false;
            btncancelar.Enabled = true;

            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;

            txtNombre.Enabled = true;
            txtDireccion.Enabled = true;
            txtEdad.Enabled = true;

            btnguardar.Enabled = true;

            txtNombre.Focus();
        }
        private void Limpiar()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtEdad.Clear();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            face_final();
        }

        private bool Face_Busqueda (int Buscar)
        {
            //Conexion
            OleDbConnection Conexion = new OleDbConnection();
            Conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Documentos\\BaseDeRegistros.accdb; Persist Security Info = false";

            //Cadena SQL
            String CadenaSQL = "SELECT * FROM Registro WHERE ID = " + Buscar;

            //Adaptador
            OleDbDataAdapter Adaptador = new OleDbDataAdapter(CadenaSQL, Conexion);

            //Dataset
            DataSet ds = new DataSet();

            //Llenar Dataset
            Conexion.Open();
            Adaptador.Fill(ds);
            Conexion.Close();

            if(ds.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }  
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Limpiar();
            face_inicial();
        }
    }
}
