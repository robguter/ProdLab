using System.Collections.Generic;
using ProdLab.AccesoDatos;
using ProdLab.EntidadesdeNegocio;

namespace ProdLab.LogicadeNegocio
{
    public class ProductoBL
    {
        public static int Guardar(Producto prodModel)
        {
            int result = 0;
            result = ProductoDAL.Guardar(prodModel);
            return result;
        }
        public static int Editar(Producto prodModel)
        {
            int result = 0;
            result = ProductoDAL.Editar(prodModel);
            return result;
        }
        public static int Eliminar(string id)
        {
            int result = 0;
            result = ProductoDAL.Eliminar(id);
            return result;
        }
        public static List<Producto> ObtenerTodos()
        {
            List<Producto> Lista = new List<Producto>();
            Lista = ProductoDAL.ObtenerTodos();
            return Lista;
        }
        public static List<Producto> ObtenerById(string id)
        {
            List<Producto> oProd = new List<Producto>();
            oProd = ProductoDAL.ObtenerById(id);
            return oProd;
        }
    }
}
