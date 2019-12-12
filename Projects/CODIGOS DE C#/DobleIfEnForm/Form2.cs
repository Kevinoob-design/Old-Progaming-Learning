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
    public partial class frmclima : Form
    {
        public frmclima()
        {
            InitializeComponent();
            
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            try
            {
                byte temperatura;
                string clima;

                temperatura = Convert.ToByte(txttemperatura.Text);

                if (temperatura < 10)
                {
                    clima = "Frio";
                }
                else if (temperatura >= 10 && temperatura <= 20)
                {
                    clima = "Nublado";
                }
                else if (temperatura > 20 && temperatura <= 30)
                {
                    clima = "Calor";
                }
                else
                {
                    clima = "Tropical";
                }

                txtclima.Text = clima;

            }
            catch (Exception)
            {
                MessageBox.Show("Complete los Cuadros");
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtclima.Clear();
            txttemperatura.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();  
        }
    }
}
