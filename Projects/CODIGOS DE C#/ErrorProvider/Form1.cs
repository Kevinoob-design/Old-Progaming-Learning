using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorProvider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        //Este Metodo Revisa que todos los espacios en blanco esten completados (1/3)
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == string.Empty)
            {
                IdentificarTextBox(txtNombre);
            }
            else if(txtEdad.Text == string.Empty)
            {
                IdentificarTextBox(txtEdad);
            }
            else if(txtSalario.Text == string.Empty)
            {
                IdentificarTextBox(txtSalario);
            }
            else
            {
                IdentificarTextBox(txtNombre);
            }
        }

        //Este evento es el siguiente en ser ejecutado luego de verificar si hay o no hay espacios en blanco (2/3)
        private void IdentificarTextBox(object sender)
        {
            if (ElEventoError(sender))
            {
                ErrorIcon.Clear();
                MessageBox.Show(
                    "Datos Agregados Correctamente", "Validaciones",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Metodo o Evento para limpiar los Textboxes
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtSalario.Clear();
        }

        //WDF? xD
        private void btnUndo_Click(object sender, EventArgs e)
        {
            txtNombre.ClearUndo();
            txtEdad.ClearUndo();
            txtSalario.ClearUndo();
   
        }

        //Este evento es redirigido desde las propiedades
        private void ElEvento(object sender, EventArgs e)
        {
            TextBox Texto = (TextBox)sender;

            ttMensaje.SetToolTip(Texto, "Rellene el espacio en blanco ");
        }

        //Este Metodo, utilizado en una propiedad para imprimir un Tip con el texto del nombre de su proveedor
        private void LinkLabelTollTip(object sender, EventArgs e)
        {
            LinkLabel label = (LinkLabel)sender;

            ttMensaje.SetToolTip(label, label.Text);
        }

        //Este evento es el que envia el Error si encuentra un espacio en blanco (3/3)
        private bool ElEventoError(object sender)
        {
            bool no_error = true;
            TextBox Error = (TextBox)sender;

            if (Error.Text == string.Empty)
            {
                ErrorIcon.SetError(Error, "Complete los datos correctamente");
                no_error = false;
            }

            return no_error;
        }
    }
}
