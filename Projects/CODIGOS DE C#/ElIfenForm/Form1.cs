using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElIfenForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int hrextras, hrnormales;
                double pagohnormal, pagohextra;
                byte Nhijos;
                double sueldob, sueldon, bonificacion;
                Boolean marcado;

                hrnormales = Convert.ToInt32(txthorasnormales.Text);
                hrextras = Convert.ToInt32(txthorasextra.Text);

                pagohnormal = Convert.ToDouble(txtpagohnormal.Text);
                pagohextra = Convert.ToDouble(txtpagohextra.Text);

                Nhijos = Convert.ToByte(NPHijos.Value);
                marcado = Convert.ToBoolean(CHKbono.Checked);

                bonificacion = 0.0;
                sueldob = (hrnormales * pagohnormal) + (hrextras * pagohextra);

                if (marcado == true)
                {
                    bonificacion = Nhijos * 20;
                }

                sueldon = sueldob + bonificacion;

                txtsueldobruto.Text = "$. " + Convert.ToString(sueldob);
                txtbono.Text = "$. " + Convert.ToString(bonificacion);
                txtneto.Text = "$. " + Convert.ToString(sueldon);

            }
            catch (Exception)
            {
                MessageBox.Show ("Complete los Datos Debidamente");
            }

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtbono.Clear();
            txthorasextra.Clear();
            txthorasnormales.Clear();
            txtneto.Clear();
            txtpagohextra.Clear();
            txtpagohnormal.Clear();
            txtsueldobruto.Clear();

            NPHijos.Value = 0;
            CHKbono.Checked = false;

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
