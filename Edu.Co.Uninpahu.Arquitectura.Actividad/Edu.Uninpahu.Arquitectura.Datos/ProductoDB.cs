using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edu.Uninpahu.Arquitectura.Domini;
using System.Windows.Forms;
using System.Data;

namespace Edu.Uninpahu.Arquitectura.Datos
{
    public class ProductoDB
    {
        Conexion con = new Conexion();
        
        public String agregar(Producto producto)
        {
            con.Conectar();
            
                String sql = String.Format("INSERT INTO [dbo].[Producto]"+
                "([codigo_Pk] " +
                ",[nombre_P] "+
                ",[cant_Disp] "+
                ",[valor_Unitario] "+
                ",[porcentaje_iva]) " +
                    "VALUES ({0} " +
                    ",'{1}' " +
                    ",{2} " +
                    ",{3} " +
                    ",{4} )",
                producto.Codigo, producto.Nombre, producto.CantidadDisponible, 
                producto.ValorUnitario ,producto.PorcentajeIva);
                con.EjecutarQuery(sql);
            
            String mensaje = con.GetMessage();
            return mensaje;
        }

        public String Modificar(Producto producto)
        {
            con.Conectar();
            
                String sql = String.Format("UPDATE [dbo].[Producto] SET " +
                      " [nombre_P] = '{0}'"+
                      " ,[cant_Disp] = {1}" +
                      " ,[valor_Unitario] = {2}" +
                      " ,[porcentaje_iva] = {3}" +
                 " WHERE [codigo_Pk] = {4} ",
                producto.Nombre, producto.CantidadDisponible, producto.ValorUnitario,
                producto.PorcentajeIva, producto.Codigo);
                con.EjecutarQuery(sql);
            
            String mensaje = con.GetMessage();
            return mensaje;
        }

        public bool BuscarProductoPorId(int codigo)
        {
            bool mensaje = false;
            con.Conectar();
            String sql = String.Format("SELECT * FROM Producto p " +
                "WHERE p.codigo_Pk = {0}", codigo);
            mensaje = con.BuscarPorId(sql);
            con.CerrarConexion();
            return mensaje;
        }

        public void ConsultaListaProducto(DataGridView dgv)
        {
            string sql = "SELECT TOP 50 [codigo_Pk]" +
                " ,[nombre_P]" +
                " ,[cant_Disp] " +
                " ,[valor_Unitario]" +
                " ,[porcentaje_iva]" +
                " FROM[dbo].[Producto]; ";
            con.ConsultaDataTable(dgv, sql);
        }

        public List<Producto> ObtenerProductos()
        {
            var dt = con.ConsultaData("SELECT * FROM Producto p");

            List<Producto> productos = new List<Producto>();
            if (dt != null)
            {
                foreach (DataRow fila in dt.Rows)
            {
                Producto producto = new Producto();

                producto.Codigo = fila.Field<int>("codigo_Pk");
                producto.Nombre = fila.Field<string>("nombre_P");
                producto.ValorUnitario = (float)(fila.Field<double>("valor_Unitario"));
                producto.PorcentajeIva = fila.Field<int>("porcentaje_iva");
                producto.CantidadDisponible = fila.Field<int>("cant_Disp");

                productos.Add(producto);
            }
        }
            else {
                productos.Add(new Producto {Codigo=0,Nombre= "No Hay Productos",
                    ValorUnitario =0,PorcentajeIva=0,CantidadDisponible=0 });
            }
            return productos;
        }


        public List<Producto> ObtenerUnProducto(string codigo)
        {
            var dt = con.ConsultaData("SELECT * FROM Producto p WHERE " +
                "p.codigo_Pk = "+codigo+";");

            List<Producto> productos = new List<Producto>();

            foreach (DataRow fila in dt.Rows)
            {
                Producto producto = new Producto();

                producto.Codigo = fila.Field<int>("codigo_Pk");
                producto.Nombre = fila.Field<string>("nombre_P");
                producto.ValorUnitario = (float)(fila.Field<double>("valor_Unitario"));
                producto.PorcentajeIva = fila.Field<int>("porcentaje_iva");
                producto.CantidadDisponible = fila.Field<int>("cant_Disp");

                productos.Add(producto);
            }

            return productos;
        }
    }
}
