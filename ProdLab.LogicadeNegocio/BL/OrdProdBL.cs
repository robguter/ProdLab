using System.Collections.Generic;
using ProdLab.AccesoDatos.DAL;
using ProdLab.EntidadesdeNegocio;

namespace ProdLab.LogicadeNegocio.BL
{
    public class OrdProdBL
    {
        public static int Guardar(OrdProd prodModel)
        {
            int result = 0;
            result = OrdProdDAL.Guardar(prodModel);
            return result;
        }
        public static int Editar(OrdProd prodModel)
        {
            int result = 0;
            result = OrdProdDAL.Editar(prodModel);
            return result;
        }
        public static int Eliminar(string id)
        {
            int result = 0;
            result = OrdProdDAL.Eliminar(id);
            return result;
        }
        public static List<OrdProd> ObtenerTodos()
        {
            List<OrdProd> Lista = new List<OrdProd>();
            Lista = OrdProdDAL.ObtenerTodos();
            return Lista;
        }
        public static List<OrdProd> ObtenerById(string id)
        {
            List<OrdProd> oProd = new List<OrdProd>();
            oProd = OrdProdDAL.ObtenerById(id);
            return oProd;
        }
    }
}
