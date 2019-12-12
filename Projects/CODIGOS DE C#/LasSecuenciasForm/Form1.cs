using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LasSecuenciasForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double capital, tiempo, razon;
                double interes, monto;

                capital = Convert.ToDouble(txtcapital.Text);
                razon = Convert.ToDouble(txtrazon.Text);
                tiempo = Convert.ToDouble(txttiempo.Text);

                monto = Math.Pow((1 + razon), tiempo) * capital;

                interes = monto - capital;

                txtfinal.Text = Convert.ToString(monto);
                txtinteres.Text = Convert.ToString(interes);

            }
            catch (Exception)
            {
                MessageBox.Show("Llene las casillas debidamente");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtinteres.Clear();
            txtinteres.Clear();
            txtrazon.Clear();
            txttiempo.Clear();
            txtcapital.Clear();
            txtfinal.Clear();
        }
    }
}
