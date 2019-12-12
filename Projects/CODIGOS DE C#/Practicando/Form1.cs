using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            string cadena = txtCadena.Text;

            //Aplicar las funciones
            //Calculamos la longitud de la cadena
            txtLongitud.Text = Convert.ToString(cadena.Length);

            //Mostrar primer caracter
            txtPrimer.Text = cadena.Substring(0,1);

            //Mostrar Ultimo Caracter
            txtUltima.Text = cadena.Substring(cadena.Length-1,1);

            //Mostrar del 2do al 6to
            txtEntre.Text = cadena.Substring(1, 5);

            //Buscar la primera A Mayuscula
            txtAMay.Text = Convert.ToString(cadena.IndexOf("A", 0)+1);

            //convertir las letras a mayusculas
            txtMayus.Text = cadena.ToUpper();

            //convertir las letras a minusculas
            txtMinus.Text = cadena.ToLower();

            //borrar los espacios
            txtBorrarBlancos.Text = cadena.Replace(" ", "");
        }
    }
}
