using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDeganiGui
{
    public partial class Botonera : Form
    {
        public Botonera()
        {
            InitializeComponent();
        }

        string[] Nombre = new string[3];
        int i = 0;

        private void Botonera_Load(object sender, EventArgs e)
        {
            Nombre[0] = "Paula";
            Nombre[1] = "Juan";
            Nombre[2] = "Ana";

            lblNombres.Text = Nombre[i];
            
            i++;

        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {

            i++;
            if (i < 3)
            {
                lblNombres.Text = Nombre[i];
            }
            else
            {
                MessageBox.Show("No hay mas nombres para mostrar");
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {

            i--;
            if (i >= 0)
            {
                lblNombres.Text = Nombre[i];
            }
            else
            {
                MessageBox.Show("No hay mas nombres para mostrar");
            }

        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            lblNombres.Text = Nombre[i];
        }
    }
}
