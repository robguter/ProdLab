using System.Collections.Generic;
using ProdLab.AccesoDatos.DAL;
using ProdLab.EntidadesdeNegocio;

namespace ProdLab.LogicadeNegocio.BL
{
    public class MaestrodetBL
    {
        public static int Guardar(Maestrodet prodModel)
        {
            int result = 0;
            result = MaestrodetDAL.Guardar(prodModel);
            return result;
        }
        public static int Editar(Maestrodet prodModel)
        {
            int result = 0;
            result = MaestrodetDAL.Editar(prodModel);
            return result;
        }
        public static int Eliminar(string id)
        {
            int result = 0;
            result = MaestrodetDAL.Eliminar(id);
            return result;
        }
        public static List<Maestrodet> ObtenerTodos()
        {
            List<Maestrodet> Lista = new List<Maestrodet>();
            Lista = MaestrodetDAL.ObtenerTodos();
            return Lista;
        }
        public static List<Maestrodet> ObtenerById(string id)
        {
            List<Maestrodet> oProd = new List<Maestrodet>();
            oProd = MaestrodetDAL.ObtenerById(id);
            return oProd;
        }
    }
}

