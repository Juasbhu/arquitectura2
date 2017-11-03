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
    public partial class ListaEmpleado : Form
    {
        GestionEmpleado gestionEmpleado = new GestionEmpleado();
        GestionCliente gestionCliente = new GestionCliente();
        Validacion validar = new Validacion();
        Empleado empleado;
        int veces = 0;
        public ListaEmpleado()
        {
            InitializeComponent();
            tabla();
        }

        public void tabla()
        {
            gestionEmpleado.ConsultaListaEmpleado(EmpleadoDGV);
            EmpleadoDGV.Columns[0].HeaderText = "Identificación";
            EmpleadoDGV.Columns[1].HeaderText = "Nombre";
            EmpleadoDGV.Columns[2].HeaderText = "Apellido";
            EmpleadoDGV.Columns[3].HeaderText = "Cargo";
            EmpleadoDGV.Columns[4].HeaderText = "Telefono";
            EmpleadoDGV.Columns[5].HeaderText = "Celular";
            if (veces == 0) {
                EmpleadoDGV.Columns[0].Width = EmpleadoDGV.Width - 300;
                EmpleadoDGV.Columns[1].Width = EmpleadoDGV.Width - 300;
                EmpleadoDGV.Columns[2].Width = EmpleadoDGV.Width - 300;
                EmpleadoDGV.Columns[3].Width = EmpleadoDGV.Width - 300;
                EmpleadoDGV.Columns[4].Width = EmpleadoDGV.Width - 300;
                EmpleadoDGV.Columns[5].Width = EmpleadoDGV.Width - 300;
                veces++;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TxbCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void EmpleadoDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public bool validacion()
        {
            if (validar.espaciosVaciosBlanco(TxbId.Text) == false ||
                validar.espaciosVaciosBlanco(TxbNombre.Text) == false ||
                validar.espaciosVaciosBlanco(TxbApellido.Text) == false ||
                validar.espaciosVaciosBlanco(TbxDireccion.Text) == false ||
                validar.espaciosVaciosBlanco(CargoTbx.Text) == false ||
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
                MessageBox.Show("Hay datos vacios");
            }
            else
            {
                if (gestionEmpleado.BuscarPorId(int.Parse(TxbId.Text)) == true
                    && gestionCliente.BuscarPorId(int.Parse(TxbId.Text)) == true)
                {
                    empleado = new Empleado(int.Parse(TxbId.Text), TxbNombre.Text,
                    TxbApellido.Text, TbxDireccion.Text, CargoTbx.Text,
                    TxbFijo.Text, TxbCelular.Text);
                    String result = gestionEmpleado.modificarEmpleado(empleado);
                    MessageBox.Show(result);
                    BtnLimpiar_Click(sender, e);
                    tabla();
                }
                else {
                    MessageBox.Show("El Empleado que busca actualizar no existe");
                }
                    
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxbId.Clear();
            TxbNombre.Clear();
            TxbApellido.Clear();
            TbxDireccion.Clear();
            CargoTbx.Clear();
            TxbCelular.Clear();
            TxbFijo.Clear();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            PaginaInicio pn = new PaginaInicio();
            pn.Show();
            this.Hide();
        }

        private void TxbId_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validar.soloNumeros(e.KeyChar);
        }

        private void TxbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validar.soloLetras(e.KeyChar);
        }

        private void TxbApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validar.soloLetras(e.KeyChar);
        }

        private void TbxDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void CargoTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validar.soloLetras(e.KeyChar);
        }

        private void TxbFijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validar.soloNumeros(e.KeyChar);
        }

        private void TxbCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validar.soloNumeros(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validacion() == false)
            {
                MessageBox.Show("Hay datos vacios");
            }
            else
            {
                if (gestionEmpleado.BuscarPorId(int.Parse(TxbId.Text)) == false
                    && gestionCliente.BuscarPorId(int.Parse(TxbId.Text)) == false)
                {
                    empleado = new Empleado(int.Parse(TxbId.Text), TxbNombre.Text,
                    TxbApellido.Text, TbxDireccion.Text, CargoTbx.Text,
                    TxbFijo.Text, TxbCelular.Text);
                    String result = gestionEmpleado.agregarEmpleado(empleado);
                    MessageBox.Show(result);
                    BtnLimpiar_Click(sender, e);
                    tabla();
                }
                else
                {
                    MessageBox.Show("El Empleado que intenta Crear ya existe");
                }

            }
        }

        private void TxbId_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void EmpleadoDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxbId.Text = EmpleadoDGV.Rows[e.RowIndex].Cells["ident_EPk"].Value.ToString();
            TxbNombre.Text = EmpleadoDGV.Rows[e.RowIndex].Cells["nombre_E"].Value.ToString();
            TxbApellido.Text = EmpleadoDGV.Rows[e.RowIndex].Cells["apellido_E"].Value.ToString();
            TbxDireccion.Text = EmpleadoDGV.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
            CargoTbx.Text = EmpleadoDGV.Rows[e.RowIndex].Cells["cargo"].Value.ToString();
            TxbFijo.Text = EmpleadoDGV.Rows[e.RowIndex].Cells["fijo"].Value.ToString();
            TxbCelular.Text = EmpleadoDGV.Rows[e.RowIndex].Cells["celular"].Value.ToString();
            
        }
    }
}
