using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Inventando_Con_Form
{
    public partial class Form1 : Form
    {
        dynamic MLtime = 0;
        bool detener = false;
        byte intentos = 0;

        public Form1()
        {
            InitializeComponent();

            opcion1.Checked = true;
            hora.Text = DateTime.Now.ToLongTimeString();
            timer2.Stop();

            pc1.Visible = false;
            pc2.Visible = false;
            pc3.Visible = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            MLtime++;
            txttiempo.Text = Convert.ToString(MLtime);

            if(detener == true)
            {
                timer2.Stop();
            }
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            try
            {
                timer2.Start();
                detener = false;

                int inicio, hasta, pasos;
                byte repeticion = 1;
                Boolean validar;
                int[] datos;

                hasta = Convert.ToInt32(txthasta.Text);
                pasos = Convert.ToInt32(txtpasos.Text);
                datos = new int[hasta];

                repeticion = Convert.ToByte(repeticiones.Value);
                validar = Convert.ToBoolean(validacion.Checked);

                if (validar == true)
                {
                    for (int i = 1; i <= repeticion; i++)
                    {
                        for (inicio = Convert.ToInt32(txtinicio.Text); inicio <= hasta; inicio += pasos)
                        {
                            datos[inicio - 1] = inicio;
                        }
                    }

                    if (opcion1.Checked)
                    {
                        txtoperaciones.Text = ("Opcion 1, Avtiva");
                        impresion.Items.Clear();
                        for (int it = 1; it <= repeticion; it++)
                        {
                            for (int i = 0; i <= hasta - 1; i++)
                            {
                                impresion.Items.Add(datos[i]);
                            }
                        }
                    }
                    else if (opcion2.Checked)
                    {
                        txtoperaciones.Text = ("Opcion 2, Avtiva");
                        impresion.Items.Clear();
                        for (int it = 1; it <= repeticion; it++)
                        {
                            for (int i = hasta - 1; i >= 0; i--)
                            {
                                impresion.Items.Add(datos[i]);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                if(intentos <= 1)
                {
                    MessageBox.Show("Oops, Se Jodio =D");
                }

                else if(intentos == 2)
                {
                    MessageBox.Show("Algo estas haciendo mal.");
                    
                }
                else if(intentos == 3)
                {
                    MessageBox.Show("llena los cuadros...");
                }
                else if(intentos == 4)
                {
                    MessageBox.Show("Ehm, con numeros enteros...");
                }
                else if(intentos == 5)
                {
                    MessageBox.Show("Va a seguir mmg");
                }
                else if(intentos >= 6)
                {
                    MessageBox.Show("Tenia que ser este pana xD");
                    intentos = 0;

                    
                }
                intentos++;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btndetener_Click(object sender, EventArgs e)
        {
            detener = true;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txthasta.Clear();
            txtinicio.Clear();
            txtpasos.Clear();
            impresion.Items.Clear();

            timer2.Stop();
            txttiempo.Clear();

            repeticiones.ResetText();
            validacion.Checked = false;

            MLtime = 0;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void btnplay_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
            
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            
        }

        int play = 1;

        private void timer3_Tick(object sender, EventArgs e)
        {
           

            
            if (play == 1)
            {
                    pc2.Visible = false;
                    pc3.Visible = false;
                    pc1.Visible = true;
            }
            else if (play == 2)
            {
                    pc1.Visible = false;
                    pc2.Visible = true;
            }
            else if (play == 3)
            {
                    pc1.Visible = false;
                    pc2.Visible = false;
                    pc3.Visible = true;
            }
            play++;

            if (play > 3)
            {
                 play = 1;
            }
            
        }
    }
}
