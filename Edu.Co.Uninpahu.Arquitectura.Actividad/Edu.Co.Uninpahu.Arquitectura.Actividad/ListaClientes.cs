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
    public partial class ListaClientes : Form
    {
        Cliente cliente;
        GestionEmpleado gestionEmpleado = new GestionEmpleado();
        GestionCliente gestionCliente = new GestionCliente();
        Validacion validar = new Validacion();
        int refresh = 0;
        public ListaClientes()
        {
            InitializeComponent();
            tabla();
        }

        public void tabla()
        {
            gestionCliente.ConsultaListaCliente(ClienteDGV);
            ClienteDGV.Columns[0].HeaderText = "IDENTIFICACIÓN";
            ClienteDGV.Columns[1].HeaderText = "NOMBRE";
            ClienteDGV.Columns[2].HeaderText = "APELLIDO";
            ClienteDGV.Columns[3].HeaderText = "TELEFONO";
            ClienteDGV.Columns[4].HeaderText = "CELULAR";
            if (refresh == 0)
            {
                ClienteDGV.Columns[0].Width = ClienteDGV.Width - 300;
                ClienteDGV.Columns[1].Width = ClienteDGV.Width - 300;
                ClienteDGV.Columns[2].Width = ClienteDGV.Width - 300;
                ClienteDGV.Columns[3].Width = ClienteDGV.Width - 300;
                ClienteDGV.Columns[4].Width = ClienteDGV.Width - 300;
                refresh = 1;
            }
            
        }

        private void ClienteDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gestionCliente.ConsultaListaCliente(ClienteDGV);
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            ClienteV cliente = new ClienteV();
            cliente.Show();
            this.Hide();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            PaginaInicio inicio = new PaginaInicio();
            inicio.Show();
            this.Hide();
        }

        private void ClienteDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            TxbId.Text = ClienteDGV.Rows[e.RowIndex].Cells["ident_CPk"].Value.ToString();
            TxbNombre.Text = ClienteDGV.Rows[e.RowIndex].Cells["nombre_c"].Value.ToString();
            TxbApellido.Text = ClienteDGV.Rows[e.RowIndex].Cells["apellido_c"].Value.ToString();
            TxbFijo.Text = ClienteDGV.Rows[e.RowIndex].Cells["fijo"].Value.ToString();
            TxbCelular.Text = ClienteDGV.Rows[e.RowIndex].Cells["celular"].Value.ToString();
        }

        private void ClienteDGV_RowContentClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        public bool validacion()
        {
            if (validar.espaciosVaciosBlanco(TxbId.Text) == false ||
                validar.espaciosVaciosBlanco(TxbNombre.Text) == false ||
                validar.espaciosVaciosBlanco(TxbApellido.Text) == false ||
                validar.espaciosVaciosBlanco(TxbFijo.Text) == false ||
                validar.espaciosVaciosBlanco(TxbCelular.Text) == false)
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
            if (validacion() == false)
            {
                MessageBox.Show("HAY DATOS VACIOS");
            }
            else
            {
                if (gestionEmpleado.BuscarPorId(int.Parse(TxbId.Text)) == true 
                    && gestionCliente.BuscarPorId(int.Parse(TxbId.Text)) == true)
                {
                    cliente = new Cliente(
                    int.Parse(TxbId.Text), TxbNombre.Text, TxbApellido.Text,
                    TxbFijo.Text, TxbCelular.Text);
                    String result = gestionCliente.modificarCliente(cliente);
                    MessageBox.Show(result);
                    BtnLimpiar_Click(sender, e);
                    tabla();
                }
                else
                {
                    MessageBox.Show("EL CLIENTE QUE BUSCA ACTUALIZAR NO EXISTE");
                }

            }

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxbId.Clear();
            TxbNombre.Clear();
            TxbApellido.Clear();
            TxbCelular.Clear();
            TxbFijo.Clear();
        }

        private void TxbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validar.soloNumeros(e.KeyChar);
            TxbId.Text = TxbId.Text.ToUpper();
        }

        private void TxbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validar.soloLetras(e.KeyChar);
            TxbNombre.CharacterCasing = CharacterCasing.Upper;
        }

        private void TxbApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validar.soloLetras(e.KeyChar);
            TxbApellido.CharacterCasing = CharacterCasing.Upper;
        }

        private void TxbFijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validar.soloNumeros(e.KeyChar);
            TxbFijo.CharacterCasing = CharacterCasing.Upper;
        }

        private void TxbCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validar.soloNumeros(e.KeyChar);
            TxbCelular.CharacterCasing = CharacterCasing.Upper;
        }

        private void BtnVolver_Click_1(object sender, EventArgs e)
        {
            PaginaInicio pagina = new PaginaInicio();
            pagina.Show();
            this.Hide();
        }

        private void BtnCrear_Click_1(object sender, EventArgs e)
        {
            ClienteV cliente = new ClienteV();
            cliente.Show();
            this.Hide();
        }

        private void TxbId_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void ClienteDGV_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnVolver_Click_2(object sender, EventArgs e)
        {
            PaginaInicio pn = new PaginaInicio();
            pn.Show();
            this.Hide();
        }

        private void BtnCrear_Click_2(object sender, EventArgs e)
        {
            if (validacion() == false)
            {
                MessageBox.Show("HAY DATOS VACIOS");
            }
            else
            {
                if (gestionEmpleado.BuscarPorId(int.Parse(TxbId.Text)) == false 
                    && gestionCliente.BuscarPorId(int.Parse(TxbId.Text)) == false)
                {
                    cliente = new Cliente(
                    int.Parse(TxbId.Text), TxbNombre.Text, TxbApellido.Text,
                    TxbFijo.Text, TxbCelular.Text);
                    String result = gestionCliente.agregarCliente(cliente);
                    MessageBox.Show(result);
                    BtnLimpiar_Click(sender, e);
                    tabla();
                }
                else
                {
                    MessageBox.Show("EL CLIENTE QUE DESEA CREAR YA EXISTE");
                }
            }
        }

        private void TxbId_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TxbId_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            
            
            
            
        }
    }
}
