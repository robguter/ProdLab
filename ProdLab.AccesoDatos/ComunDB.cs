using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace ProdLab.AccesoDatos
{
    public class ComunDB
    {
        //static string StrConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB_Prod.mdf;Integrated Security=True;Connect Timeout=30";
        static string StrConn = ConfigurationManager.ConnectionStrings["ProdLab.UI.Winform.Properties.Settings.Setting"].ConnectionString;
        
        private static SqlConnection ObtenerConn()
        {
            //MessageBox.Show(StrConn);
            SqlConnection oConn = new SqlConnection(StrConn);
            oConn.Open();
            return oConn;
        }
        public static SqlCommand ObtenerCmd()
        {
            SqlCommand oCmd = new SqlCommand();
            oCmd.Connection = ObtenerConn();
            return oCmd;
        }
        public static int EjecutarCmd(SqlCommand oCmd)
        {
            int result = oCmd.ExecuteNonQuery();
            oCmd.Connection.Close();
            return result;
        }
        public static SqlDataReader EjecutarCmdRead(SqlCommand oCmd)
        {
            SqlDataReader oRead = oCmd.ExecuteReader(CommandBehavior.CloseConnection);
            return oRead;
        }
    }
}
