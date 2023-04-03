using System.Collections.Generic;
using ProdLab.AccesoDatos.DAL;
using ProdLab.EntidadesdeNegocio;

namespace ProdLab.LogicadeNegocio.BL
{
    public class OrdacoBL
    {
        public static int Guardar(Ordaco prodModel)
        {
            int result = 0;
            result = OrdacoDAL.Guardar(prodModel);
            return result;
        }
        public static int Editar(Ordaco prodModel)
        {
            int result = 0;
            result = OrdacoDAL.Editar(prodModel);
            return result;
        }
        public static int Eliminar(string id)
        {
            int result = 0;
            result = OrdacoDAL.Eliminar(id);
            return result;
        }
        public static List<Ordaco> ObtenerTodos()
        {
            List<Ordaco> Lista = new List<Ordaco>();
            Lista = OrdacoDAL.ObtenerTodos();
            return Lista;
        }
        public static List<Ordaco> ObtenerById(string id)
        {
            List<Ordaco> oProd = new List<Ordaco>();
            oProd = OrdacoDAL.ObtenerById(id);
            return oProd;
        }
    }
}
