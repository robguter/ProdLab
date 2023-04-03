using System.Collections.Generic;
using ProdLab.EntidadesdeNegocio;
using System.Data.SqlClient;

namespace ProdLab.AccesoDatos.DAL
{
    public class MaestrodetDAL
    {
        public static List<Maestrodet> ObtenerTodos()
        {
            string sSQL = @"SELECT codfor,Codigo,Cantidad,Paso,Difuni
                            FROM maestrodet
                            ORDER BY codfor";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            SqlDataReader oRead = ComunDB.EjecutarCmdRead(oCmd);
            List<Maestrodet> Lista = new List<Maestrodet>();
            while (oRead.Read())
            {
                Maestrodet oMaes = new Maestrodet();
                oMaes.Codfor = oRead.GetString(0);
                oMaes.Codigo = oRead.GetString(1);
                oMaes.Cantidad = (float)oRead.GetDecimal(2);
                oMaes.Paso = oRead.GetInt32(3);
                oMaes.Difuni = oRead.GetString(4);
                Lista.Add(oMaes);
            }
            return Lista;
        }
        public static List<Maestrodet> ObtenerById(string valor)
        {
            string sSQL = @"SELECT codfor,Codigo,Cantidad,Paso,Difuni
                            FROM maestrodet
                            WHERE codfor LIKE @Codf+'%'
                                  OR Codigo LIKE @Codi+'%'";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Codf", valor);
            oCmd.Parameters.AddWithValue("@Codi", valor);
            SqlDataReader oRead = ComunDB.EjecutarCmdRead(oCmd);
            List<Maestrodet> Lista = new List<Maestrodet>();
            while (oRead.Read())
            {
                Maestrodet oMaes = new Maestrodet();
                oMaes.Codfor = oRead.GetString(0);
                oMaes.Codigo = oRead.GetString(1);
                oMaes.Cantidad = (float)oRead.GetDecimal(2);
                oMaes.Paso = oRead.GetInt32(3);
                oMaes.Difuni = oRead.GetString(4);
                Lista.Add(oMaes);
            }
            return Lista;
        }
        public static int Guardar(Maestrodet maeModel)
        {
            int result = 0;
            string sSQL = @"INSERT INTO maestrodet(codfor,Codigo,Cantidad,Paso,Difuni)
                                            VALUES(@Codf, @Codi, @Cant,   @Paso,@Difu)";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Codf", maeModel.Codfor);
            oCmd.Parameters.AddWithValue("@Codi", maeModel.Codigo);
            oCmd.Parameters.AddWithValue("@Cant", maeModel.Cantidad);
            oCmd.Parameters.AddWithValue("@Paso", maeModel.Paso);
            oCmd.Parameters.AddWithValue("@Difu", maeModel.Difuni);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static int Editar(Maestrodet maeModel)
        {
            int result = 0;
            string sSQL = @"UPDATE maestrodet SET
                                    Codigo  = @Codi,
                                    Cantidad= @Cant,
                                    Paso    = @Paso,
                                    Difuni  = @Difu
                               WHERE codfor = @Codf";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Codf", maeModel.Codfor);
            oCmd.Parameters.AddWithValue("@Codi", maeModel.Codigo);
            oCmd.Parameters.AddWithValue("@Cant", maeModel.Cantidad);
            oCmd.Parameters.AddWithValue("@Paso", maeModel.Paso);
            oCmd.Parameters.AddWithValue("@Difu", maeModel.Difuni);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static int Eliminar(string codfor)
        {
            int result = 0;
            string sSQL = @"DELETE FROM maestrodet
                            WHERE codfor = @Codf";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Codf", codfor);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
    }
}
