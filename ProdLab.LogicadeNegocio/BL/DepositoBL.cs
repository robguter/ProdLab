using ProdLab.AccesoDatos.DAL;
using ProdLab.EntidadesdeNegocio;
using System.Collections.Generic;

namespace ProdLab.LogicadeNegocio.BL
{
    public class DepositoBL
    {
        public static int Guardar(Deposito indModel)
        {
            int result = 0;
            result = DepositoDAL.Guardar(indModel);
            return result;
        }
        public static int Editar(Deposito indModel)
        {
            int result = 0;
            result = DepositoDAL.Editar(indModel);
            return result;
        }
        public static int Eliminar(string id)
        {
            int result = 0;
            result = DepositoDAL.Eliminar(id);
            return result;
        }
        public static List<Deposito> ObtenerById(string id)
        {
            List<Deposito> oProd = new List<Deposito>();
            oProd = DepositoDAL.ObtenerById(id);
            return oProd;
        }
        public static List<Deposito> ObtenerTodos()
        {
            List<Deposito> Lista = new List<Deposito>();
            Lista = DepositoDAL.ObtenerTodos();
            return Lista;
        }
    }
}
