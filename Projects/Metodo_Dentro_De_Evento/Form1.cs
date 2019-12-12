using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodo_Dentro_De_Evento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = LaDelFoco;
        }

        private void ClickNormal(object sender, EventArgs e)
        {
            ElMetodo(sender);
        }

        private void FOCO(object sender, PreviewKeyDownEventArgs e)
        {
            if ((e.KeyCode >= Keys.NumPad0) & (e.KeyCode <= Keys.NumPad9))
            {
                string NumPad = Convert.ToString(e.KeyCode);

                txtEntrada.Text = NumPad;

                ElMetodo((Button)NumPad);
            }
        }

        private void ElMetodo(object sender)
        {
            Button click = (Button)sender;

            txtEntrada.Text = txtEntrada.Text + click.Text;
            LaDelFoco.Focus();
        }
    }
}
