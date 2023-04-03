using System.Collections.Generic;
using ProdLab.AccesoDatos.DAL;
using ProdLab.EntidadesdeNegocio;

namespace ProdLab.LogicadeNegocio.BL
{
    public class OrdacodetBL
    {
        public static int Guardar(Ordacodet ordModel)
        {
            int result = 0;
            result = OrdacodetDAL.Guardar(ordModel);
            return result;
        }
        public static int Editar(Ordacodet ordModel)
        {
            int result = 0;
            result = OrdacodetDAL.Editar(ordModel);
            return result;
        }
        public static int Eliminar(string id)
        {
            int result = 0;
            result = OrdacodetDAL.Eliminar(id);
            return result;
        }
        public static List<Ordacodet> ObtenerTodos()
        {
            List<Ordacodet> Lista = new List<Ordacodet>();
            Lista = OrdacodetDAL.ObtenerTodos();
            return Lista;
        }
        public static List<Ordacodet> ObtenerById(string id)
        {
            List<Ordacodet> oProd = new List<Ordacodet>();
            oProd = OrdacodetDAL.ObtenerById(id);
            return oProd;
        }
    }
}
