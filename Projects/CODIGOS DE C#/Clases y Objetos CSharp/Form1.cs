using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases_y_Objetos_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Perro animal = new Perro();

            animal.Nombre = "Boby";
            animal.Raza = "chiwawa";
            animal.Altura = "0.50";

            txtObjeto.Text = animal.comer("Carne");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Perro animal = new Perro();

            animal.Nombre = "Raul";
            animal.Raza = "panda";
            animal.Altura = "500m";

            txtObjeto.Text = animal.comer("edificios");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Perro animal = new Perro("Peluchin", "Poodle", "0.60");

            txtObjeto.Text = animal.comer("pan");
        }
    }
}
