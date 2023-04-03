using System.Collections.Generic;
using ProdLab.AccesoDatos.DAL;
using ProdLab.EntidadesdeNegocio;

namespace MovLab.LogicadeNegocio.BL
{
    public class MovinvBL
    {
        public static int Guardar(Movinv movModel)
        {
            int result = 0;
            result = MovinvDAL.Guardar(movModel);
            return result;
        }
        public static int Editar(Movinv movModel)
        {
            int result = 0;
            result = MovinvDAL.Editar(movModel);
            return result;
        }
        public static int Eliminar(string id)
        {
            int result = 0;
            result = MovinvDAL.Eliminar(id);
            return result;
        }
        public static List<Movinv> ObtenerTodos()
        {
            List<Movinv> Lista = new List<Movinv>();
            Lista = MovinvDAL.ObtenerTodos();
            return Lista;
        }
        public static List<Movinv> ObtenerById(string id)
        {
            List<Movinv> oMov = new List<Movinv>();
            oMov = MovinvDAL.ObtenerById(id);
            return oMov;
        }
    }
}
