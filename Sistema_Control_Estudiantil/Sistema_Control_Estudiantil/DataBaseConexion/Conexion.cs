using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using Sistema_Control_Estudiantil.Resources;
using Sistema_Control_Estudiantil.Entities;
using System;

using MaterialSkin.Controls;

namespace Sistema_Control_Estudiantil.DataBaseConexion
{
    public class Conexion
    {
        #region Properties.
        /// <summary>
        /// Conexion string to the data base.
        /// </summary>
        SqlConnection cn;

        /// <summary>
        /// Takes the table name in the database.
        /// </summary>
        private string TableName { get; set; }

        /// <summary>
        /// Takes the type of commmand
        /// </summary>
        private TypeOfCommand typeOfCommand { get; set; }

        /// <summary>
        /// Takes the store procedure name.
        /// </summary>
        private string spName { get; set; }

        /// <summary>
        /// Takes the store precedure value.
        /// </summary>
        private string spValue { get; set; }

        /// <summary>
        /// Receive a array of store procedure values to send as parameters.
        /// </summary>
        private string[] spValues { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor that receives database conexion and the select command with table from to be use on the data base.
        /// </summary>
        /// <param name="tbl">Table Name</param>
        /// <param name="toc">Type of command</param>
        public Conexion(string tbl, TypeOfCommand toc)
        {
            TableName = tbl;
            typeOfCommand = toc;

            //cn = new SqlConnection($"data source = {DataSource}; initial catalog = {InitialCat}; integrated security = {Security}" );

            cn = new SqlConnection(ConfigurationManager.AppSettings.Get("connectionString"));

            //cn = new SqlConnection(ConfigurationManager.AppSettings.Get("connectionString");
            cn.Open();
        }
        /// <summary>
        /// Constructor that will take database conexion and the store procedure to be executed from the data base.
        /// </summary>
        /// <param name="toc">Type of command</param>
        /// <param name="Procedure">Name of the store procedure in the data base</param>
        public Conexion(TypeOfCommand toc, string Procedure, string Value)
        {
            spName = Procedure;
            typeOfCommand = toc;
            spValue = Value;

            cn = new SqlConnection(ConfigurationManager.AppSettings.Get("connectionString"));

            //cn = new SqlConnection($"data source = {DataSource}; initial catalog = {InitialCat}; integrated security = {Security}" );
            cn.Open();
        }

        public Conexion(TypeOfCommand toc, string Procedure, string[] Values)
        {
            spName = Procedure;
            typeOfCommand = toc;
            spValues = Values;

            cn = new SqlConnection(ConfigurationManager.AppSettings.Get("connectionString"));

            //cn = new SqlConnection($"data source = {DataSource}; initial catalog = {InitialCat}; integrated security = {Security}" );
            cn.Open();
        }
        #endregion

        #region Methods
        /// <summary>
        /// This will bring the data from the data base as specified using the constructor properties.
        /// </summary>
        /// <param name="dgv"></param>
        public void BringData(DataGridView dgv)
        {
            SqlDataAdapter da;

            switch (typeOfCommand)
            {
                case TypeOfCommand.SelectCommand:
                    da = new SqlDataAdapter($"Select * from {TableName}", cn);
                    break;

                case TypeOfCommand.SelectProcedure:
                    da = new SqlDataAdapter($"Exec {spName} '{spValue}'", cn);
                    break;

                case TypeOfCommand.SelectProcedureValues:
                    da = new SqlDataAdapter($"Exec {spName} {Convert.ToInt32(spValues[0])}, '{spValues[1]}'", cn);
                    break;

                default:
                    MessageBox.Show("Something went wrong");
                    return;
            }

            DataTable dt = new DataTable();

            da.Fill(dt);

            //dgv.DataMember = TableName;
            dgv.DataSource = dt;
        }

        public string[] VerifyData(string value, string valueID)
        {
            var contador = 0;

            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand($"select * from {TableName} where {valueID} = {value}", cn);

            dr = cmd.ExecuteReader();

            string[] myDataTable = new string[dr.FieldCount];

            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    myDataTable[i] = dr.GetValue(i).ToString();
                }

                contador++;
            }
            dr.Close();

            if(contador > 0)
            {
                return myDataTable;
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
