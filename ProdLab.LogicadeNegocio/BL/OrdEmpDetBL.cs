using System.Collections.Generic;
using ProdLab.AccesoDatos.DAL;
using ProdLab.EntidadesdeNegocio;

namespace ProdLab.LogicadeNegocio.BL
{
    public class OrdEmpDetBL
    {
        public static int Guardar(OrdEmpDet prodModel)
        {
            int result = 0;
            result = OrdEmpDetDAL.Guardar(prodModel);
            return result;
        }
        public static int Editar(OrdEmpDet prodModel)
        {
            int result = 0;
            result = OrdEmpDetDAL.Editar(prodModel);
            return result;
        }
        public static int Eliminar(string id)
        {
            int result = 0;
            result = OrdEmpDetDAL.Eliminar(id);
            return result;
        }
        public static List<OrdEmpDet> ObtenerTodos()
        {
            List<OrdEmpDet> Lista = new List<OrdEmpDet>();
            Lista = OrdEmpDetDAL.ObtenerTodos();
            return Lista;
        }
        public static List<OrdEmpDet> ObtenerById(string id)
        {
            List<OrdEmpDet> oProd = new List<OrdEmpDet>();
            oProd = OrdEmpDetDAL.ObtenerById(id);
            return oProd;
        }
    }
}
