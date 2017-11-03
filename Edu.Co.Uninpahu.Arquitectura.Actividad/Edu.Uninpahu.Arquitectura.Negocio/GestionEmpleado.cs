using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edu.Uninpahu.Arquitectura.Datos;
using Edu.Uninpahu.Arquitectura.Domini;
using System.Windows.Forms;

namespace Edu.Uninpahu.Arquitectura.Negocio
{
    public class GestionEmpleado
    {
        EmpleadoDB conexion = new EmpleadoDB();

        public string agregarEmpleado(Empleado empleado)
        {
            return conexion.agregar(empleado);
        }

        public string modificarEmpleado(Empleado empleado)
        {
            return conexion.Modificar(empleado);
        }

        public void ConsultaListaEmpleado(DataGridView dgv)
        {
            conexion.ConsultaListaEmpleado(dgv);
        }

        public bool BuscarPorId(int cedula)
        {
            return conexion.BuscarEmpleadoPorId(cedula);
        }
        
    }
}
