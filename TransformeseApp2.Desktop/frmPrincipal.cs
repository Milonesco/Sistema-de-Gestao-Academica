namespace TransformeseApp2.Desktop
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmCursos telaCursos = new frmCursos();
            telaCursos.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmAlunos2 telaAlunos = new frmAlunos2();
            telaAlunos.ShowDialog();
        }

        private void pbUnidades_Click(object sender, EventArgs e)
        {
            frmUnidades telaUnidades = new frmUnidades();
            telaUnidades.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
