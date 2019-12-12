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

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtapellido.Clear();
            txtcarrera.Clear();
            txtcedula.Clear();
            txtdireccion.Clear();
            txtedad.Clear();
            txtmatricula.Clear();
            txtnombre.Clear();
            txttelefonoc.Clear();
            txttelefonor.Clear();
            txtbuscar.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        TextWriter Dato;
        TextReader Lector;
        StreamWriter NOMBRE_ARCHIVOS;

        dynamic matricula, nombre, apellido, cedula, direccion, telefonor, telefonoc, edad, carrera, sexom, sexof, sexo;

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                matricula = txtmatricula;
                nombre = txtnombre;
                apellido = txtcedula;
                cedula = txtcedula;
                direccion = txtdireccion;
                telefonor = txttelefonor;
                telefonoc = txttelefonoc;
                edad = txtedad;
                carrera = txtcarrera;
                sexom = radm;
                sexof = radf;

                if (sexom.Checked == true)
                {
                    sexo = sexom;
                }
                else if (sexof.Checked == true)
                {
                    sexo = sexof;
                }

                NOMBRE_ARCHIVOS = File.AppendText("NOMBRE DE LOS DOCUMENTOS.txt");
                NOMBRE_ARCHIVOS.WriteLine(txtnombre.Text);
                NOMBRE_ARCHIVOS.Close();

                Dato = new StreamWriter(txtnombre.Text);

                Dato.WriteLine(txtmatricula.Text);
                Dato.WriteLine(txtnombre.Text);
                Dato.WriteLine(txtapellido.Text);
                Dato.WriteLine(txtcedula.Text);
                Dato.WriteLine(txtdireccion.Text);
                Dato.WriteLine(txttelefonor.Text);
                Dato.WriteLine(txttelefonoc.Text);
                Dato.WriteLine(txtedad.Text);
                Dato.WriteLine(txtcarrera.Text);
                Dato.WriteLine(sexo);

                Dato.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Al Parecer No Hay Datos Que Guardar");
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Lector = new StreamReader(txtbuscar.Text);

                txtmatricula.Text = (Lector.ReadLine());
                txtapellido.Text = (Lector.ReadLine());
                txtnombre.Text = (Lector.ReadLine());
                txtcedula.Text = (Lector.ReadLine());
                txtdireccion.Text = (Lector.ReadLine());
                txttelefonor.Text = (Lector.ReadLine());
                txttelefonoc.Text = (Lector.ReadLine());
                txtedad.Text = (Lector.ReadLine());
                txtcarrera.Text = (Lector.ReadLine());

                if (sexo == radm)
                {
                    radm.Checked = true;
                }
                else if (sexo == radf)
                {
                    radf.Checked = true;
                }

                Lector.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Al Parecer No Hay Datos Que Buscar");
            }
        }

        private void btnlimpiarlista_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lector = new StreamReader("NOMBRE DE LOS DOCUMENTOS.txt");

            listBox1.Items.Add(Lector.ReadToEnd());

            Lector.Close();
           
        }
    }
}
