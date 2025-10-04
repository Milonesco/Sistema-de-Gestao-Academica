namespace TransformeseApp2.Desktop
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            AbrirUserControl(new ucHome());
        }

        private void AbrirUserControl(UserControl uc)
        {
            // Limpa o que tiver no painel
            panelConteudo.Controls.Clear();

            uc.Dock = DockStyle.Fill; // Faz o UserControl preencher o painel

            panelConteudo.Controls.Add(uc); // Adiciona o UserControl ao painel



        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new ucHome());
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            FecharMain();
        }

        private void FecharMain()
        {
            Close();
            frmLogin telaLogin = new();
            telaLogin.ShowDialog();
        }
    }
}
