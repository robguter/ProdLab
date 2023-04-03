using System.Collections.Generic;
using System.Data.SqlClient;
using ProdLab.EntidadesdeNegocio;

namespace ProdLab.AccesoDatos
{
    public class ProductoDAL
    {
        public static int Guardar(Producto prodModel)
        {
            int result = 0;
            string sSQL = @"INSERT INTO producto(Codigo,Descripcion,Unimed,Indole,StkMax,StkMin,EmpaqueUnd,Status)
                                          VALUES(@Codig,@Descripcio,@Unime,@Indol,@StkMa,@StkMi,@EmpaqueUn,@Statu)";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Codig", prodModel.Codigo);
            oCmd.Parameters.AddWithValue("@Descripcio", prodModel.Descripcion);
            oCmd.Parameters.AddWithValue("@Unime", prodModel.Unimed);
            oCmd.Parameters.AddWithValue("@Indol", prodModel.Indole);
            oCmd.Parameters.AddWithValue("@StkMa", prodModel.StkMax);
            oCmd.Parameters.AddWithValue("@StkMi", prodModel.StkMin);
            oCmd.Parameters.AddWithValue("@EmpaqueUn", prodModel.EmpaqueUnd);
            oCmd.Parameters.AddWithValue("@Statu", prodModel.Status);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static int Editar(Producto prodModel)
        {
            int result = 0;
            string sSQL = @"UPDATE producto SET
                                    Descripcion=@Desc,
                                    Unimed  =   @Unim,
                                    Indole  =   @Indo,
                                    StkMax  =   @StkA,
                                    StkMin  =   @StkI,
                                    EmpaqueUnd= @Empa,
                                    Status  =   @Stat
                               WHERE Codigo =   @Codi";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Codi", prodModel.Codigo);
            oCmd.Parameters.AddWithValue("@Desc", prodModel.Descripcion);
            oCmd.Parameters.AddWithValue("@Unim", prodModel.Unimed);
            oCmd.Parameters.AddWithValue("@Indo", prodModel.Indole);
            oCmd.Parameters.AddWithValue("@StkA", prodModel.StkMax);
            oCmd.Parameters.AddWithValue("@StkI", prodModel.StkMin);
            oCmd.Parameters.AddWithValue("@Empa", prodModel.EmpaqueUnd);
            oCmd.Parameters.AddWithValue("@Stat", prodModel.Status);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static int Eliminar(string id)
        {
            int result = 0;
            string sSQL = @"DELETE FROM producto
                            WHERE Codigo = @Codi";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Codi", id);
            result = ComunDB.EjecutarCmd(oCmd);
            return result;
        }
        public static List<Producto> ObtenerTodos()
        {
            string sSQL = @"SELECT Codigo,Descripcion,Unimed,Indole,StkMax,StkMin,EmpaqueUnd,Status
                            FROM producto
                            ORDER BY Codigo";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            SqlDataReader oRead = ComunDB.EjecutarCmdRead(oCmd);
            List<Producto> Lista = new List<Producto>();
            while (oRead.Read())
            {
                Producto oProd = new Producto();
                oProd.Codigo = oRead.GetString(0);
                oProd.Descripcion = oRead.GetString(1);
                oProd.Unimed = oRead.GetString(2);
                oProd.Indole = oRead.GetString(3);
                oProd.StkMax = (float)oRead.GetDecimal(4);
                oProd.StkMin = (float)oRead.GetDecimal(5);
                oProd.EmpaqueUnd = (float)oRead.GetDecimal(6);
                oProd.Status = oRead.GetString(7);
                Lista.Add(oProd);
            }
            return Lista;
        }
        public static List<Producto> ObtenerById(string id)
        {
            string sSQL = @"SELECT Codigo,Descripcion,Unimed,Indole,
                                   StkMax,StkMin,EmpaqueUnd,Status
                            FROM producto
                            WHERE Codigo LIKE @Codi+'%'
                                  OR Descripcion LIKE @Desc+'%'
                                  OR Unimed LIKE @Unim+'%'
                                  OR Indole LIKE @Indo+'%'";
            SqlCommand oCmd = ComunDB.ObtenerCmd();
            oCmd.CommandText = sSQL;
            oCmd.Parameters.AddWithValue("@Codi", id);
            oCmd.Parameters.AddWithValue("@Desc", id);
            oCmd.Parameters.AddWithValue("@Unim", id);
            oCmd.Parameters.AddWithValue("@Indo", id);
            SqlDataReader oRead = ComunDB.EjecutarCmdRead(oCmd);
            List<Producto> Lista = new List<Producto>();
            while (oRead.Read())
            {
                Producto oProd = new Producto();
                oProd.Codigo = oRead.GetString(0);
                oProd.Descripcion = oRead.GetString(1);
                oProd.Unimed = oRead.GetString(2);
                oProd.Indole = oRead.GetString(3);
                oProd.StkMax = (float)oRead.GetDecimal(4);
                oProd.StkMin = (float)oRead.GetDecimal(5);
                oProd.EmpaqueUnd = (float)oRead.GetDecimal(6);
                oProd.Status = oRead.GetString(7);
                Lista.Add(oProd);
            }
            return Lista;
        }
    }
}
