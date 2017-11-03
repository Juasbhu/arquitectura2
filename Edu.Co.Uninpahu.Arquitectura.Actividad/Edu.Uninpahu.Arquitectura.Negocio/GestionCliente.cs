using Edu.Uninpahu.Arquitectura.Datos;
using Edu.Uninpahu.Arquitectura.Domini;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu.Uninpahu.Arquitectura.Negocio
{
    public class GestionCliente
    {
        ClienteDB conexion = new ClienteDB();

        public string agregarCliente(Cliente cliente) {
            return conexion.agregar(cliente);
        }

        public string modificarCliente(Cliente cliente)
        {
            return conexion.Modificar(cliente);
        }

        public void ConsultaListaCliente(DataGridView dgv)
        { 
            conexion.ConsultaListaCliente(dgv);
        }

        //public Cliente BuscarPorId(int cedula)
        //{
        //    return conexion.BuscarClinetePorId(cedula);
        //}

        public bool BuscarPorId(int cedula)
        {
            return conexion.BuscarClinetePorId(cedula);
        }

        public List<Cliente> ConsultaCliente()
        {
            return conexion.ObtenerCliente();
        }
    }
}
