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
            this.Hide();
            Botonera gUI = new  Botonera();
            gUI.Show(); 
        }
    }
}
