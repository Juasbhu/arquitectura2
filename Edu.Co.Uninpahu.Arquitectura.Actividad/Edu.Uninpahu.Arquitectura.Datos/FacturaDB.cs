using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edu.Uninpahu.Arquitectura.Domini;
using System.Windows.Forms;

namespace Edu.Uninpahu.Arquitectura.Datos
{
    public class FacturaDB 
    {
        Conexion con = new Conexion();

        public String agregar(Factura factura)
        {
            if (con.Conectar())
            {
                String sql = String.Format("INSERT INTO [dbo].[Factura]" +
                   "([num_FacturaPk]" +
                   ",[ident_CFk]" +
                   ",[ident_EFk]" +
                   ",[fecha])" +
                    "VALUES ({0} " +
                    ",{1} " +
                    ",{2} " +
                    ",{3})",
                factura.Id, factura.IdClient, factura.IdEmpleado,factura.Fecha);
                con.EjecutarQuery(sql);
            }
            String mensaje = con.GetMessage();
            if (!con.CerrarConexion() || !con.Conectar())
            {
                mensaje = con.GetMessage();
            }
            return mensaje;
        }

        public String Modificar(Factura factura)
        {
            if (con.Conectar())
            {
                String sql = String.Format("UPDATE [dbo].[Factura]" +
                    " SET [fecha] = {3}" +
                    " WHERE [num_FacturaPk] = {0} " +
                    " AND [ident_CFk] = {1} " +
                    " AND [ident_EFk] = {2}",
                factura.Fecha, factura.Id, factura.IdClient,factura.IdEmpleado);
                con.EjecutarQuery(sql);
            }
            String mensaje = con.GetMessage();
            if (!con.CerrarConexion() || !con.Conectar())
            {
                mensaje = con.GetMessage();
            }
            return mensaje;
        }

        //public Factura BuscarFacturaPorId(int numFac, int idClient, int idEmple)
        //{
        //    String sql = String.Format("SELECT * FROM Factura f " +
        //        " WHERE f.num_FacturaPk = {0} " +
        //        " AND f.ident_CFk = {1} " +
        //        " AND f.ident_EFk = {2}", numFac, idClient, idEmple);
        //    Factura factura = (Factura)con.BuscarPorId(sql);
        //    return factura;
        //}

        public void ConsultaListaFactura(DataGridView dgv)
        {
            string sql = "SELECT TOP 50 [num_FacturaPk]" +
                " ,[ident_CFk] " +
                " ,[ident_EFk] " +
                " ,[fecha] " +
                " FROM[dbo].[Factura]; ";
            con.ConsultaDataTable(dgv, sql);
        }
    }
}
