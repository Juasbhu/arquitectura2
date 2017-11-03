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
    public partial class PaginaInicio : Form
    {
        public PaginaInicio()
        {
            InitializeComponent();
        }
        
        private void labelBienvenido_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaClientes listaCliente = new ListaClientes();
            listaCliente.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductoV producto = new ProductoV();
            producto.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor();
            vendedor.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteV cliente = new ClienteV();
            cliente.Show();
            this.Hide();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaClientes listaCliente = new ListaClientes();
            listaCliente.Show();
            this.Hide();
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListaProducto listaProducto = new ListaProducto();
            listaProducto.Show();
            this.Hide();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaEmpleado listaEmpleado = new ListaEmpleado();
            listaEmpleado.Show();
            this.Hide();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListaVenta lv = new ListaVenta();
            lv.Show();
            this.Hide();
        }
    }
}
