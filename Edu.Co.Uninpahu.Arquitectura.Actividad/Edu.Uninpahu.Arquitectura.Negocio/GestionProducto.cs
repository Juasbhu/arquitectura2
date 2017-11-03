using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edu.Uninpahu.Arquitectura.Datos;
using Edu.Uninpahu.Arquitectura.Domini;
using System.Windows.Forms;
using System.Data;

namespace Edu.Uninpahu.Arquitectura.Negocio
{
    public class GestionProducto
    {
        ProductoDB conexion = new ProductoDB();

        public string agregarProducto(Producto producto)
        {
            return conexion.agregar(producto);
        }

        public string modificarProducto(Producto producto)
        {
            return conexion.Modificar(producto);
        }

        public void ConsultaListaProducto(DataGridView dgv)
        {
            conexion.ConsultaListaProducto(dgv);
        }

        public bool BuscarProductoPorId(int codigo)
        {
            return conexion.BuscarProductoPorId(codigo);
        }

        public List<Producto> ConsultaProducto()
        {
            return conexion.ObtenerProductos();
        }

        public List<Producto> ConsultaListaProducto(string codigo)
        {
            return conexion.ObtenerUnProducto(codigo);
        }
    }
}
