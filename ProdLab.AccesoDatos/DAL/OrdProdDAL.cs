using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ProdLab.EntidadesdeNegocio;

namespace ProdLab.AccesoDatos.DAL
{
    public class OrdProdDAL
    {
        public static int Guardar(OrdProd ordModel)
        {
            int result = 0;
            string sSQL = @"INSERT INTO OrdProd(numop, fecop, codfor, deposip, lotep, fecinip, fecfinp,
                                               kgspln, kgsobt, hh,  hm, status)
                                        VALUES(@Numo, @Feco,  @Codf,   @Depo, @Lote,   @Feci,   @Fecf,
                                               @Kgsp,   @Kgso,@Hh, @Hm,  @Stat)";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Numo", ordModel.numop);
            oCmd.Parameters.AddWithValue("@Feco", ordModel.fecop);
            oCmd.Parameters.AddWithValue("@Codf", ordModel.codfor);
            oCmd.Parameters.AddWithValue("@Depo", ordModel.deposip);
            oCmd.Parameters.AddWithValue("@Lote", ordModel.lotep);
            oCmd.Parameters.AddWithValue("@Feci", ordModel.fecinip);
            oCmd.Parameters.AddWithValue("@Fecf", ordModel.fecfinp);
            oCmd.Parameters.AddWithValue("@Kgsp", ordModel.kgspln);
            oCmd.Parameters.AddWithValue("@Kgso", ordModel.kgsobt);
            oCmd.Parameters.AddWithValue("@Hh", ordModel.hh);
            oCmd.Parameters.AddWithValue("@Hm", ordModel.hm);
            oCmd.Parameters.AddWithValue("@Stat", ordModel.status);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static int Editar(OrdProd ordModel)
        {
            int result = 0;
            string sSQL = @"UPDATE OrdProd SET
                                    fecop= @Feco,
                                    codfor  = @Codf,
                                    deposip = @Depo,
                                    lotep   = @Lote,
                                    fecinip = @Feci,
                                    fecfinp = @Fecf,
                                    kgspln  = @Kgsp,
                                    kgsobt  = @Codf,
                                    hh      = @Feci,
                                    hm      = @Fecf,
                                    status  = @Kgsp
                               WHERE numop  = @Numo";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Numo", ordModel.numop);
            oCmd.Parameters.AddWithValue("@Feco", ordModel.fecop);
            oCmd.Parameters.AddWithValue("@Codf", ordModel.codfor);
            oCmd.Parameters.AddWithValue("@Depo", ordModel.deposip);
            oCmd.Parameters.AddWithValue("@Lote", ordModel.lotep);
            oCmd.Parameters.AddWithValue("@Feci", ordModel.fecinip);
            oCmd.Parameters.AddWithValue("@Fecf", ordModel.fecfinp);
            oCmd.Parameters.AddWithValue("@Kgsp", ordModel.kgspln);
            oCmd.Parameters.AddWithValue("@Kgso", ordModel.kgsobt);
            oCmd.Parameters.AddWithValue("@Hh", ordModel.hh);
            oCmd.Parameters.AddWithValue("@Hm", ordModel.hm);
            oCmd.Parameters.AddWithValue("@Stat", ordModel.status);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static int Eliminar(string id)
        {
            int result = 0;
            string sSQL = @"DELETE FROM OrdProd
                            WHERE numop = @Numo";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Numo", id);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static List<OrdProd> ObtenerTodos()
        {
            string sSQL = @"SELECT numop, fecop, codfor, deposip, lotep, fecinip, fecfinp,
                                   kgspln, kgsobt, hh,  hm, status
                            FROM OrdProd
                            ORDER BY numop Desc";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            SqlDataReader oRead = ComunDB.EjecutarCmdRead(oCmd);
            List<OrdProd> Lista = new List<OrdProd>();
            while (oRead.Read())
            {
                OrdProd oMov = new OrdProd();
                oMov.numop = oRead.GetString(0);
                oMov.fecop = oRead.GetDateTime(1);
                oMov.codfor = oRead.GetString(2);
                oMov.deposip = oRead.GetString(3);
                oMov.lotep = oRead.GetString(4);
                oMov.fecinip = oRead.GetDateTime(5);
                oMov.fecfinp = oRead.GetDateTime(6);
                oMov.kgspln = (float)oRead.GetDecimal(7);
                oMov.kgsobt = (float)oRead.GetDecimal(8);
                oMov.hh = (float)oRead.GetDecimal(11);
                oMov.hm = (float)oRead.GetDecimal(12);
                oMov.status = oRead.GetString(13);
                Lista.Add(oMov);
            }
            return Lista;
        }
        public static List<OrdProd> ObtenerById(string id)
        {
            string sSQL = @"SELECT numop,fecop,codfor,deposip,lotep,fecinip,fecfinp,
                                    kgspln, kgsobt, hh,  hm, status
                            FROM OrdProd
                            WHERE numop LIKE @Numo+'%'
                                  OR fecop LIKE @Feco+'%'
                                  OR codfor LIKE @Codf+'%'
                                  OR deposip LIKE @lotep+'%'";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Numo", id);
            oCmd.Parameters.AddWithValue("@Feco", Convert.ToDateTime(id));
            oCmd.Parameters.AddWithValue("@Codf", id);
            oCmd.Parameters.AddWithValue("@lotep", id);
            SqlDataReader oRead = ComunDB.EjecutarCmdRead(oCmd);
            List<OrdProd> Lista = new List<OrdProd>();
            while (oRead.Read())
            {
                OrdProd oMov = new OrdProd();
                oMov.numop = oRead.GetString(0);
                oMov.fecop = oRead.GetDateTime(1);
                oMov.codfor = oRead.GetString(2);
                oMov.deposip = oRead.GetString(3);
                oMov.lotep = oRead.GetString(4);
                oMov.fecinip = oRead.GetDateTime(5);
                oMov.fecfinp = oRead.GetDateTime(6);
                oMov.kgspln = (float)oRead.GetDecimal(7);
                oMov.kgsobt = (float)oRead.GetDecimal(8);
                oMov.hh = (float)oRead.GetDecimal(11);
                oMov.hm = (float)oRead.GetDecimal(12);
                oMov.status = oRead.GetString(13);
                Lista.Add(oMov);
            }
            return Lista;
        }
    }
}
