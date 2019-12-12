using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows;
using System;
using System.Windows.Controls;

namespace SOF108
{
    class ConexionBDD
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        string DataBaseName;
        string SourcePC;
        string InitialCat;
        string IntSecuirity;

        public ConexionBDD()
        {
            DataBaseName = "SOF108";

            SourcePC = "Data source = Hector-PC;";
            InitialCat = $"Initial catalog = {DataBaseName};";
            IntSecuirity = "Integrated security = true";

            con = new SqlConnection(SourcePC + InitialCat + IntSecuirity);
            con.Open();
        }

        public void CargarDatosEmploye(DataGrid Dg)
        {

            SqlDataAdapter da = new SqlDataAdapter("execute BringEmpleados", con);
            DataTable dt = new DataTable();

            da.Fill(dt);
            //Dg.ItemsSource = dt.DefaultView;
            Dg.ItemsSource = dt.DefaultView;
        }

        public void CargarDatosHistory(DataGrid Dg)
        {

            SqlDataAdapter da = new SqlDataAdapter("execute BringHistorico", con);
            DataTable dt = new DataTable();

            da.Fill(dt);
            Dg.ItemsSource = dt.DefaultView;
        }
    }
}
