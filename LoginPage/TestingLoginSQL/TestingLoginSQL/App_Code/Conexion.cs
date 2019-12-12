using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class Conexion
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataReader dr;

    string SourcePC;
    string InitialCat;
    string IntSecuirity;

    public Conexion()
    {
        SourcePC = "Data source = Hector-PC;";
        InitialCat = "Initial catalog = LoginWebsite;";
        IntSecuirity = "Integrated security = true";

        try
        {
            con = new SqlConnection(SourcePC + InitialCat + IntSecuirity);
            con.Open();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al conectar la base de datos" + ex.ToString());
        }

    }

    public int VerificarUsuario(string Usuario, int Pass)
    {
        int contador = 0;

        cmd = new SqlCommand("select * from validacion where Usuario = '" + Usuario + "' and Pass = " + Pass, con);

        dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            contador++;
        }
        dr.Close();

        return contador;
    }
}