using System.Collections.Generic;
using ProdLab.AccesoDatos;
using ProdLab.EntidadesdeNegocio;

namespace ProdLab.LogicadeNegocio
{
    public class IndolesBL
    {
        public static int Guardar(Indoles indModel)
        {
            int result = 0;
            result = IndolesDAL.Guardar(indModel);
            return result;
        }
        public static int Editar(Indoles indModel)
        {
            int result = 0;
            result = IndolesDAL.Editar(indModel);
            return result;
        }
        public static int Eliminar(string id)
        {
            int result = 0;
            result = IndolesDAL.Eliminar(id);
            return result;
        }
        public static List<Indoles> ObtenerById(string id)
        {
            List<Indoles> oProd = new List<Indoles>();
            oProd = IndolesDAL.ObtenerById(id);
            return oProd;
        }
        public static List<Indoles> ObtenerTodos()
        {
            List<Indoles> Lista = new List<Indoles>();
            Lista = IndolesDAL.ObtenerTodos();
            return Lista;
        }
    }
}
