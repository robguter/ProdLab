using System.Collections.Generic;
using System.Data.SqlClient;
using ProdLab.EntidadesdeNegocio;

namespace ProdLab.AccesoDatos.DAL
{
    public class OrdacodetDAL
    {
        public static int Guardar(Ordacodet ordModel)
        {
            int result = 0;
            string sSQL = @"INSERT INTO Ordacodet(numoa, paso,codigo,deposito, lote,cntreq,cntent,costo)
                                           VALUES(@Numo,@Paso, @Codi,   @Depo,@Lote, @Cntr, @Cnte,@Cost)";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Numo", ordModel.numoa);
            oCmd.Parameters.AddWithValue("@Paso", ordModel.paso);
            oCmd.Parameters.AddWithValue("@Codi", ordModel.codigo);
            oCmd.Parameters.AddWithValue("@Depo", ordModel.deposito);
            oCmd.Parameters.AddWithValue("@Lote", ordModel.lote);
            oCmd.Parameters.AddWithValue("@Cntr", ordModel.cntreq);
            oCmd.Parameters.AddWithValue("@Cnte", ordModel.cntent);
            oCmd.Parameters.AddWithValue("@Cost", ordModel.costo);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static int Editar(Ordacodet ordModel)
        {
            int result = 0;
            string sSQL = @"UPDATE Ordacodet SET
                                    paso    = @Paso,
                                    codigo  = @Codi,
                                    deposito= @Depo,
                                    lote    = @Lote,
                                    cntreq  = @Cntr,
                                    cntent  = @Cnte,
                                    costo   = @Cost
                               WHERE numoa  = @Numo";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Numo", ordModel.numoa);
            oCmd.Parameters.AddWithValue("@Paso", ordModel.paso);
            oCmd.Parameters.AddWithValue("@Codi", ordModel.codigo);
            oCmd.Parameters.AddWithValue("@Depo", ordModel.deposito);
            oCmd.Parameters.AddWithValue("@Lote", ordModel.lote);
            oCmd.Parameters.AddWithValue("@Cntr", ordModel.cntreq);
            oCmd.Parameters.AddWithValue("@Cnte", ordModel.cntent);
            oCmd.Parameters.AddWithValue("@Cost", ordModel.costo);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static int Eliminar(string id)
        {
            int result = 0;
            string sSQL = @"DELETE FROM Ordacodet
                            WHERE numoa = @Numo";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Numo", id);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static List<Ordacodet> ObtenerTodos()
        {
            string sSQL = @"SELECT numoa, paso, codigo, deposito, lote, cntreq, cntent, costo
                            FROM Ordacodet
                            ORDER BY numoa Desc";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            SqlDataReader oRead = ComunDB.EjecutarCmdRead(oCmd);
            List<Ordacodet> Lista = new List<Ordacodet>();
            while (oRead.Read())
            {
                Ordacodet oMov = new Ordacodet();
                oMov.numoa = oRead.GetString(0);
                oMov.paso = oRead.GetInt32(1);
                oMov.codigo = oRead.GetString(2);
                oMov.deposito = oRead.GetString(3);
                oMov.lote = oRead.GetString(4);
                oMov.cntreq = (float)oRead.GetDecimal(5);
                oMov.cntent = (float)oRead.GetDecimal(6);
                oMov.costo = (float)oRead.GetDecimal(7);
                Lista.Add(oMov);
            }
            return Lista;
        }
        public static List<Ordacodet> ObtenerById(string id)
        {
            string sSQL = @"SELECT numoa,paso,codigo,deposito,
                                   lote,cntreq,cntent,costo
                            FROM Ordacodet
                            WHERE numoa LIKE @Numo+'%'
                                  OR codigo LIKE @Codi+'%'
                                  OR lote LIKE @lote+'%'";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Numo", id);
            oCmd.Parameters.AddWithValue("@Codi", id);
            oCmd.Parameters.AddWithValue("@lote", id);
            SqlDataReader oRead = ComunDB.EjecutarCmdRead(oCmd);
            List<Ordacodet> Lista = new List<Ordacodet>();
            while (oRead.Read())
            {
                Ordacodet oMov = new Ordacodet();
                oMov.numoa = oRead.GetString(0);
                oMov.paso = oRead.GetInt32(1);
                oMov.codigo = oRead.GetString(2);
                oMov.deposito = oRead.GetString(3);
                oMov.lote = oRead.GetString(4);
                oMov.cntreq = (float)oRead.GetDecimal(5);
                oMov.cntent = (float)oRead.GetDecimal(6);
                oMov.costo = (float)oRead.GetDecimal(7);
                Lista.Add(oMov);
            }
            return Lista;
        }
    }
}
