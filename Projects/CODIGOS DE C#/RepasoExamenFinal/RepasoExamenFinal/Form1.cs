using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoExamenFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Conexion con = new Conexion();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           if(con.VerificarDatos(Convert.ToInt32(txtCedula.Text)) == 0)
            {
              MessageBox.Show(con.InsertarDatos(Convert.ToInt32(txtCedula.Text), txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtNum.Text)));
            }
            else
            {
                MessageBox.Show("Esta cedula ya existe");
            }

            con.DesplegarDatos(dgvDatos);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.DesplegarDatos(dgvDatos);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (con.VerificarDatos(Convert.ToInt32(txtCedula.Text)) == 1)
            {
                MessageBox.Show(con.EditarDatos(Convert.ToInt32(txtCedula.Text), txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtNum.Text)));
            }
            else
            {
                MessageBox.Show("Esta cedula no existe");
            }

            con.DesplegarDatos(dgvDatos);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (con.VerificarDatos(Convert.ToInt32(txtCedula.Text)) == 1)
            {
                MessageBox.Show(con.EliominarDatos(Convert.ToInt32(txtCedula.Text)));
            }
            else
            {
                MessageBox.Show("Esta cedula no existe");
            }

            con.DesplegarDatos(dgvDatos);
        }
    }
}
