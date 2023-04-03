using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ProdLab.EntidadesdeNegocio;

namespace ProdLab.AccesoDatos.DAL
{
    public class OrdacoDAL
    {
        public static int Guardar(Ordaco ordModel)
        {
            int result = 0;
            string sSQL = @"INSERT INTO Ordaco(numoa, fecoa, codfor, deposia, lotea, fecinia, fecfina,
                                               kgspln, kgsobt, unipln, uniobt,  hh,  hm, status)
                                        VALUES(@Numo, @Feco,  @Codf,   @Depo, @Lote,   @Feci,   @Fecf,
                                               @Kgsp,   @Kgso,  @Unip,  @Unio, @Hh, @Hm,  @Stat)";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Numo", ordModel.numoa);
            oCmd.Parameters.AddWithValue("@Feco", ordModel.fecoa);
            oCmd.Parameters.AddWithValue("@Codf", ordModel.codfor);
            oCmd.Parameters.AddWithValue("@Depo", ordModel.deposia);
            oCmd.Parameters.AddWithValue("@Lote", ordModel.lotea);
            oCmd.Parameters.AddWithValue("@Feci", ordModel.fecinia);
            oCmd.Parameters.AddWithValue("@Fecf", ordModel.fecfina);
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
        public static int Editar(Ordaco ordModel)
        {
            int result = 0;
            string sSQL = @"UPDATE Ordaco SET
                                    fecoa= @Feco,
                                    codfor  = @Codf,
                                    deposia = @Depo,
                                    lotea   = @Lote,
                                    fecinia = @Feci,
                                    fecfina = @Fecf,
                                    kgspln  = @Kgsp,
                                    kgsobt  = @Codf,
                                    unipln  = @Depo,
                                    kgsobt  = @Lote,
                                    hh      = @Feci,
                                    hm      = @Fecf,
                                    status  = @Kgsp
                               WHERE numoa  = @Numo";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Numo", ordModel.numoa);
            oCmd.Parameters.AddWithValue("@Feco", ordModel.fecoa);
            oCmd.Parameters.AddWithValue("@Codf", ordModel.codfor);
            oCmd.Parameters.AddWithValue("@Depo", ordModel.deposia);
            oCmd.Parameters.AddWithValue("@Lote", ordModel.lotea);
            oCmd.Parameters.AddWithValue("@Feci", ordModel.fecinia);
            oCmd.Parameters.AddWithValue("@Fecf", ordModel.fecfina);
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
            string sSQL = @"DELETE FROM Ordaco
                            WHERE numoa = @Numo";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Numo", id);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static List<Ordaco> ObtenerTodos()
        {
            string sSQL = @"SELECT numoa, fecoa, codfor, deposia, lotea, fecinia, fecfina,
                                   kgspln, kgsobt, unipln, uniobt,  hh,  hm, status
                            FROM Ordaco
                            ORDER BY numoa Desc";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            SqlDataReader oRead = ComunDB.EjecutarCmdRead(oCmd);
            List<Ordaco> Lista = new List<Ordaco>();
            while (oRead.Read())
            {
                Ordaco oMov = new Ordaco();
                oMov.numoa = oRead.GetString(0);
                oMov.fecoa = oRead.GetDateTime(1);
                oMov.codfor = oRead.GetString(2);
                oMov.deposia = oRead.GetString(3);
                oMov.lotea = oRead.GetString(4);
                oMov.fecinia = oRead.GetDateTime(5);
                oMov.fecfina = oRead.GetDateTime(6);
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
        public static List<Ordaco> ObtenerById(string id)
        {
            string sSQL = @"SELECT numoa,fecoa,codfor,deposia,lotea,fecinia,fecfina,
                                    kgspln, kgsobt, unipln, uniobt,  hh,  hm, status
                            FROM Ordaco
                            WHERE numoa LIKE @Numo+'%'
                                  OR fecoa LIKE @Feco+'%'
                                  OR codfor LIKE @Codf+'%'
                                  OR deposia LIKE @lotea+'%'";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Numo", id);
            oCmd.Parameters.AddWithValue("@Feco", Convert.ToDateTime(id));
            oCmd.Parameters.AddWithValue("@Codf", id);
            oCmd.Parameters.AddWithValue("@lotea", id);
            SqlDataReader oRead = ComunDB.EjecutarCmdRead(oCmd);
            List<Ordaco> Lista = new List<Ordaco>();
            while (oRead.Read())
            {
                Ordaco oMov = new Ordaco();
                oMov.numoa = oRead.GetString(0);
                oMov.fecoa = oRead.GetDateTime(1);
                oMov.codfor = oRead.GetString(2);
                oMov.deposia = oRead.GetString(3);
                oMov.lotea = oRead.GetString(4);
                oMov.fecinia = oRead.GetDateTime(5);
                oMov.fecfina = oRead.GetDateTime(6);
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
