using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ProdLab.EntidadesdeNegocio;

namespace ProdLab.AccesoDatos
{
    public class IndolesDAL
    {
        public static List<Indoles> ObtenerTodos()
        {
            string sSQL = @"SELECT id,indole,descripcion,iddepo
                            FROM indoles
                            ORDER BY id";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            SqlDataReader oRead = ComunDB.EjecutarCmdRead(oCmd);
            List<Indoles> Lista = new List<Indoles>();
            while (oRead.Read())
            {
                Indoles oIndo = new Indoles();
                oIndo.id = oRead.GetInt32(0);
                oIndo.indole = oRead.GetString(1);
                oIndo.descripcion = oRead.GetString(2);
                oIndo.iddepo = oRead.GetInt32(3);
                Lista.Add(oIndo);
            }
            return Lista;
        }
        public static List<Indoles> ObtenerById(string id)
        {
            string sSQL = @"SELECT id,indole,descripcion,iddepo
                            FROM indoles
                            WHERE id LIKE @id+'%'
                                  OR indole LIKE @Indo+'%'
                                  OR descripcion LIKE @Desc+'%'";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
            oCmd.Parameters.AddWithValue("@Indo", id);
            oCmd.Parameters.AddWithValue("@Desc", id);
            SqlDataReader oRead = ComunDB.EjecutarCmdRead(oCmd);
            List<Indoles> Lista = new List<Indoles>();
            while (oRead.Read())
            {
                Indoles oIndo = new Indoles();
                oIndo.id = oRead.GetInt32(0);
                oIndo.indole = oRead.GetString(1);
                oIndo.descripcion = oRead.GetString(2);
                oIndo.iddepo = oRead.GetInt32(3);
                Lista.Add(oIndo);
            }
            return Lista;
        }
        public static int Guardar(Indoles indModel)
        {
            int result = 0;
            string sSQL = @"INSERT INTO indoles(indole,descripcion,iddepo)
                                         VALUES(@Indo, @Desc,     @Iddep)";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Indo", indModel.indole);
            oCmd.Parameters.AddWithValue("@Desc", indModel.descripcion);
            oCmd.Parameters.AddWithValue("@Iddep", indModel.iddepo);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static int Editar(Indoles indModel)
        {
            int result = 0;
            string sSQL = @"UPDATE Indoles SET
                                    Indole  =   @Indo,
                                    Descripcion=@Desc,
                                    iddepo  =   @Iddep
                               WHERE id     =   @id";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@id",     indModel.id);
            oCmd.Parameters.AddWithValue("@Indo",   indModel.indole);
            oCmd.Parameters.AddWithValue("@Desc",   indModel.descripcion);
            oCmd.Parameters.AddWithValue("@Iddep",  indModel.iddepo);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static int Eliminar(string id)
        {
            int result = 0;
            string sSQL = @"DELETE FROM Indoles
                            WHERE id = @id";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@id", id);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
    }
}
