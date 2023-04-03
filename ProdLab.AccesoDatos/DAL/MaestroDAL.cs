using System.Collections.Generic;
using ProdLab.EntidadesdeNegocio;
using System.Data.SqlClient;

namespace ProdLab.AccesoDatos.DAL
{
    public class MaestroDAL
    {
        public static List<Maestro> ObtenerTodos()
        {
            string sSQL = @"SELECT codfor,descri,unimed,stdbatch,
                                   formafar,estatus,fecharev
                            FROM maestro
                            ORDER BY codfor";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            SqlDataReader oRead = ComunDB.EjecutarCmdRead(oCmd);
            List<Maestro> Lista = new List<Maestro>();
            while (oRead.Read())
            {
                Maestro oMaes = new Maestro();
                oMaes.codfor = oRead.GetString(0);
                oMaes.descri = oRead.GetString(1);
                oMaes.unimed = oRead.GetString(2);
                oMaes.stdbatch = oRead.GetInt32(3);
                oMaes.formafar = oRead.GetString(4);
                oMaes.estatus = oRead.GetString(5);
                oMaes.fecharev = oRead.GetDateTime(6);
                Lista.Add(oMaes);
            }
            return Lista;
        }
        public static List<Maestro> ObtenerById(string valor)
        {
            string sSQL = @"SELECT codfor,descri,unimed,stdbatch,
                                   formafar,estatus,fecharev
                            FROM maestro
                            WHERE codfor LIKE @Codf+'%'
                                  OR descri LIKE @Desc+'%'
                                  OR formafar LIKE @Form+'%'";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Codf", valor);
            oCmd.Parameters.AddWithValue("@Desc", valor);
            oCmd.Parameters.AddWithValue("@Form", valor);
            SqlDataReader oRead = ComunDB.EjecutarCmdRead(oCmd);
            List<Maestro> Lista = new List<Maestro>();
            while (oRead.Read())
            {
                Maestro oMaes = new Maestro();
                oMaes.codfor = oRead.GetString(0);
                oMaes.descri = oRead.GetString(1);
                oMaes.unimed = oRead.GetString(2);
                oMaes.stdbatch = oRead.GetInt32(3);
                oMaes.formafar = oRead.GetString(4);
                oMaes.estatus = oRead.GetString(5);
                oMaes.fecharev = oRead.GetDateTime(6);
                Lista.Add(oMaes);
            }
            return Lista;
        }
        public static int Guardar(Maestro maeModel)
        {
            int result = 0;
            string sSQL = @"INSERT INTO Maestro(codfor,descri,unimed,stdbatch,
                                                formafar,estatus,fecharev)
                                         VALUES(@Codf, @Desc, @Unim, @Stdb,
                                                @Form,   @Esta,  @Fech)";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Codf", maeModel.codfor);
            oCmd.Parameters.AddWithValue("@Desc", maeModel.descri);
            oCmd.Parameters.AddWithValue("@Unim", maeModel.unimed);
            oCmd.Parameters.AddWithValue("@Stdb", maeModel.stdbatch);
            oCmd.Parameters.AddWithValue("@Form", maeModel.formafar);
            oCmd.Parameters.AddWithValue("@Esta", maeModel.estatus);
            oCmd.Parameters.AddWithValue("@Fech", maeModel.fecharev);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static int Editar(Maestro maeModel)
        {
            int result = 0;
            string sSQL = @"UPDATE Maestro SET
                                    descri  = @Desc,
                                    unimed  = @Unim,
                                    stdbatch= @Stdb,
                                    formafar= @Form,
                                    estatus = @Esta,
                                    fecharev= @Fech
                               WHERE codfor = @Codf";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Codf", maeModel.codfor);
            oCmd.Parameters.AddWithValue("@Desc", maeModel.descri);
            oCmd.Parameters.AddWithValue("@Unim", maeModel.unimed);
            oCmd.Parameters.AddWithValue("@Stdb", maeModel.stdbatch);
            oCmd.Parameters.AddWithValue("@Form", maeModel.formafar);
            oCmd.Parameters.AddWithValue("@Esta", maeModel.estatus);
            oCmd.Parameters.AddWithValue("@Fech", maeModel.fecharev);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static int Eliminar(string codfor)
        {
            int result = 0;
            string sSQL = @"DELETE FROM maestro
                            WHERE codfor = @Codf";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Codf", codfor);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
    }
}
