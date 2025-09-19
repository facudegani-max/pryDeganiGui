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

        public string[] Nombre = new string[3];
        int i = 0;

        private void Botonera_Load(object sender, EventArgs e)
        {
            Nombre[0] = "AlfonsoPro";
            Nombre[1] = "Bauti";
            Nombre[2] = "C#";

            lblNombres.Text = Nombre[i];

        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            if (i < Nombre.Length - 1) // Aseguramos que no estamos fuera de los límites
            {
                i++;
                lblNombres.Text = Nombre[i];
                ActualizarEstadoBotones();
            }
            

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (i > 0) // Aseguramos que no estamos fuera de los límites
            {
                i--;
                lblNombres.Text = Nombre[i];
                ActualizarEstadoBotones();
            }
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            i = Nombre.Length - 1; // Nos movemos al último índice
            lblNombres.Text = Nombre[i];
            ActualizarEstadoBotones();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            i = 0; // Nos movemos al primer índice
            lblNombres.Text = Nombre[i];
            ActualizarEstadoBotones();

        }

        private void ActualizarEstadoBotones()
        {
            // Habilitar/deshabilitar botones según la posición actual
            btnAtras.Enabled = i > 0;
            btnPrimero.Enabled = i > 0;
            btnAdelante.Enabled = i < Nombre.Length - 1;
            btnUltimo.Enabled = i < Nombre.Length - 1;
        }

        private void lblBienvenido_Click(object sender, EventArgs e)
        {

        }
    }
}
