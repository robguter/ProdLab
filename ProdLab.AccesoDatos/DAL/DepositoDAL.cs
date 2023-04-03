using System.Collections.Generic;
using System.Data.SqlClient;
using ProdLab.EntidadesdeNegocio;

namespace ProdLab.AccesoDatos.DAL
{
    public class DepositoDAL
    {
        public static int Guardar(Deposito depModel)
        {
            int result = 0;
            string sSQL = @"INSERT INTO Deposito(deposito,indole, zona,  subzona)
                                          VALUES(@depo,   @indo,  @zona, @subz";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@depo", depModel.deposito);
            oCmd.Parameters.AddWithValue("@indo", depModel.indole);
            oCmd.Parameters.AddWithValue("@zona", depModel.zona);
            oCmd.Parameters.AddWithValue("@subz", depModel.subzona);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static int Editar(Deposito depModel)
        {
            int result = 0;
            string sSQL = @"UPDATE Deposito SET
                                    deposito= @depo,
                                    indole  = @indo,
                                    zona    = @zona,
                                    subzona = @subz
                                   WHERE id = @id";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@id",   depModel.id);
            oCmd.Parameters.AddWithValue("@depo", depModel.deposito);
            oCmd.Parameters.AddWithValue("@indo", depModel.indole);
            oCmd.Parameters.AddWithValue("@zona", depModel.zona);
            oCmd.Parameters.AddWithValue("@subz", depModel.subzona);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static int Eliminar(string id)
        {
            int result = 0;
            string sSQL = @"DELETE FROM deposito
                            WHERE id = @id";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@id", id);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static List<Deposito> ObtenerTodos()
        {
            string sSQL = @"SELECT id,deposito,indole, zona,  subzona
                            FROM deposito
                            ORDER BY id";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            SqlDataReader oRead = ComunDB.EjecutarCmdRead(oCmd);
            List<Deposito> Lista = new List<Deposito>();
            while (oRead.Read())
            {
                Deposito oDepo = new Deposito();
                oDepo.id = oRead.GetInt32(0);
                oDepo.deposito = oRead.GetString(1);
                oDepo.indole = oRead.GetString(2);
                oDepo.zona = oRead.GetString(3);
                oDepo.subzona = oRead.GetString(4);
                Lista.Add(oDepo);
            }
            return Lista;
        }
        public static List<Deposito> ObtenerById(string id)
        {
            string sSQL = @"SELECT Codigo,Descripcion,Unimed,Indole,
                                   StkMax,StkMin,EmpaqueUnd,Status
                            FROM deposito
                            WHERE id LIKE @id+'%'
                                  OR deposito LIKE @Depo+'%'
                                  OR indole LIKE @Indo+'%'";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@id", id);
            oCmd.Parameters.AddWithValue("@Depo", id);
            oCmd.Parameters.AddWithValue("@Indo", id);
            SqlDataReader oRead = ComunDB.EjecutarCmdRead(oCmd);
            List<Deposito> Lista = new List<Deposito>();
            while (oRead.Read())
            {
                Deposito oDepo = new Deposito();
                oDepo.id = oRead.GetInt32(0);
                oDepo.deposito = oRead.GetString(1);
                oDepo.indole = oRead.GetString(2);
                oDepo.zona = oRead.GetString(3);
                oDepo.subzona = oRead.GetString(4);
                Lista.Add(oDepo);
            }
            return Lista;
        }
    }
}
