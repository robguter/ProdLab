using System.Collections.Generic;
using ProdLab.AccesoDatos.DAL;
using ProdLab.EntidadesdeNegocio;

namespace ProdLab.LogicadeNegocio.BL
{
    public class MaestroBL
    {
        public static int Guardar(Maestro prodModel)
        {
            int result = 0;
            result = MaestroDAL.Guardar(prodModel);
            return result;
        }
        public static int Editar(Maestro prodModel)
        {
            int result = 0;
            result = MaestroDAL.Editar(prodModel);
            return result;
        }
        public static int Eliminar(string id)
        {
            int result = 0;
            result = MaestroDAL.Eliminar(id);
            return result;
        }
        public static List<Maestro> ObtenerTodos()
        {
            List<Maestro> Lista = new List<Maestro>();
            Lista = MaestroDAL.ObtenerTodos();
            return Lista;
        }
        public static List<Maestro> ObtenerById(string id)
        {
            List<Maestro> oProd = new List<Maestro>();
            oProd = MaestroDAL.ObtenerById(id);
            return oProd;
        }
    }
}
