using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DobleIfEnForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pxcuadrado.Visible = false;
            pxrectangulo.Visible = false;
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double ladoa, ladob;
                double area, perimetro;

                ladoa = Convert.ToDouble(txtladoA.Text);
                ladob = Convert.ToDouble(txtladoB.Text);

                if (ladoa == ladob)
                {
                    pxcuadrado.Visible = true;
                    pxrectangulo.Visible = false;
                }
                else
                {
                    pxcuadrado.Visible = false;
                    pxrectangulo.Visible = true;
                }
                area = ladoa * ladob;
                perimetro = 2 * (ladoa + ladob);

                txtarea.Text = Convert.ToString(area);
                txtperimetro.Text = Convert.ToString(perimetro);
            }
            catch (Exception)
            {
                MessageBox.Show("Complete los espacios en blanco debidamente");
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtarea.Clear();
            txtladoA.Clear();
            txtladoB.Clear();
            txtperimetro.Clear();
            pxcuadrado.Visible = false;
            pxrectangulo.Visible = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsiguiente2_Click(object sender, EventArgs e)
        {
            frmclima clima = new frmclima();
            clima.Show();
        }
    }
}
