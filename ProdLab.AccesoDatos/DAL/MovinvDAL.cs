using System.Collections.Generic;
using System.Data.SqlClient;
using ProdLab.EntidadesdeNegocio;

namespace ProdLab.AccesoDatos.DAL
{
    public class MovinvDAL
    {
        public static int Guardar(Movinv movModel)
        {
            int result = 0;
            string sSQL = @"INSERT INTO Movinv(ukey, fecharef, docref, tipref, fecreg, nota, status, ultmod)
                                        VALUES(@Ukey,@FRef,    @Docr,  @Tipr,  @FReg,  @Nota,@Stat,  @Ultm)";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Ukey", movModel.ukey);
            oCmd.Parameters.AddWithValue("@FRef", movModel.fecharef);
            oCmd.Parameters.AddWithValue("@Docr", movModel.docref);
            oCmd.Parameters.AddWithValue("@Tipr", movModel.tipref);
            oCmd.Parameters.AddWithValue("@FReg", movModel.fecreg);
            oCmd.Parameters.AddWithValue("@Nota", movModel.nota);
            oCmd.Parameters.AddWithValue("@Stat", movModel.status);
            oCmd.Parameters.AddWithValue("@Ultm", movModel.ultmod);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static int Editar(Movinv movModel)
        {
            int result = 0;
            string sSQL = @"UPDATE Movinv SET
                                    fecharef= @FRef,
                                    docref  = @Docr,
                                    tipref  = @Tipr,
                                    fecreg  = @FReg,
                                    nota    = @Nota,
                                    status  = @Stat,
                                    ultmod  = @Ultm
                               WHERE ukey   = @Ukey";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Ukey", movModel.ukey);
            oCmd.Parameters.AddWithValue("@FRef", movModel.fecharef);
            oCmd.Parameters.AddWithValue("@Docr", movModel.docref);
            oCmd.Parameters.AddWithValue("@Tipr", movModel.tipref);
            oCmd.Parameters.AddWithValue("@FReg", movModel.fecreg);
            oCmd.Parameters.AddWithValue("@Nota", movModel.nota);
            oCmd.Parameters.AddWithValue("@Stat", movModel.status);
            oCmd.Parameters.AddWithValue("@Ultm", movModel.ultmod);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static int Eliminar(string id)
        {
            int result = 0;
            string sSQL = @"DELETE FROM Movinv
                            WHERE ukey = @Ukey";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Ukey", id);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static List<Movinv> ObtenerTodos()
        {
            string sSQL = @"SELECT ukey,fecharef,docref,tipref,fecreg,nota,status,ultmod
                            FROM Movinv
                            ORDER BY ukey";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            SqlDataReader oRead = ComunDB.EjecutarCmdRead(oCmd);
            List<Movinv> Lista = new List<Movinv>();
            while (oRead.Read())
            {
                Movinv oMov = new Movinv();
                oMov.ukey = oRead.GetString(0);
                oMov.fecharef = oRead.GetDateTime(1);
                oMov.docref = oRead.GetString(2);
                oMov.tipref = oRead.GetString(3);
                oMov.fecreg = oRead.GetDateTime(4);
                oMov.nota = oRead.GetString(5);
                oMov.status = oRead.GetString(6);
                oMov.ultmod = oRead.GetDateTime(7);
                Lista.Add(oMov);
            }
            return Lista;
        }
        public static List<Movinv> ObtenerById(string id)
        {
            string sSQL = @"SELECT ukey,fecharef,docref,tipref,
                                   fecreg,nota,status,ultmod
                            FROM Movinv
                            WHERE ukey LIKE @Ukey+'%'
                                  OR fecharef LIKE @FRef+'%'
                                  OR docref LIKE @Docr+'%'
                                  OR tipref LIKE @Tipr+'%'";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Ukey", id);
            oCmd.Parameters.AddWithValue("@FRef", id);
            oCmd.Parameters.AddWithValue("@Docr", id);
            oCmd.Parameters.AddWithValue("@Tipr", id);
            SqlDataReader oRead = ComunDB.EjecutarCmdRead(oCmd);
            List<Movinv> Lista = new List<Movinv>();
            while (oRead.Read())
            {
                Movinv oMov = new Movinv();
                oMov.ukey = oRead.GetString(0);
                oMov.fecharef = oRead.GetDateTime(1);
                oMov.docref = oRead.GetString(2);
                oMov.tipref = oRead.GetString(3);
                oMov.fecreg = oRead.GetDateTime(4);
                oMov.nota = oRead.GetString(5);
                oMov.status = oRead.GetString(6);
                oMov.ultmod = oRead.GetDateTime(7);
                Lista.Add(oMov);
            }
            return Lista;
        }
    }
}
