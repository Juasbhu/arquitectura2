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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIng_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void gBLogin_Resize(object sender, EventArgs e)
        {
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            
        }

        private void gBLogin_Enter(object sender, EventArgs e)
        {
            //gBLogin.Width = this.Width - 1000;
            //gBLogin.Height = this.Height - 500;
            //gBLogin.Left = this.Width - 800;
            //gBLogin.Top = this.Height - 500;


        }

        private void buttonIng_Click_1(object sender, EventArgs e)
        {
            Dictionary<String, String> usuarios = new Dictionary<string, string>();
            usuarios.Add("JHONALEX", "123");
            usuarios.Add("JUANGA", "123");
            usuarios.Add("ROSAT", "123");
            var bandera = 0;
            var bandera2 = 0;
            for (var i = 0; i <= 3; i++)
            {

            }
            foreach (KeyValuePair<string, string> usu in usuarios)
            {
                if (!usu.Key.Equals(this.textBoxUsu.Text))
                {
                    bandera += 1;
                    //break;
                }
                else
                {
                    if (usu.Value.Equals(this.textBoxPass.Text))
                    {
                        if (this.textBoxUsu.Text == "ROSAT")
                        {
                            Facturacion fac = new Facturacion();
                            fac.Show();
                            this.Hide();
                        }
                        else {
                            PaginaInicio inicio = new PaginaInicio();
                            inicio.Show();
                            this.Hide();
                        }
                        //break;
                    }
                    else
                    {
                        bandera2 = 1;
                        //break;
                    }

                }
            }
            if (bandera == usuarios.Count)
            {
                MessageBox.Show("EL USUARIO ES INCORRECTO");
            }
            if (bandera2 == 1)
            {
                MessageBox.Show("LA CONTRASEÑA ES INCORRECTA");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxUsu_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsu_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxUsu.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
