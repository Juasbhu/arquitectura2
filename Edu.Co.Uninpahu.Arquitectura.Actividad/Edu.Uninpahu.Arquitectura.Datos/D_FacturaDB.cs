using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edu.Uninpahu.Arquitectura.Domini;

namespace Edu.Uninpahu.Arquitectura.Datos
{
    public class D_FacturaDB : Conexion
    {
        Conexion con = new Conexion();

        public String agregar(D_Factura dFactura)
        {
            if (con.Conectar())
            {
                String sql = String.Format("INSERT INTO [dbo].[D_Factura]"+
                   "([num_D_FacturaPk] "+
                   ",[num_FacturaFk] "+
                   ",[codigo] "+
                   ",[cantidad] "+
                   ",[valor] "+
                   ",[subtotal])" +
                    "VALUES ({0} " +
                    ",{1} " +
                    ",{2} " +
                    ",{3} " +
                    ",{4}" +
                    ",{5} )",
                dFactura.NumDFactura, dFactura.NumFactura, dFactura.Codigo,
                dFactura.Cantidad, dFactura.Valor, dFactura.Subtotal);
                con.EjecutarQuery(sql);
            }
            String mensaje = con.GetMessage();
            if (!con.CerrarConexion() || !con.Conectar())
            {
                mensaje = con.GetMessage();
            }
            return mensaje;
        }

        public String Modificar(D_Factura dFactura)
        {
            if (con.Conectar())
            {
                String sql = String.Format("UPDATE [dbo].[D_Factura]"+
                   "SET [cantidad] = {0}"+
                      ",[valor] = {1}"+
                      ",[subtotal] = {2}"+
                    "WHERE [num_D_FacturaPk] = {3} AND [num_FacturaFk] = {4} " +
                    "AND [codigo] = {5}",
                dFactura.Cantidad, dFactura.Valor, dFactura.Subtotal,
                dFactura.NumDFactura, dFactura.NumFactura, dFactura.Codigo);
                con.EjecutarQuery(sql);
            }
            String mensaje = con.GetMessage();
            if (!con.CerrarConexion() || !con.Conectar())
            {
                mensaje = con.GetMessage();
            }
            return mensaje;
        }

        //public D_Factura BuscarDFacturaPorId(int numDFac, int numFac, int codigo)
        //{
        //    String sql = String.Format("SELECT * FROM D_Factura df " +
        //        "WHERE[num_D_FacturaPk] = {0} AND[num_FacturaFk] = {1} " +
        //        "AND [codigo] = {2}", numDFac,numFac,codigo);
        //    D_Factura  dfactura = (D_Factura)con.BuscarPorId(sql);
        //    return dfactura;
        //}
    }
}
