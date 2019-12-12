using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace RepasoExamenFinal
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;

        public Conexion()
        {
            try
            {
                cn = new SqlConnection(@"Data source = Hector-PC; Initial catalog = DataExamenFinal; Integrated security = true");

                MessageBox.Show("La conexion a la base de datos fue exitosa");

                cn.Open();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al conectarse a la base de datos: " + ex.ToString());
            }
        }

        public int VerificarDatos(int Cedula)
        {
            int contador = 0;

            cmd = new SqlCommand("Select * from DataTable where Cedula = " + Cedula + "", cn);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                contador++;
            }
            dr.Close();

            return contador;
        }

        public void DesplegarDatos(DataGridView dgv)
        {
            cmd = new SqlCommand("Select * from DataTable", cn);

            da = new SqlDataAdapter();
            ds = new DataSet();

            da.SelectCommand = cmd;

            da.Fill(ds, "DataTable");

            dgv.DataSource = ds;
            dgv.DataMember = "DataTable";
        }

        public string InsertarDatos(int cedula, string nombre, string apellido, int NumeroTell)
        {
            string mensaje = "Los datos se insertaron correctamente";

            try
            {
                cmd = cn.CreateCommand();

                cmd.CommandText = "Execute EjecutarAgregar @Cedula, @Nombre, @Apellido, @NumeroTell";

                cmd.Parameters.Add("@Cedula", SqlDbType.Int).Value = cedula;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = nombre;
                cmd.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = apellido;
                cmd.Parameters.Add("@NumeroTell", SqlDbType.Int).Value = NumeroTell;

                cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                mensaje = "Error al insertar los datos" + ex.ToString();
            }

            return mensaje;
        }

        public string EditarDatos(int cedula, string nombre, string apellido, int NumeroTell)
        {
            string mensaje = "Los datos se editaron correctamente";

            try
            {
                cmd = cn.CreateCommand();

                cmd.CommandText = "Execute EjecutarEditar @Cedula, @Nombre, @Apellido, @NumeroTell";

                cmd.Parameters.Add("@Cedula", SqlDbType.Int).Value = cedula;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = nombre;
                cmd.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = apellido;
                cmd.Parameters.Add("@NumeroTell", SqlDbType.Int).Value = NumeroTell;

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                mensaje = "Error al editar los datos" + ex.ToString();
            }

            return mensaje;
        }

        public string EliominarDatos(int cedula)
        {
            string mensaje = "Los datos se eliminaron correctamente";

            try
            {
                cmd = cn.CreateCommand();

                cmd.CommandText = "Execute EjecutarEliminar @Cedula";

                cmd.Parameters.Add("@Cedula", SqlDbType.Int).Value = cedula;

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                mensaje = "Error al eliminar los datos" + ex.ToString();
            }

            return mensaje;
        }
    }
}
