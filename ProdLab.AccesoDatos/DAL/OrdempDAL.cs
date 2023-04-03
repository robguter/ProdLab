using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ProdLab.EntidadesdeNegocio;

namespace ProdLab.AccesoDatos.DAL
{
    public class OrdempDAL
    {
        public static int Guardar(Ordemp ordModel)
        {
            int result = 0;
            string sSQL = @"INSERT INTO Ordemp(numoe, fecoe, codfor, deposie, lotee, fecinie, fecfine,
                                               kgspln, kgsobt, unipln, uniobt,  hh,  hm, status)
                                        VALUES(@Numo, @Feco,  @Codf,   @Depo, @Lote,   @Feci,   @Fecf,
                                               @Kgsp,   @Kgso,  @Unip,  @Unio, @Hh, @Hm,  @Stat)";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Numo", ordModel.numoe);
            oCmd.Parameters.AddWithValue("@Feco", ordModel.fecoe);
            oCmd.Parameters.AddWithValue("@Codf", ordModel.codfor);
            oCmd.Parameters.AddWithValue("@Depo", ordModel.deposie);
            oCmd.Parameters.AddWithValue("@Lote", ordModel.lotee);
            oCmd.Parameters.AddWithValue("@Feci", ordModel.fecinie);
            oCmd.Parameters.AddWithValue("@Fecf", ordModel.fecfine);
            oCmd.Parameters.AddWithValue("@Kgsp", ordModel.kgspln);
            oCmd.Parameters.AddWithValue("@Kgso", ordModel.kgsobt);
            oCmd.Parameters.AddWithValue("@Unip", ordModel.unipln);
            oCmd.Parameters.AddWithValue("@Unio", ordModel.uniobt);
            oCmd.Parameters.AddWithValue("@Hh", ordModel.hh);
            oCmd.Parameters.AddWithValue("@Hm", ordModel.hm);
            oCmd.Parameters.AddWithValue("@Stat", ordModel.status);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static int Editar(Ordemp ordModel)
        {
            int result = 0;
            string sSQL = @"UPDATE Ordemp SET
                                    fecoe= @Feco,
                                    codfor  = @Codf,
                                    deposie = @Depo,
                                    lotee   = @Lote,
                                    fecinie = @Feci,
                                    fecfine = @Fecf,
                                    kgspln  = @Kgsp,
                                    kgsobt  = @Kgso,
                                    unipln  = @Unip,
                                    uniobt  = @Unio,
                                    hh      = @Hh,
                                    hm      = @Hm,
                                    status  = @Stat
                               WHERE numoe  = @Numo";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Numo", ordModel.numoe);
            oCmd.Parameters.AddWithValue("@Feco", ordModel.fecoe);
            oCmd.Parameters.AddWithValue("@Codf", ordModel.codfor);
            oCmd.Parameters.AddWithValue("@Depo", ordModel.deposie);
            oCmd.Parameters.AddWithValue("@Lote", ordModel.lotee);
            oCmd.Parameters.AddWithValue("@Feci", ordModel.fecinie);
            oCmd.Parameters.AddWithValue("@Fecf", ordModel.fecfine);
            oCmd.Parameters.AddWithValue("@Kgsp", ordModel.kgspln);
            oCmd.Parameters.AddWithValue("@Kgso", ordModel.kgsobt);
            oCmd.Parameters.AddWithValue("@Unip", ordModel.unipln);
            oCmd.Parameters.AddWithValue("@Unio", ordModel.uniobt);
            oCmd.Parameters.AddWithValue("@Hh", ordModel.hh);
            oCmd.Parameters.AddWithValue("@Hm", ordModel.hm);
            oCmd.Parameters.AddWithValue("@Stat", ordModel.status);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static int Eliminar(string id)
        {
            int result = 0;
            string sSQL = @"DELETE FROM Ordemp
                            WHERE numoe = @Numo";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Numo", id);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static List<Ordemp> ObtenerTodos()
        {
            string sSQL = @"SELECT numoe, fecoe, codfor, deposie, lotee, fecinie, fecfine,
                                   kgspln, kgsobt, unipln, uniobt,  hh,  hm, status
                            FROM Ordemp
                            ORDER BY numoe Desc";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            SqlDataReader oRead = ComunDB.EjecutarCmdRead(oCmd);
            List<Ordemp> Lista = new List<Ordemp>();
            while (oRead.Read())
            {
                Ordemp oMov = new Ordemp();
                oMov.numoe = oRead.GetString(0);
                oMov.fecoe = oRead.GetDateTime(1);
                oMov.codfor = oRead.GetString(2);
                oMov.deposie = oRead.GetString(3);
                oMov.lotee = oRead.GetString(4);
                oMov.fecinie = oRead.GetDateTime(5);
                oMov.fecfine = oRead.GetDateTime(6);
                oMov.kgspln = (float)oRead.GetDecimal(7);
                oMov.kgsobt = (float)oRead.GetDecimal(8);
                oMov.unipln = (float)oRead.GetDecimal(9);
                oMov.uniobt = (float)oRead.GetDecimal(10);
                oMov.hh = (float)oRead.GetDecimal(11);
                oMov.hm = (float)oRead.GetDecimal(12);
                oMov.status = oRead.GetString(13);
                Lista.Add(oMov);
            }
            return Lista;
        }
        public static List<Ordemp> ObtenerById(string id)
        {
            string sSQL = @"SELECT numoe,fecoe,codfor,deposie,lotee,fecinie,fecfine,
                                    kgspln, kgsobt, unipln, uniobt,  hh,  hm, status
                            FROM Ordemp
                            WHERE numoe LIKE @Numo+'%'
                                  OR fecoe LIKE @Feco+'%'
                                  OR codfor LIKE @Codf+'%'
                                  OR deposie LIKE @lotee+'%'";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Numo", id);
            oCmd.Parameters.AddWithValue("@Feco", Convert.ToDateTime(id));
            oCmd.Parameters.AddWithValue("@Codf", id);
            oCmd.Parameters.AddWithValue("@lotee", id);
            SqlDataReader oRead = ComunDB.EjecutarCmdRead(oCmd);
            List<Ordemp> Lista = new List<Ordemp>();
            while (oRead.Read())
            {
                Ordemp oMov = new Ordemp();
                oMov.numoe = oRead.GetString(0);
                oMov.fecoe = oRead.GetDateTime(1);
                oMov.codfor = oRead.GetString(2);
                oMov.deposie = oRead.GetString(3);
                oMov.lotee = oRead.GetString(4);
                oMov.fecinie = oRead.GetDateTime(5);
                oMov.fecfine = oRead.GetDateTime(6);
                oMov.kgspln = (float)oRead.GetDecimal(7);
                oMov.kgsobt = (float)oRead.GetDecimal(8);
                oMov.unipln = (float)oRead.GetDecimal(9);
                oMov.uniobt = (float)oRead.GetDecimal(10);
                oMov.hh = (float)oRead.GetDecimal(11);
                oMov.hm = (float)oRead.GetDecimal(12);
                oMov.status = oRead.GetString(13);
                Lista.Add(oMov);
            }
            return Lista;
        }
    }
}
