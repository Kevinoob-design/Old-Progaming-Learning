using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Calculadora_de_Botones_Form
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
            this.ActiveControl = CajaMagica;
        }

        TextWriter Dato;
        TextReader Lector;

        bool modificable = true;
        bool NEGATIVO = true;
        bool punto = false;
        bool Suma = false, Resta = false, Multi = false, Div = false;
        double A = 0, B = 0, Resultado;
        int contador = 0;

        private void btnPUNTO_Click(object sender, EventArgs e)
        {
            if(modificable == true)
            {
                if (punto == false)
                {
                    punto = true;
                    txtENTRADA.Text = txtENTRADA.Text + Convert.ToString(".");
                    contador = 1;
                }
            }
            CajaMagica.Focus();
        }

        private void btnNEGATIVO_Click(object sender, EventArgs e)
        {
            if(modificable == true)
            {
                switch (NEGATIVO)
                {
                    case true:
                        txtENTRADA.Text = "-" + txtENTRADA.Text;
                        NEGATIVO = false;
                        break;

                    case false:
                        double cambio = Convert.ToDouble(txtENTRADA.Text);
                        cambio = cambio * -1;

                        if (txtENTRADA.Text.Contains("."))
                        {
                            contador = 0;
                        }

                        if(punto == true & contador == 1)
                        {
                            txtENTRADA.Text = Convert.ToString(cambio) + ".";
                            NEGATIVO = true;
                        }
                        else
                        {
                            txtENTRADA.Text = Convert.ToString(cambio);
                            NEGATIVO = true;
                            punto = false;
                        }
                        break;
                }
            }
            CajaMagica.Focus();
        }

        private void btnANTERIOR_Click(object sender, EventArgs e)
        {
            try
            {
                modificable = false;
                Lector = new StreamReader("Resultado Anterior.txt");
                txtENTRADA.Text = (Lector.ReadLine());
                Lector.Close();
            }
            catch (Exception) { }
        }

        private void btnIGUAL_Click(object sender, EventArgs e)
        {
            if(modificable == true)
            {
                if (txtA.Text != Convert.ToString(0))
                {
                    modificable = false;
                    B = Convert.ToDouble(txtENTRADA.Text);
                    txtB.Text = Convert.ToString(B);

                    if (Suma == true)
                    {
                        Resultado = A + B;
                        txtENTRADA.Text = Convert.ToString("= " + Resultado);

                        Dato = new StreamWriter("Resultado Anterior.txt");
                        Dato.WriteLine(txtENTRADA.Text);
                        Dato.Close();
                    }
                    if (Resta == true)
                    {
                        Resultado = A - B;
                        txtENTRADA.Text = Convert.ToString("= " + Resultado);

                        Dato = new StreamWriter("Resultado Anterior.txt");
                        Dato.WriteLine(txtENTRADA.Text);
                        Dato.Close();
                    }
                    if (Multi == true)
                    {
                        Resultado = A * B;
                        txtENTRADA.Text = Convert.ToString("= " + Resultado);

                        Dato = new StreamWriter("Resultado Anterior.txt");
                        Dato.WriteLine(txtENTRADA.Text);
                        Dato.Close();
                    }
                    if (Div == true)
                    {
                        Resultado = A / B;
                        txtENTRADA.Text = Convert.ToString("= " + Resultado);

                        Dato = new StreamWriter("Resultado Anterior.txt");
                        Dato.WriteLine(txtENTRADA.Text);
                        Dato.Close();
                    }
                }
            }
            CajaMagica.Focus();
        }


        private void LaMagia(object sender, PreviewKeyDownEventArgs e)
        {
            if ((e.KeyCode >= Keys.NumPad0) & (e.KeyCode <= Keys.NumPad9))
            {

                if(modificable == true)
                {
                    if (txtENTRADA.Text == Convert.ToString(0))
                    {
                        txtENTRADA.Clear();
                    }

                    txtENTRADA.Text = txtENTRADA.Text + e.KeyCode;

                    if (txtENTRADA.Text.Contains("NumPad"))
                    {
                        txtENTRADA.Text = txtENTRADA.Text.Replace("NumPad", "");
                    }
                    CajaMagica.Focus();
                }
            }
            if ((e.KeyCode >= Keys.D0) & (e.KeyCode <= Keys.D9))
            {
                if(modificable == true)
                {
                    if (txtENTRADA.Text == Convert.ToString(0))
                    {
                        txtENTRADA.Clear();
                    }

                    txtENTRADA.Text = txtENTRADA.Text + e.KeyCode;

                    if (txtENTRADA.Text.Contains("D"))
                    {
                        txtENTRADA.Text = txtENTRADA.Text.Replace("D", "");
                    }
                    CajaMagica.Focus();
                }
            }
            if (e.KeyCode == Keys.Back)
            {
                if(modificable == true)
                {
                    txtENTRADA.Text = txtENTRADA.Text.Remove(txtENTRADA.Text.Length - 1);

                    if (!txtENTRADA.Text.Contains("."))
                    {
                        punto = false;
                    }

                    if (txtENTRADA.Text == "" || txtENTRADA.Text == "-")
                    {
                        txtENTRADA.Text = Convert.ToString(0);
                    }
                }
            }
            if (e.KeyCode == Keys.Decimal)
            {
                if(modificable == true)
                {
                    if (punto == false)
                    {
                        punto = true;
                        txtENTRADA.Text = txtENTRADA.Text + Convert.ToString(".");
                        contador = 1;
                    }
                }
            }
            if (e.KeyCode == Keys.Oemplus)
            {
                if (modificable == true)
                {
                    NEGATIVO = true;
                    punto = false;
                    if (txtA.Text == Convert.ToString(0))
                    {
                        A = Convert.ToDouble(txtENTRADA.Text);
                        txtA.Clear();
                        txtA.Text = txtENTRADA.Text;
                    }

                    txtC.Text = "+";

                    Suma = true;
                    Resta = false;
                    Multi = false;
                    Div = false;

                    txtENTRADA.Text = Convert.ToString(0);
                }
            }

            if (e.KeyCode == Keys.OemMinus)
            {
                if (modificable == true)
                {
                    NEGATIVO = true;
                    punto = false;
                    if (txtA.Text == Convert.ToString(0))
                    {
                        A = Convert.ToDouble(txtENTRADA.Text);
                        txtA.Clear();
                        txtA.Text = txtENTRADA.Text;
                    }

                    txtC.Text = "-";

                    Suma = false;
                    Resta = true;
                    Multi = false;
                    Div = false;

                    txtENTRADA.Text = Convert.ToString(0);
                }
            }

            if (e.KeyCode == Keys.Add)
            {
                if (modificable == true)
                {
                    NEGATIVO = true;
                    punto = false;
                    if (txtA.Text == Convert.ToString(0))
                    {
                        A = Convert.ToDouble(txtENTRADA.Text);
                        txtA.Clear();
                        txtA.Text = txtENTRADA.Text;
                    }

                    txtC.Text = "+";

                    Suma = true;
                    Resta = false;
                    Multi = false;
                    Div = false;

                    txtENTRADA.Text = Convert.ToString(0);
                }
            }
            if (e.KeyCode == Keys.Subtract)
            {
                if (modificable == true)
                {
                    NEGATIVO = true;
                    punto = false;
                    if (txtA.Text == Convert.ToString(0))
                    {
                        A = Convert.ToDouble(txtENTRADA.Text);
                        txtA.Clear();
                        txtA.Text = txtENTRADA.Text;
                    }

                    txtC.Text = "-";

                    Suma = false;
                    Resta = true;
                    Multi = false;
                    Div = false;

                    txtENTRADA.Text = Convert.ToString(0);
                }
            }
            if (e.KeyCode == Keys.Multiply)
            {
                if (modificable == true)
                {
                    NEGATIVO = true;
                    punto = false;
                    if (txtA.Text == Convert.ToString(0))
                    {
                        A = Convert.ToDouble(txtENTRADA.Text);
                        txtA.Clear();
                        txtA.Text = txtENTRADA.Text;
                    }

                    txtC.Text = "*";

                    Suma = false;
                    Resta = false;
                    Multi = true;
                    Div = false;

                    txtENTRADA.Text = Convert.ToString(0);
                }
            }
            if (e.KeyCode == Keys.Divide)
            {
                if (modificable == true)
                {
                    NEGATIVO = true;
                    punto = false;
                    if (txtA.Text == Convert.ToString(0))
                    {
                        A = Convert.ToDouble(txtENTRADA.Text);
                        txtA.Clear();
                        txtA.Text = txtENTRADA.Text;
                    }

                    txtC.Text = "/";

                    Suma = false;
                    Resta = false;
                    Multi = false;
                    Div = true;

                    txtENTRADA.Text = Convert.ToString(0);
                }
            }
            if(e.KeyCode == Keys.Enter)
            {
                if (modificable == true)
                {
                    if (txtA.Text != Convert.ToString(0))
                    {
                        modificable = false;
                        B = Convert.ToDouble(txtENTRADA.Text);
                        txtB.Text = Convert.ToString(B);

                        if (Suma == true)
                        {
                            Resultado = A + B;
                            txtENTRADA.Text = Convert.ToString("= " + Resultado);

                            Dato = new StreamWriter("Resultado Anterior.txt");
                            Dato.WriteLine(txtENTRADA.Text);
                            Dato.Close();
                        }
                        if (Resta == true)
                        {
                            Resultado = A - B;
                            txtENTRADA.Text = Convert.ToString("= " + Resultado);

                            Dato = new StreamWriter("Resultado Anterior.txt");
                            Dato.WriteLine(txtENTRADA.Text);
                            Dato.Close();
                        }
                        if (Multi == true)
                        {
                            Resultado = A * B;
                            txtENTRADA.Text = Convert.ToString("= " + Resultado);

                            Dato = new StreamWriter("Resultado Anterior.txt");
                            Dato.WriteLine(txtENTRADA.Text);
                            Dato.Close();
                        }
                        if (Div == true)
                        {
                            Resultado = A / B;
                            txtENTRADA.Text = Convert.ToString("= " + Resultado);

                            Dato = new StreamWriter("Resultado Anterior.txt");
                            Dato.WriteLine(txtENTRADA.Text);
                            Dato.Close();
                        }
                    }
                }
                CajaMagica.Focus();
            }
            if(e.KeyCode == Keys.Escape)
            {
                NEGATIVO = true;
                modificable = true;
                txtA.Clear();
                txtA.Text = Convert.ToString(0);
                txtB.Clear();
                txtB.Text = Convert.ToString(0);
                txtC.Clear();
                txtENTRADA.Clear();
                txtENTRADA.Text = Convert.ToString(0);
                Suma = false; Resta = false; Multi = false; Div = false;
                punto = false;
                CajaMagica.Focus();
            }
        }
        

        private void Entrada(object sender, EventArgs e)
        {
            CajaMagica.Focus();
        }

        private void Movimiento(object sender, MouseEventArgs e)
        {
            
        }

        private void Movimiento2(object sender, EventArgs e)
        {
            
        }

        private void Movimiento3(object sender, EventArgs e)
        {
            
        }

        private void Movimiento_Entrada(object sender, EventArgs e)
        {
            Button envio = (Button)sender;
            envio.Font = new Font(envio.Font, FontStyle.Bold); 
            envio.ForeColor = Color.Black;
        }

        private void Movimiento_Salida(object sender, EventArgs e)
        {
            Button envio = (Button)sender;
            envio.ForeColor = Color.DimGray;
        }

        private void LaMagia2(object sender, KeyEventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (modificable == true)
            {
                if (txtENTRADA.Text == Convert.ToString(0))
                {
                    txtENTRADA.Clear();
                }
                txtENTRADA.Text = txtENTRADA.Text + boton.Text;  
            }
            CajaMagica.Focus();
        }

        private void btnCALCULAR_Click(object sender, EventArgs e)
        {
            NEGATIVO = true;
            punto = false;
            Button boton = (Button)sender;

            if (modificable == true)
            {
                if (txtA.Text == Convert.ToString(0))
                {
                    A = Convert.ToDouble(txtENTRADA.Text);
                    txtA.Clear();
                    txtA.Text = txtENTRADA.Text;
                }

                txtC.Text = boton.Text;
                
                if(boton.Text == "+")
                {
                    Suma = true;
                    Resta = false;
                    Multi = false;
                    Div = false;
                }
                if (boton.Text == "-")
                {
                    Suma = false;
                    Resta = true;
                    Multi = false;
                    Div = false;
                }
                if (boton.Text == "*")
                {
                    Suma = false;
                    Resta = false;
                    Multi = true;
                    Div = false;
                }
                if (boton.Text == "/")
                {
                    Suma = false;
                    Resta = false;
                    Multi = false;
                    Div = true;
                }

                txtENTRADA.Text = Convert.ToString(0);
            }
            CajaMagica.Focus();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            NEGATIVO = true;
            modificable = true;
            txtA.Clear();
            txtA.Text = Convert.ToString(0);
            txtB.Clear();
            txtB.Text = Convert.ToString(0);
            txtC.Clear();
            txtENTRADA.Clear();
            txtENTRADA.Text = Convert.ToString(0);
            Suma = false; Resta = false; Multi = false; Div = false;
            punto = false;
            CajaMagica.Focus();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            NEGATIVO = true;
            modificable = true;
            txtENTRADA.Clear();
            punto = false;
            txtENTRADA.Text = Convert.ToString(0);
            CajaMagica.Focus();
        }

        private void btnERASE_Click(object sender, EventArgs e)
        {
            if(modificable == true)
            {
                txtENTRADA.Text = txtENTRADA.Text.Remove(txtENTRADA.Text.Length - 1);

                if (!txtENTRADA.Text.Contains("."))
                {
                    punto = false;
                }

                if (txtENTRADA.Text == "" || txtENTRADA.Text == "-")
                {
                    txtENTRADA.Text = Convert.ToString(0);
                }
            }
            CajaMagica.Focus();
        }
    }
}
