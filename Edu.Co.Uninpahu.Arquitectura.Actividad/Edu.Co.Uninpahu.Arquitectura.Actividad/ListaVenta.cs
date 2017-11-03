using Edu.Uninpahu.Arquitectura.Domini;
using Edu.Uninpahu.Arquitectura.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu.Co.Uninpahu.Arquitectura.Actividad
{
    public partial class ListaVenta : Form
    {
         GestionFactura gestionFactura = new GestionFactura();
        Validacion validar = new Validacion();
        public ListaVenta()
        {
            InitializeComponent();
            tabla();
        }

        public void tabla()
        {
            gestionFactura.ConsultaListaFactura(VentaDGV);
            VentaDGV.Columns[0].HeaderText = "Numero de Factura";
            VentaDGV.Columns[1].HeaderText = "Comprador";
            VentaDGV.Columns[2].HeaderText = "Vendedor";
            VentaDGV.Columns[3].HeaderText = "Fecha";
            VentaDGV.Columns[0].Width = VentaDGV.Width - 300;
            VentaDGV.Columns[1].Width = VentaDGV.Width - 300;
            VentaDGV.Columns[2].Width = VentaDGV.Width - 300;
            VentaDGV.Columns[3].Width = VentaDGV.Width - 300;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            PaginaInicio pn = new PaginaInicio();
            pn.Show();
            this.Hide();
        }
    }
}
