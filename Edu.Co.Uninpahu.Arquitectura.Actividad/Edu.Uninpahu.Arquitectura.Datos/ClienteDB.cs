using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Edu.Uninpahu.Arquitectura.Domini;
using System.Windows.Forms;

namespace Edu.Uninpahu.Arquitectura.Datos
{
     public class ClienteDB : Conexion
    {
        Conexion con = new Conexion();
        public String agregar(Cliente cliente)
        {
            //if (
            con.Conectar();
                //)
            //{
                String sql = String.Format("Insert Into Cliente (ident_CPk,nombre_c," +
                "apellido_c,fijo,celular) VALUES ({0},'{1}','{2}','{3}','{4}')",
                cliente.Id, cliente.Nombre, cliente.Apellido, cliente.Fijo,
                cliente.Celular);
                con.EjecutarQuery(sql);
                con.CerrarConexion();
            //}
            String mensaje = con.GetMessage();
            //if (!con.CerrarConexion() || !con.Conectar())
            //{
            //    mensaje = con.GetMessage();
            //}
            return mensaje;
        }

        public String Modificar(Cliente cliente)
        {
            //if (
            con.Conectar();
            //    )
            //{
                String sql = String.Format("UPDATE [dbo].[Cliente] " +
                    " SET nombre_c = '{0}' " +
                    " ,apellido_c = '{1}' " +
                    " ,fijo = '{2}' " +
                    ",celular = '{3}' " +
                    "WHERE ident_CPk = {4} ",
                cliente.Nombre, cliente.Apellido, cliente.Fijo,
                cliente.Celular, cliente.Id);
                con.EjecutarQuery(sql);
                con.CerrarConexion();
            //}
            String mensaje = con.GetMessage();
            //if (!con.CerrarConexion() || !con.Conectar())
            //{
            //    mensaje = con.GetMessage();
            //}
            return mensaje;
        }

        //public Cliente BuscarClinetePorId(int id)
        //{
        //    String sql = String.Format("SELECT * FROM Cliente c " +
        //        "WHERE c.ident_CPk = {0}", id);
        //    Cliente cliente = (Cliente) con.BuscarPorId(sql);
        //    return cliente;
        //}

        public void ConsultaListaCliente(DataGridView dgv)
        {
            string sql = "SELECT TOP 50 [ident_CPk],[nombre_c],[apellido_c],[fijo]," +
                " [celular] FROM [Facturacion].[dbo].[Cliente] ";
            con.ConsultaDataTable(dgv, sql);
        }

        public bool BuscarClinetePorId(int id)
        {
            bool mensaje = false;
            //if (
            con.Conectar();
            //    )
            //{
                String sql = String.Format("SELECT * FROM Cliente c " +
                "WHERE c.ident_CPk = {0}", id);
                mensaje = con.BuscarPorId(sql);
                con.CerrarConexion();
            //}
            //    //String mensaje = con.GetMessage();
            //if (!con.CerrarConexion() || !con.Conectar())
            //{
            //    mensaje = false;
            //}
            return mensaje;
        }


        public List<Cliente> ObtenerCliente()
        {
            var dt = con.ConsultaData("SELECT * FROM Cliente c");

            List<Cliente> clientes = new List<Cliente>();
            if (dt != null)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    Cliente cliente = new Cliente();

                    cliente.Id = fila.Field<int>("ident_CPk");
                    cliente.Nombre = fila.Field<string>("nombre_c");
                    cliente.Apellido = fila.Field<string>("apellido_c");
                    cliente.Fijo = fila.Field<string>("fijo");
                    cliente.Celular = fila.Field<string>("celular");

                    clientes.Add(cliente);
                }
            }
            else
            {
                clientes.Add(new Cliente
                {
                    Id = 0,
                    Nombre = "No Hay Clientes",
                    Apellido = "",
                    Fijo = "",
                    Celular = "",
                });
            }
            return clientes;
        }
    }
}
