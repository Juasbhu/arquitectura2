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
    public partial class ProductoV : Form
    {
        public ProductoV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PaginaInicio inicio = new PaginaInicio();
            inicio.Show();
            this.Hide();
        }
    }
}
