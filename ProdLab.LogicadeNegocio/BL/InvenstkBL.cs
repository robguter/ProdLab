using System.Collections.Generic;
using ProdLab.AccesoDatos.DAL;
using ProdLab.EntidadesdeNegocio;

namespace ProdLab.LogicadeNegocio.BL
{
    public class InvenstkBL
    {
        public static int Guardar(Invenstk prodModel)
        {
            int result = 0;
            result = InvenstkDAL.Guardar(prodModel);
            return result;
        }
        public static int Editar(Invenstk prodModel)
        {
            int result = 0;
            result = InvenstkDAL.Editar(prodModel);
            return result;
        }
        public static int Eliminar(string id)
        {
            int result = 0;
            result = InvenstkDAL.Eliminar(id);
            return result;
        }
        public static List<Invenstk> ObtenerTodos()
        {
            List<Invenstk> Lista = new List<Invenstk>();
            Lista = InvenstkDAL.ObtenerTodos();
            return Lista;
        }
        public static List<Invenstk> ObtenerById(string id)
        {
            List<Invenstk> oProd = new List<Invenstk>();
            oProd = InvenstkDAL.ObtenerById(id);
            return oProd;
        }
    }
}
