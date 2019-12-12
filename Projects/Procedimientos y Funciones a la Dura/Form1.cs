using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procedimientos_y_Funciones_a_la_Dura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DesactivarControles();
        }

        private Double MONTO;

        private void ActivarControles()
        {
            txtCliente.Enabled = false;
            txtMonto.Enabled = false;
            btnAbrirCuenta.Enabled = false;

            btnDeposito.Enabled = true;
            btnRetiro.Enabled = true;
        }
        private void DesactivarControles()
        {
            txtCliente.Enabled = true;
            txtMonto.Enabled = true;
            btnAbrirCuenta.Enabled = true;

            btnDeposito.Enabled = false;
            btnRetiro.Enabled = false;
        }

        private void btnAbrirCuenta_Click(object sender, EventArgs e)
        {
            string Cliente;

            //Leer Datos
            Cliente = txtCliente.Text;
            MONTO = Convert.ToDouble(txtMonto.Text);

            if(MONTO >= 0)
            {
                ActivarControles();
            }
            else
            {
                MessageBox.Show("El monto debe ser mayor o igual que 0", 
                    "GESTION DE AHORROS", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private Double leer (string mensaje)
        {
            Double cantidad;

            cantidad = Convert.ToDouble(
                Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese Monto a " + mensaje, "GESTION DE AHORROS","0",100,0));

            return cantidad;
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            Double deposito = leer("Depositar");
            MONTO = MONTO + deposito;

            HDeposito.Items.Add(deposito);

            Mostrar();
        }

        private void Mostrar()
        {
            txtSaldo.Text = Convert.ToString(MONTO);
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            Double retiro = leer("Retirar");
            
            if(retiro <= MONTO)
            {
                MONTO = MONTO - retiro;
                HRetiro.Items.Add(retiro);
                
            }
            else
            {
                MessageBox.Show("La cantidad de Retiro es mayor al Monto", "GESTION DE AHORROS",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Mostrar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtMonto.Clear();
            txtSaldo.Clear();

            HDeposito.Items.Clear();
            HRetiro.Items.Clear();

            DesactivarControles();
        }
    }
}
