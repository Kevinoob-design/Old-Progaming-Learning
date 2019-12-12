using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Para_BBDD
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void agregarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Registros agregar = new Frm_Registros();
            agregar.Show();
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Modificacion modificar = new Frm_Modificacion();
            modificar.Show();
        }

        private void eliminacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Eliminar eliminar = new Frm_Eliminar();
            eliminar.Show();
        }

        private void listaDeRegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Lista lista = new Frm_Lista();
            lista.Show();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
