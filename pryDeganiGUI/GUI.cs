namespace pryDeganiGui
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }

        private void btnBotonera_Click(object sender, EventArgs e)
        {
            
            Botonera gUI = new Botonera();
            //gUI.Nombre[0] = "Soy hacker xd";
            gUI.Show(); //visualiza formulario
            //this.Hide(); //oculta el formulario

            for (int i = 0; i < gUI.Nombre.Length; i++)
            {
                lstbox1.Items.Add(gUI.Nombre[i]);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
