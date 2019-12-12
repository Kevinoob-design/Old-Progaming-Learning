using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbandoLaDesgracia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TextBox tex1;

        private void btnProceso_Click(object sender, EventArgs e)
        {
            tex1 = Cuadro(txtCuadro);

            tex1.Text = "Saludos";
        }

        private TextBox Cuadro(TextBox TexHerencia)
        {
            TextBox TexFinal = TexHerencia;

            return TexFinal;
        }
    }
}
