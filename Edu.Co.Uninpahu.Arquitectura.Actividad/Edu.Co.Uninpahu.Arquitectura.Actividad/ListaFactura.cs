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
    public partial class ListaFactura : Form
    {
        public ListaFactura()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
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
