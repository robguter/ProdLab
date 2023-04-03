using System.Collections.Generic;
using System.Data.SqlClient;
using ProdLab.EntidadesdeNegocio;

namespace ProdLab.AccesoDatos.DAL
{
    public class MovdetDAL
    {
        public static int Guardar(Movdet movModel)
        {
            int result = 0;
            string sSQL = @"INSERT INTO Movdet(ukey, codigo, deposito, lote, cantidad, fecven)
                                        VALUES(@Ukey,@Codi,    @Depo,  @Lote,  @Cant,  @Fvnc)";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Ukey", movModel.ukey);
            oCmd.Parameters.AddWithValue("@Codi", movModel.codigo);
            oCmd.Parameters.AddWithValue("@Depo", movModel.deposito);
            oCmd.Parameters.AddWithValue("@Lote", movModel.lote);
            oCmd.Parameters.AddWithValue("@Cant", movModel.cantidad);
            oCmd.Parameters.AddWithValue("@Fvnc", movModel.fecven);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static int Editar(Movdet movModel)
        {
            int result = 0;
            string sSQL = @"UPDATE Movdet SET
                                    codigo= @Codi,
                                    deposito  = @Depo,
                                    lote  = @Lote,
                                    cantidad  = @Cant,
                                    fecven    = @Fvnc
                               WHERE ukey   = @Ukey";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Ukey", movModel.ukey);
            oCmd.Parameters.AddWithValue("@Codi", movModel.codigo);
            oCmd.Parameters.AddWithValue("@Depo", movModel.deposito);
            oCmd.Parameters.AddWithValue("@Lote", movModel.lote);
            oCmd.Parameters.AddWithValue("@Cant", movModel.cantidad);
            oCmd.Parameters.AddWithValue("@Fvnc", movModel.fecven);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static int Eliminar(string id)
        {
            int result = 0;
            string sSQL = @"DELETE FROM Movdet
                            WHERE ukey = @Ukey";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Ukey", id);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static List<Movdet> ObtenerTodos()
        {
            string sSQL = @"SELECT ukey,codigo,deposito,lote,cantidad,fecven
                            FROM Movdet
                            ORDER BY ukey";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            SqlDataReader oRead = ComunDB.EjecutarCmdRead(oCmd);
            List<Movdet> Lista = new List<Movdet>();
            while (oRead.Read())
            {
                Movdet oMov = new Movdet();
                oMov.ukey = oRead.GetString(0);
                oMov.codigo = oRead.GetString(1);
                oMov.deposito = oRead.GetString(2);
                oMov.lote = oRead.GetString(3);
                oMov.cantidad = (float)oRead.GetDecimal(4);
                oMov.fecven = oRead.GetDateTime(5);
                Lista.Add(oMov);
            }
            return Lista;
        }
        public static List<Movdet> ObtenerById(string id)
        {
            string sSQL = @"SELECT ukey,codigo,deposito,lote,cantidad,fecven
                            FROM Movdet
                            WHERE ukey LIKE @Ukey+'%'
                                  OR codigo LIKE @Codi+'%'
                                  OR deposito LIKE @Depo+'%'
                                  OR lote LIKE @Lote+'%'";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Ukey", id);
            oCmd.Parameters.AddWithValue("@Codi", id);
            oCmd.Parameters.AddWithValue("@Depo", id);
            oCmd.Parameters.AddWithValue("@Lote", id);
            SqlDataReader oRead = ComunDB.EjecutarCmdRead(oCmd);
            List<Movdet> Lista = new List<Movdet>();
            while (oRead.Read())
            {
                Movdet oMov = new Movdet();
                oMov.ukey = oRead.GetString(0);
                oMov.codigo = oRead.GetString(1);
                oMov.deposito = oRead.GetString(2);
                oMov.lote = oRead.GetString(3);
                oMov.cantidad = (float)oRead.GetDecimal(4);
                oMov.fecven = oRead.GetDateTime(5);
                Lista.Add(oMov);
            }
            return Lista;
        }
    }
}
