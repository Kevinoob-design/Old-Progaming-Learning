using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procedimientos_y_Funciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int _Num1;
        private int _Num2;

        public int Num1 { get => _Num1; set => _Num1 = value; }
        public int Num2 { get => _Num2; set => _Num2 = value; }

        private void button5_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(Sumatoria
                (Convert.ToInt32(txtNum1.Text), 
                Convert.ToInt32(txtNum2.Text)));
        }

        private int Sumatoria(int Num1, int Num2)
        {
            int Suma = Num1 + Num2;
            return Suma;
        }

        private Double Operaciones
            (int num1, int num2, string op)
        {
            Double resultado;

            if(op== "s")
            {
                resultado = num1 + num2;
            }
            else if(op == "r")
            {
                resultado = num1 - num2;
            }
            else if(op == "m")
            {
                resultado = num1 * num2;
            }
            else
            {
                resultado = num1 / num2;
            }

            return resultado;
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            //Declaracion De Variables
            int num1, num2;
            Double resultado;

            //Leer Datos
            num1 = Convert.ToInt32(txtNum1.Text);
            num2 = Convert.ToInt32(txtNum2.Text);

            //llamar la funcion operaciones
            resultado = Operaciones(num1, num2, "r");

            //mostrar info pe
            txtResultado.Text = Convert.ToString(resultado);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            //Declaracion De Variables
            int num1, num2;
            Double resultado;

            //Leer Datos
            num1 = Convert.ToInt32(txtNum1.Text);
            num2 = Convert.ToInt32(txtNum2.Text);

            //llamar la funcion operaciones
            resultado = Operaciones(num1, num2, "m");

            //mostrar info pe
            txtResultado.Text = Convert.ToString(resultado);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            //Declaracion De Variables
            int num1, num2;
            Double resultado;

            //Leer Datos
            num1 = Convert.ToInt32(txtNum1.Text);
            num2 = Convert.ToInt32(txtNum2.Text);

            //llamar la funcion operaciones
            resultado = Operaciones(num1, num2, "d");

            //mostrar info pe
            txtResultado.Text = Convert.ToString(resultado);
        }

        private void btnPropiedad_Click(object sender, EventArgs e)
        {
            Num1 = 10;
            Num2 = 30;
            int suma;

            suma = Num1 + Num2;
            txtResultado.Text = Convert.ToString(suma);
        }

        struct cliente
        {
            public string nombre;
            public string apellido;
            public int edad;
        }

        private void btnStructura_Click(object sender, EventArgs e)
        {
            cliente cliente1;
            cliente1.nombre = "Hector";
            cliente1.apellido = "Morales";
            cliente1.edad = 22;

            
        }
    }
}
