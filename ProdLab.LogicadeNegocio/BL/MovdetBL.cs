using System.Collections.Generic;
using ProdLab.AccesoDatos.DAL;
using ProdLab.EntidadesdeNegocio;

namespace ProdLab.LogicadeNegocio.BL
{
    public class MovdetBL
    {
        public static int Guardar(Movdet movModel)
        {
            int result = 0;
            result = MovdetDAL.Guardar(movModel);
            return result;
        }
        public static int Editar(Movdet movModel)
        {
            int result = 0;
            result = MovdetDAL.Editar(movModel);
            return result;
        }
        public static int Eliminar(string id)
        {
            int result = 0;
            result = MovdetDAL.Eliminar(id);
            return result;
        }
        public static List<Movdet> ObtenerTodos()
        {
            List<Movdet> Lista = new List<Movdet>();
            Lista = MovdetDAL.ObtenerTodos();
            return Lista;
        }
        public static List<Movdet> ObtenerById(string id)
        {
            List<Movdet> oMov = new List<Movdet>();
            oMov = MovdetDAL.ObtenerById(id);
            return oMov;
        }
    }
}
