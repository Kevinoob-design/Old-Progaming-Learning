using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mi_Nueva_Calculadora_En_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btncalcular.BackColor = System.Drawing.Color.Transparent;
            btnnuevo.BackColor = System.Drawing.Color.Transparent;

            btncalcular.Enabled = false;
            btnnuevo.Enabled = false;
        }

        byte cantidad;

        TextBox[] materias = new TextBox[7];
        TextBox[] literales = new TextBox[7];
        NumericUpDown[] credito = new NumericUpDown[7];

        int totaln = 0, totalc = 0, suma1, suma2;

        double indice1, indice2;

        char[] literal = new char[] { 'A', 'B', 'C', 'D', 'F' };

        double[] num = new double[7];
        int[] total = new int[7];
        int[] cred = new int[7];

        Boolean saltar = false;

        public void btnvalidar_Click(object sender, EventArgs e)
        {
            cantidad = Convert.ToByte(numcantidad.Value);

            materias[0] = txtmateria1;
            materias[1] = txtmateria2;
            materias[2] = txtmateria3;
            materias[3] = txtmateria4;
            materias[4] = txtmateria5;
            materias[5] = txtmateria6;
            materias[6] = txtmateria7;

            credito[0] = numcreditos1;
            credito[1] = numcreditos2;
            credito[2] = numcreditos3;
            credito[3] = numcreditos4;
            credito[4] = numcreditos5;
            credito[5] = numcreditos6;
            credito[6] = numcreditos7;

            literales[0] = txtliteral1;
            literales[1] = txtliteral2;
            literales[2] = txtliteral3;
            literales[3] = txtliteral4;
            literales[4] = txtliteral5;
            literales[5] = txtliteral6;
            literales[6] = txtliteral7;

            for (int i = 0; i <= cantidad-1; i++)
            {
                materias[i].Clear();
                materias[i].Enabled = true;
                credito[i].Enabled = true;
            }

            btncalcular.BackColor = System.Drawing.Color.Lime;
            btncalcular.Enabled = true;
            btnvalidar.Enabled = false;
        }

        public void btncalcular_Click(object sender, EventArgs e)
        {
            try
            {
                saltar = false;

                for (int i = 0; i <= cantidad - 1; i++)
                {
                    num[i] = Convert.ToDouble(materias[i].Text);
                    cred[i] = Convert.ToInt32(credito[i].Value);

                    if (num[i] < 0 || num[i] > 100)
                    {
                        saltar = true;
                        MessageBox.Show("Las Materias Deben Estar En Un Rango De 0 a 100");
                        goto punto2;
                    }
                }

                for (int i = 0; i <= cantidad - 1; i++)
                {
                    total[i] = Convert.ToInt32 (num[i] * cred[i]);
                }

                for (int i = 0; i <= cantidad; i++)
                {

                    if (cantidad >= 7)
                    {
                        cantidad -= 1;
                    }

                    if (i == cantidad)
                    {
                        
                        goto punto;
                    }
                    
                    suma1 = Convert.ToInt32(total[i] + total[i + 1]);
                    suma2 = cred[i] + cred[i + 1];

                    i++;

                    totaln = totaln + suma1;
                    totalc = totalc + suma2;

                }
                punto:
                indice1 = Convert.ToDouble(totaln / totalc);
                indice2 = Convert.ToDouble((indice1 * 4) / 100);

                txtpromedio.Text = Convert.ToString(indice2);

                if (cantidad >= 6)
                {
                    cantidad += 1;
                }

                for (int i = 0; i <= cantidad-1; i++)
                {
                    if (num[i] <= 59)
                    {
                        literales[i].Text = Convert.ToString(literal[4]);
                    }
                    else if (num[i] <= 69)
                    {
                        literales[i].Text = Convert.ToString(literal[3]);
                    }
                    else if (num[i] <= 79)
                    {
                        literales[i].Text = Convert.ToString(literal[2]);
                    }
                    else if (num[i] <= 89)
                    {
                        literales[i].Text = Convert.ToString(literal[1]);
                    }
                    else if (num[i] <= 100)
                    {
                        literales[i].Text = Convert.ToString(literal[0]);
                    }
                }

                btnnuevo.BackColor = System.Drawing.Color.Lime;
                btnnuevo.Enabled = true;
                cantidad -= 1;
            }
            catch (Exception)
            {
                MessageBox.Show("La Entrada De Datos Debe Contener Valores De Numeros Enteros.");
            }

            if(txtmateria1.Enabled == false)
            {
                txtpromedio.Clear();
            }

            punto2:
            if (saltar == true)
            {
                btnnuevo_Click(sender, e);
            }
        }

        public void btnnuevo_Click(object sender, EventArgs e)
        {
            

            try
            {
                txtmateria1.Clear();
                txtmateria1.Text = "No Disponible";
                txtmateria1.Enabled = false;
                numcreditos1.Enabled = false;

                txtmateria2.Clear();
                txtmateria2.Text = "No Disponible";
                txtmateria2.Enabled = false;
                numcreditos2.Enabled = false;

                txtmateria3.Clear();
                txtmateria3.Text = "No Disponible";
                txtmateria3.Enabled = false;
                numcreditos3.Enabled = false;

                txtmateria4.Clear();
                txtmateria4.Text = "No Disponible";
                txtmateria4.Enabled = false;
                numcreditos4.Enabled = false;

                txtmateria5.Clear();
                txtmateria5.Text = "No Disponible";
                txtmateria5.Enabled = false;
                numcreditos5.Enabled = false;

                txtmateria6.Clear();
                txtmateria6.Text = "No Disponible";
                txtmateria6.Enabled = false;
                numcreditos6.Enabled = false;

                txtmateria7.Clear();
                txtmateria7.Text = "No Disponible";
                txtmateria7.Enabled = false;
                numcreditos7.Enabled = false;

                txtpromedio.Clear();

                txtliteral1.Clear();
                txtliteral2.Clear();
                txtliteral3.Clear();
                txtliteral4.Clear();
                txtliteral5.Clear();
                txtliteral6.Clear();
                txtliteral7.Clear();

                btncalcular.BackColor = System.Drawing.Color.Transparent;
                btnnuevo.BackColor = System.Drawing.Color.Transparent;
                btncalcular.Enabled = false;
                btnnuevo.Enabled = false;
                btnvalidar.Enabled = true;
                saltar = false;
            }
            catch (Exception)
            {
                MessageBox.Show("No Hay Datos Que Limpiar");
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
