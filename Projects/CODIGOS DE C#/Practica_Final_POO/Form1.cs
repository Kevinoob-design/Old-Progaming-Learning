using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; // Libreria de Base de Datos Access

namespace Practica_Final_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Face_Inicial();
        }

        private void Face_Inicial()
        {
            btnGuardar.Enabled = false;
            btnBuscar.Enabled = true;

            txtMatricula.Enabled = true;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtAsignatura.Enabled = false;
            txtPrimerPar.Enabled = false;
            txtSegundoPar.Enabled = false;
            txtLabNota.Enabled = false;
            txtPracticas.Enabled = false;
            txtFinalPar.Enabled = false;
        }
        private void Face_Entrada()
        {
            if(txtMatricula.Text == "")
            {
                btnBuscar.Enabled = true;
                txtMatricula.Enabled = true;
                txtMatricula.Focus();
            }
            else
            {
                btnBuscar.Enabled = false;
                txtMatricula.Enabled = false;
                txtNombre.Focus();
            }

            btnGuardar.Enabled = true;

            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtAsignatura.Enabled = true;
            txtPrimerPar.Enabled = true;
            txtSegundoPar.Enabled = true;
            txtLabNota.Enabled = true;
            txtPracticas.Enabled = true;
            txtFinalPar.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Buscar_Registro(txtMatricula.Text) == false)
            {
                MessageBox.Show("El Registro Solicitado No Existe");
                Face_Entrada();
            }
            else
            {
                MessageBox.Show("El Registro Ya Existe");
                Face_Inicial();
            }
        }

        private bool Buscar_Registro(String Matricula)
        {
            try
            {
                //Conversion de Cadena a Int
                int Cod = Convert.ToInt32(Matricula);

                //Conexion a BDD
                OleDbConnection Conexion = new OleDbConnection();
                Conexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = BDD_Proyecto_Final.mdb; Persist Security Info = false";

                //Cadena SQL
                String CadenaSQL = "SELECT * FROM Registro_De_Estudiante WHERE Matricula=" + Cod;

                //Adaptador
                OleDbDataAdapter Adaptador = new OleDbDataAdapter(CadenaSQL, Conexion);

                //DataSet
                DataSet DS = new DataSet();

                //Llenar DataSet
                Conexion.Open();
                Adaptador.Fill(DS);
                Conexion.Close();

                //Contar Registros
                if (DS.Tables[0].Rows.Count == 0)
                {

                    DS.Dispose();
                    return false;
                }
                else
                {
                    // Llamar el registro al formulario

                    txtNombre.Text = DS.Tables[0].Rows[0]["Nombre"].ToString();
                    txtApellido.Text = DS.Tables[0].Rows[0]["Apellido"].ToString();
                    txtAsignatura.Text = DS.Tables[0].Rows[0]["Asignatura"].ToString();
                    txtPrimerPar.Text = DS.Tables[0].Rows[0]["Primer_Parcial"].ToString();
                    txtSegundoPar.Text = DS.Tables[0].Rows[0]["Segundo_Parcial"].ToString();
                    txtLabNota.Text = DS.Tables[0].Rows[0]["Nota_Lab"].ToString();
                    txtPracticas.Text = DS.Tables[0].Rows[0]["Practica"].ToString();
                    txtFinalPar.Text = DS.Tables[0].Rows[0]["Examen_Final"].ToString();

                    DS.Dispose();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Face_Inicial();

            Limpiar();
        }

        private void Limpiar()
        {
            txtMatricula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtAsignatura.Clear();
            txtPrimerPar.Clear();
            txtSegundoPar.Clear();
            txtLabNota.Clear();
            txtPracticas.Clear();
            txtFinalPar.Clear();
            txtFinalNota.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Agregar_Registro(txtMatricula.Text, txtNombre.Text, txtApellido.Text, txtAsignatura.Text, 
                txtPrimerPar.Text, txtSegundoPar.Text, txtLabNota.Text, txtPracticas.Text, txtFinalPar.Text);

            Limpiar();
            Face_Inicial();

        }

        private bool Agregar_Registro(String Matricula, String Nombre, String Apellido, String Asignatura, 
            String PrimerPar, String SegundoPar, String NotaLab, String Practicas, String FinalPar)
        {
            try
            {
                //Transformacion De Cadena a Texto
                int Cod = Convert.ToInt32(Matricula);
                int primerpar = Convert.ToInt32(PrimerPar);
                int segundopar = Convert.ToInt32(SegundoPar);
                int notalab = Convert.ToInt32(NotaLab);
                int practicas = Convert.ToInt32(Practicas);
                int finalpar = Convert.ToInt32(FinalPar);

                //Conexion
                OleDbConnection Conexion = new OleDbConnection();
                Conexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = BDD_Proyecto_Final.mdb; Persist Security Info = false";

                 //Instruccion SQL
                 String CadenaSQL = "INSERT INTO Registro_De_Estudiante (Matricula, Nombre, Apellido, Asignatura, " +
                    "Primer_Parcial, Segundo_Parcial, Nota_Lab, Practica, Examen_Final) ";

                CadenaSQL = CadenaSQL + "VALUES (" + Cod + ",'" + Nombre + "','" + Apellido + "','" + Asignatura + "'," 
                    + primerpar + "," + segundopar + "," + notalab + "," + practicas + "," + finalpar + ")";

                //Crear Comando
                OleDbCommand Comando = Conexion.CreateCommand();
                Comando.CommandText = CadenaSQL;

                 //Ejecutar Consulta De Accion
                 Conexion.Open();
                 Comando.ExecuteNonQuery();
                 Conexion.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Error Al Grabar");
            }

            return true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(Parametro_Calcular() == true)
            {
                Conversion();

                Total = Parcial1 + Parcial2 + NotaLab + NotaPrac + FinalPar;
                txtFinalNota.Text = Convert.ToString(Total);
            }
            else
            {
                MessageBox.Show("Asegurese de que todos los campos esten debidamente llenados");
            }
        }

        int Parcial1, Parcial2, NotaLab, NotaPrac, FinalPar, Total;

        public void Conversion()
        {

            Parcial1 = Convert.ToInt32(txtPrimerPar.Text);
            Parcial2 = Convert.ToInt32(txtSegundoPar.Text);
            NotaLab = Convert.ToInt32(txtLabNota.Text);
            NotaPrac = Convert.ToInt32(txtPracticas.Text);
            FinalPar = Convert.ToInt32(txtFinalPar.Text);

        }

        private bool Parametro_Calcular()
        {
            try
            {
                Conversion();

                if(Parcial1 >= 0 & Parcial1 <= 10)
                {
                    if(Parcial2 >= 0 & Parcial2 <= 10)
                    {
                        if(NotaLab >= 0 & NotaLab <= 30)
                        {
                            if(NotaPrac >= 0 & NotaPrac <= 30)
                            {
                                if(FinalPar >= 0 & FinalPar <= 20)
                                {
                                     return true;
                                }
                                else
                                {
                                    ErrorIcon.SetError(txtFinalPar, "ha ocurrido un error");
                                    return false;
                                }
                            }
                            else
                            {
                                ErrorIcon.SetError(txtPracticas, "ha ocurrido un error");
                                return false;
                            }
                        }
                        else
                        {
                            ErrorIcon.SetError(txtLabNota, "ha ocurrido un error");
                            return false;
                        }
                    }
                    else
                    {
                        ErrorIcon.SetError(txtSegundoPar, "ha ocurrido un error");
                        return false;
                    }
                }
                else
                {
                    ErrorIcon.SetError(txtPrimerPar, "ha ocurrido un error");
                    return false;
                }
            }
            catch (Exception)
            {
                
                return false;
            }
        }
    }
}
