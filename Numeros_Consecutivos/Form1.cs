using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_Consecutivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {

                e.Handled = false;
            }
            else
            {

                MessageBox.Show("Solo se pueden numeros"
                    , "Mensaje de advertencia"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);

                e.Handled = true;
                return;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(txtCantidad.Text);
            int contador = 0;
            int resta = 0;

            lsbConsecutivo.Items.Clear();

            while (contador <= cantidad)
            {

                if (contador <= cantidad)
                {

                    lsbConsecutivo.Items.Add(contador.ToString());

                }


                lblMensaje.Text = " Muestra Finalizada";
                lblMensaje.Visible = true;
                contador++;
                txtCantidad.Text = "";
                txtCantidad.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lsbConsecutivo.Items.Clear();
        }
    }
}
