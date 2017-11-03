using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edu.Uninpahu.Arquitectura.Domini;
using System.Windows.Forms;

namespace Edu.Uninpahu.Arquitectura.Datos
{
    public class EmpleadoDB
    {
        Conexion con = new Conexion();

        public String agregar(Empleado empleado)
        {
            con.Conectar();
            
                String sql = String.Format("INSERT INTO [dbo].[Empleados]" +
                    " ([ident_EPk]," +
                    " [nombre_E]," +
                    " [apellido_E]," +
                    " [direccion]," +
                    " [cargo], " +
                    " [fijo]," +
                    " [celular])" +
                    "VALUES ({0} " +
                    ",'{1}' " +
                    ",'{2}' " +
                    ",'{3}' " +
                    ",'{4}'" +
                    ",{5}" +
                    ",{6} )",
                empleado.Id, empleado.Nombre, empleado.Apellido,
                empleado.Direcccion, empleado.Cargo, empleado.Fijo, empleado.Celular);
                con.EjecutarQuery(sql);
            String mensaje = con.GetMessage();
            return mensaje;
        }

        public String Modificar(Empleado empleado)
        {
            con.Conectar();
            
                String sql = String.Format("UPDATE [dbo].[Empleados]" +
                    " SET [nombre_E] = {0}, " +
                    " [apellido_E] = '{1}'," +
                    " [direccion] = '{2}'," +
                    " [cargo] = '{3}'" +
                    " [fijo] = '{4}', " +
                    " [celular] = {5} " +
                    " WHERE [ident_EPk] = {6} ",
                empleado.Nombre, empleado.Apellido, empleado.Direcccion,
                empleado.Cargo, empleado.Fijo, empleado.Celular,empleado.Id);
                con.EjecutarQuery(sql);
            
            String mensaje = con.GetMessage();
            return mensaje;
        }

        public bool BuscarEmpleadoPorId(int idEmp)
        {
            bool mensaje = false;
            con.Conectar();
            String sql = String.Format("SELECT * FROM Empleados e " +
                "WHERE e.ident_EPk = {0}", idEmp);
            mensaje = con.BuscarPorId(sql);
            con.CerrarConexion();
            return mensaje;
        }


        public void ConsultaListaEmpleado(DataGridView dgv)
        {
            string sql = "SELECT TOP 50 [ident_EPk]," +
                    " [nombre_E]," +
                    " [apellido_E]," +
                    " [direccion]," +
                    " [cargo], " +
                    " [fijo]," +
                    " [celular] " +
                    "FROM [Facturacion].[dbo].[Empleados] ";
            con.ConsultaDataTable(dgv, sql);
        }
        
    }
}
