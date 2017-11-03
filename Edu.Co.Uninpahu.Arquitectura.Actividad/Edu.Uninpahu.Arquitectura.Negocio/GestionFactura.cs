using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Edu.Uninpahu.Arquitectura.Datos;

namespace Edu.Uninpahu.Arquitectura.Negocio
{
    public class GestionFactura
    {
        FacturaDB conexion = new FacturaDB();
        public void ConsultaListaFactura(DataGridView dgv)
        {
            conexion.ConsultaListaFactura(dgv);
        }
    }
}
