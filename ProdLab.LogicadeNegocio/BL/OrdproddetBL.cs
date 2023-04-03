using System.Collections.Generic;
using ProdLab.AccesoDatos.DAL;
using ProdLab.EntidadesdeNegocio;

namespace ProdLab.LogicadeNegocio.BL
{
    public class OrdproddetBL
    {
        public static int Guardar(Ordproddet ordModel)
        {
            int result = 0;
            result = OrdproddetDAL.Guardar(ordModel);
            return result;
        }
        public static int Editar(Ordproddet ordModel)
        {
            int result = 0;
            result = OrdproddetDAL.Editar(ordModel);
            return result;
        }
        public static int Eliminar(string id)
        {
            int result = 0;
            result = OrdproddetDAL.Eliminar(id);
            return result;
        }
        public static List<Ordproddet> ObtenerTodos()
        {
            List<Ordproddet> Lista = new List<Ordproddet>();
            Lista = OrdproddetDAL.ObtenerTodos();
            return Lista;
        }
        public static List<Ordproddet> ObtenerById(string id)
        {
            List<Ordproddet> oProd = new List<Ordproddet>();
            oProd = OrdproddetDAL.ObtenerById(id);
            return oProd;
        }
    }
}
