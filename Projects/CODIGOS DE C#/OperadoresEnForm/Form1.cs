using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperadoresEnForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CALCULAR_Click(object sender, EventArgs e)
        {
            double num1, num2;
            double suma, resta, mult, div, pot, raiz;

            try
            {
                num1 = Convert.ToDouble(NumeroUno.Text);
                num2 = Convert.ToDouble(NumeroDos.Text);

                suma = num1 + num2;
                resta = num1 - num2;
                mult = num1 * num2;
                div = num1 / num2;

                pot = Math.Pow(num1, num2);
                raiz = Math.Pow(num1, (1 / num2));


                txtsum.Text = Convert.ToString(suma);
                txtres.Text = Convert.ToString(resta);
                txtmulti.Text = Convert.ToString(mult);
                txtdiv.Text = Convert.ToString(div);
                txtpot.Text = Convert.ToString(pot);
                txtraiz.Text = Convert.ToString(raiz);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe completar debidamente los espacios en blanco");
            }
        }

        private void LIMPIAR_Click(object sender, EventArgs e)
        {
            txtsum.Clear();
            txtres.Clear();
            txtmulti.Clear();
            txtdiv.Clear();
            txtpot.Clear();
            txtraiz.Clear();

            NumeroUno.Clear();
            NumeroDos.Clear();
        }
    }
}
