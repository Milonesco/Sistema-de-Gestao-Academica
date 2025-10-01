using TransformeseApp2.BLL;

namespace TransformeseApp2.Desktop
{

    public partial class frmLogin : Form
    {
        private readonly UsuarioBLL usuarioBLL = new();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = usuarioBLL.Login(txtUsuario.Text, txtSenha.Text);

                MessageBox.Show($"Seja bem vinda(a) {txtUsuario.Text}!");
                frmPrincipal frmPrincipal = new frmPrincipal();
                frmPrincipal.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario frmCadastroUsuario = new frmCadastroUsuario();
            frmCadastroUsuario.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblEsqueciSenha_Click(object sender, EventArgs e)
        {
            frmEsqueciSenha frmEsqueciSenha = new frmEsqueciSenha();
            frmEsqueciSenha.Show();
        }

    }
}


