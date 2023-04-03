using System.Collections.Generic;
using ProdLab.AccesoDatos.DAL;
using ProdLab.EntidadesdeNegocio;

namespace ProdLab.LogicadeNegocio.BL
{
    public class OrdempBL
    {
        public static int Guardar(Ordemp prodModel)
        {
            int result = 0;
            result = OrdempDAL.Guardar(prodModel);
            return result;
        }
        public static int Editar(Ordemp prodModel)
        {
            int result = 0;
            result = OrdempDAL.Editar(prodModel);
            return result;
        }
        public static int Eliminar(string id)
        {
            int result = 0;
            result = OrdempDAL.Eliminar(id);
            return result;
        }
        public static List<Ordemp> ObtenerTodos()
        {
            List<Ordemp> Lista = new List<Ordemp>();
            Lista = OrdempDAL.ObtenerTodos();
            return Lista;
        }
        public static List<Ordemp> ObtenerById(string id)
        {
            List<Ordemp> oProd = new List<Ordemp>();
            oProd = OrdempDAL.ObtenerById(id);
            return oProd;
        }
    }
}
