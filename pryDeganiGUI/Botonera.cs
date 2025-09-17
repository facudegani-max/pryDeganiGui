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

            if (Nombre.Length > i)
            {
                lblNombres.Text = Nombre[i];

                if (i > 0)
                {
                    btnAtras.Enabled = true;   
                }
                if ((i + 1) == Nombre.Length) 
                {
                    btnAdelante.Enabled = false;
                }
                if (i >= 2)
                {
                    btnUltimo.Enabled = false;
                }
            }

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {

            i--;

            if (Nombre.Length > i)
            {
                lblNombres.Text = Nombre[i];

                if (i == 0)
                {
                    btnAtras.Enabled = false;
                   
                }
                if (i > 0)
                {
                    btnAdelante.Enabled = true;
                    btnUltimo.Enabled = true;

                }
            }
 

        }

        private void lbl1_Click(object sender, EventArgs e)
        {
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            lblNombres.Text = Nombre[3-1];

            if (i > 0)
            {
                btnAtras.Enabled = true;
            }
            if ((i + 1) == Nombre.Length)
            {
                btnAdelante.Enabled = false;
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            lblNombres.Text = Nombre[0];

            if (i == 0)
            {
                btnAtras.Enabled = false;
            }
            if (i > 0)
            {
                btnAdelante.Enabled = true;
            }
        }

        private void lblBienvenido_Click(object sender, EventArgs e)
        {

        }
    }
}
