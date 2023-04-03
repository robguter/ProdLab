using System.Collections.Generic;
using System.Data.SqlClient;
using ProdLab.EntidadesdeNegocio;

namespace ProdLab.AccesoDatos.DAL
{
    public class InvenstkDAL
    {
        public static int Guardar(Invenstk depoModel)
        {
            int result = 0;
            string sSQL = @"INSERT INTO invenstk(codigo,  lote,deposito,stkAct,stkRes,costoun,fechaven)
                                          VALUES( @Codi, @lote,   @depo, @stka, @stkr,  @cost,   @fech)";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Codi", depoModel.codigo);
            oCmd.Parameters.AddWithValue("@lote", depoModel.lote);
            oCmd.Parameters.AddWithValue("@depo", depoModel.deposito);
            oCmd.Parameters.AddWithValue("@stka", depoModel.stkAct);
            oCmd.Parameters.AddWithValue("@stkr", depoModel.stkRes);
            oCmd.Parameters.AddWithValue("@cost", depoModel.costoun);
            oCmd.Parameters.AddWithValue("@fech", depoModel.fechaven);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static int Editar(Invenstk depoModel)
        {
            int result = 0;
            string sSQL = @"UPDATE invenstk SET
                                    lote    = @lote,
                                    deposito= @depo,
                                    stkAct  = @stka,
                                    stkRes  = @stkr,
                                    costoun = @cost,
                                    fechaven= @fech
                               WHERE Codigo = @Codi";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Codi", depoModel.codigo);
            oCmd.Parameters.AddWithValue("@lote", depoModel.lote);
            oCmd.Parameters.AddWithValue("@depo", depoModel.deposito);
            oCmd.Parameters.AddWithValue("@stka", depoModel.stkAct);
            oCmd.Parameters.AddWithValue("@stkr", depoModel.stkRes);
            oCmd.Parameters.AddWithValue("@cost", depoModel.costoun);
            oCmd.Parameters.AddWithValue("@fech", depoModel.fechaven);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static int Eliminar(string id)
        {
            int result = 0;
            string sSQL = @"DELETE FROM invenstk
                            WHERE Codigo = @Codi";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Codi", id);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static List<Invenstk> ObtenerTodos()
        {
            string sSQL = @"SELECT codigo, lote, deposito, stkAct, stkRes, costoun, fechaven
                            FROM invenstk
                            ORDER BY Codigo";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            SqlDataReader oRead = ComunDB.EjecutarCmdRead(oCmd);
            List<Invenstk> Lista = new List<Invenstk>();
            while (oRead.Read())
            {
                Invenstk oProd = new Invenstk();
                oProd.codigo = oRead.GetString(0);
                oProd.lote = oRead.GetString(1);
                oProd.deposito = oRead.GetString(2);
                oProd.stkAct = (float)oRead.GetDecimal(3);
                oProd.stkRes = (float)oRead.GetDecimal(4);
                oProd.costoun = (float)oRead.GetDecimal(5);
                oProd.fechaven = oRead.GetDateTime(6);
                Lista.Add(oProd);
            }
            return Lista;
        }
        public static List<Invenstk> ObtenerById(string id)
        {
            string sSQL = @"SELECT codigo, lote, deposito, stkAct, stkRes, costoun, fechaven
                            FROM Invenstk
                            WHERE Codigo LIKE @Codi+'%'
                                  OR lote LIKE @Lote+'%'
                                  OR deposito LIKE @Depo+'%'";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Codi", id);
            oCmd.Parameters.AddWithValue("@Lote", id);
            oCmd.Parameters.AddWithValue("@Depo", id);
            SqlDataReader oRead = ComunDB.EjecutarCmdRead(oCmd);
            List<Invenstk> Lista = new List<Invenstk>();
            while (oRead.Read())
            {
                Invenstk oProd = new Invenstk();
                oProd.codigo = oRead.GetString(0);
                oProd.lote = oRead.GetString(1);
                oProd.deposito = oRead.GetString(2);
                oProd.stkAct = (float)oRead.GetDecimal(3);
                oProd.stkRes = (float)oRead.GetDecimal(4);
                oProd.costoun = (float)oRead.GetDecimal(5);
                oProd.fechaven = oRead.GetDateTime(6);
                Lista.Add(oProd);
            }
            return Lista;
        }
    }
}
