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
    public partial class Facturacion : Form
    {
        GestionProducto gestionProducto = new GestionProducto();
        GestionCliente gestionCliente = new GestionCliente();

        Validacion validar = new Validacion();
        int refresh = 0;
        public Facturacion()
        {
            InitializeComponent();
            var lista = gestionProducto.ConsultaProducto();
            int cont = 0;

            CBProducto.DataSource = lista;
            CBProducto.ValueMember = "Codigo";
            CBProducto.DisplayMember = "Nombre";


            var lista2 = gestionCliente.ConsultaCliente();

            CBCliente.DataSource = lista2;
            CBCliente.ValueMember = "Id";
            CBCliente.DisplayMember = "Nombre";
            tabla();
        }

        public void tabla()
        {
            DgvProductos.Columns.Add("Código","Codigo");
            DgvProductos.Columns.Add("Nombre", "Nombre");
            DgvProductos.Columns.Add("Cantidad", "Cantidad Disponible");
            DgvProductos.Columns.Add("Valor", "Valor Unitario");
            DgvProductos.Columns.Add("IVA", "IVA");
            ////DgvProductos.Columns[0].HeaderText = "Codigo";
            //DgvProductos.Columns[1].HeaderText = "Nombre";
            //DgvProductos.Columns[2].HeaderText = "Cantidad Disponible";
            //DgvProductos.Columns[3].HeaderText = "Valor Unitario";
            //DgvProductos.Columns[4].HeaderText = "IVA";
            if (refresh == 0)
            {
                DgvProductos.Columns[0].Width = DgvProductos.Width - 250;
                DgvProductos.Columns[1].Width = DgvProductos.Width - 250;
                DgvProductos.Columns[2].Width = DgvProductos.Width - 250;
                DgvProductos.Columns[3].Width = DgvProductos.Width - 250;
                DgvProductos.Columns[4].Width = DgvProductos.Width - 250;
                DgvProductos.Columns[0].ReadOnly = false;
                DgvProductos.Columns[1].ReadOnly = false;
                DgvProductos.Columns[3].ReadOnly = false;
                DgvProductos.Columns[4].ReadOnly = false;
                refresh++;
            }

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Facturacion fac = new Facturacion();
            fac.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CBCliente.Select(1, 1);
            CBProducto.Select(1, 1);
            TBTotal.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CBProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            object select = CBProducto.SelectedValue;
            var lista = gestionProducto.ConsultaListaProducto(select.ToString());
            
            if (lista != null && lista.Count != 0)
            {
                foreach (var item in lista)
                {
                    DgvProductos.Rows.Add(item.Codigo, item.Nombre,
                        item.CantidadDisponible, item.ValorUnitario,
                        item.PorcentajeIva);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CBProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //gestionProducto.ConsultaListaProducto(DgvProductos, CBProducto.ValueMember);
        }
    }
}
