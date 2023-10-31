namespace WinFormsApp1
{
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            frmArticulos formArticulo = new frmArticulos();
            formArticulo.Show();
        }

        private void btnTiposInventarios_Click(object sender, EventArgs e)
        {
            frmTiposInventarios formTipoInventario = new frmTiposInventarios();
            formTipoInventario.Show();
        }

        private void btnAlmacenes_Click(object sender, EventArgs e)
        {
            frmAlmacenes formAlmacen = new frmAlmacenes();
            formAlmacen.Show();
        }
    }
}