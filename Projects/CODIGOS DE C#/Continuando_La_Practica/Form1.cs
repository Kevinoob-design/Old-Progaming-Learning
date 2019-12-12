using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Continuando_La_Practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string nombre;

            nombre = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese Nombre:", "Registro de Datos", "", 500,500);

            MessageBox.Show(
                "Bienvenido Usuario: " + nombre, "Sistema Administrativo", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show(
                "Realmente Desea Salir?", "Pregunta Pendeja", MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Question);

            if(opcion == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
