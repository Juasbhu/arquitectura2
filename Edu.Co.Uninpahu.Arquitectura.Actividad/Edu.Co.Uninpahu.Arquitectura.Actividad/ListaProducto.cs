using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Edu.Uninpahu.Arquitectura.Negocio;
using Edu.Uninpahu.Arquitectura.Domini;

namespace Edu.Co.Uninpahu.Arquitectura.Actividad
{
    public partial class ListaProducto : Form
    {
        GestionProducto gestionProducto = new GestionProducto();
        Validacion validar = new Validacion();
        Producto producto;
        int veces = 0;
        public ListaProducto()
        {
            InitializeComponent();
            tabla();
        }

        public void tabla()
        {
            gestionProducto.ConsultaListaProducto(ProductoDGV);
            ProductoDGV.Columns[0].HeaderText = "Código";
            ProductoDGV.Columns[1].HeaderText = "Nombre del Producto";
            ProductoDGV.Columns[2].HeaderText = "Cantidad Disponible";
            ProductoDGV.Columns[3].HeaderText = "Precio Unitario";
            ProductoDGV.Columns[3].HeaderText = "IVA";
            if (veces == 0)
            {
                ProductoDGV.Columns[0].Width = ProductoDGV.Width - 300;
                ProductoDGV.Columns[1].Width = ProductoDGV.Width - 300;
                ProductoDGV.Columns[2].Width = ProductoDGV.Width - 300;
                ProductoDGV.Columns[3].Width = ProductoDGV.Width - 300;
                ProductoDGV.Columns[4].Width = ProductoDGV.Width - 300;
                veces++;
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public bool validacion()
        {
            if (validar.espaciosVaciosBlanco(TxbCod.Text) == false ||
                validar.espaciosVaciosBlanco(TxbNombre.Text) == false ||
                validar.espaciosVaciosBlanco(TxbCantidad.Text) == false ||
                validar.espaciosVaciosBlanco(TxbValor.Text) == false ||
                validar.espaciosVaciosBlanco(TxbIva.Text) == false)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!validacion())
            {
                MessageBox.Show("Hay datos vacios");
            }
            else
            {
                if (gestionProducto.BuscarProductoPorId(int.Parse(TxbCod.Text)) == true)
                {
                    producto = new Producto(int.Parse(TxbCod.Text), TxbNombre.Text,
                    int.Parse(TxbCantidad.Text), float.Parse(TxbValor.Text), 
                    int.Parse(TxbIva.Text));
                String result = gestionProducto.modificarProducto(producto);
                MessageBox.Show(result);
                BtnLimpiar_Click(sender, e);
                tabla();
                }
                else
                {
                    MessageBox.Show("El Producto que desea Modificar ya existe");
                }
            }
        }

        private void ClienteDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxbCod.Clear();
            TxbNombre.Clear();
            TxbIva.Clear();
            TxbValor.Clear();
            TxbCantidad.Clear();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            PaginaInicio pn = new PaginaInicio();
            pn.Show();
            this.Hide();
        }

        private void TxbCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validar.soloNumeros(e.KeyChar);
        }

        private void TxbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validar.soloLetras(e.KeyChar);
        }

        private void TxbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validar.soloNumeros(e.KeyChar);
        }

        private void TxbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validar.soloNumeros(e.KeyChar);
        }

        private void TxbIva_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validar.soloNumeros(e.KeyChar);
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if (!validacion())
            {
                MessageBox.Show("Hay datos vacios");
            }
            else
            {
                if (gestionProducto.BuscarProductoPorId(int.Parse(TxbCod.Text)) == false)
                {
                    producto = new Producto(
                    int.Parse(TxbCod.Text), TxbNombre.Text,
                    int.Parse(TxbCantidad.Text), float.Parse(TxbValor.Text),
                    int.Parse(TxbIva.Text));
                    String result = gestionProducto.agregarProducto(producto);
                    MessageBox.Show(result);
                    BtnLimpiar_Click(sender, e);
                    tabla();
                }
                else
                {
                    MessageBox.Show("El Producto que desea Crear ya existe");
                }
            }
        }

        private void ProductoDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxbCod.Text = ProductoDGV.Rows[e.RowIndex].Cells["codigo_Pk"].Value.ToString();
            TxbNombre.Text = ProductoDGV.Rows[e.RowIndex].Cells["nombre_P"].Value.ToString();
            TxbCantidad.Text = ProductoDGV.Rows[e.RowIndex].Cells["cant_Disp"].Value.ToString();
            TxbValor.Text = ProductoDGV.Rows[e.RowIndex].Cells["valor_Unitario"].Value.ToString();
            TxbIva.Text = ProductoDGV.Rows[e.RowIndex].Cells["porcentaje_iva"].Value.ToString();
        }
    }
}
