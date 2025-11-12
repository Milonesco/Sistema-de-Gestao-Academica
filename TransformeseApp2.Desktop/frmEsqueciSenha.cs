using TransformeseApp2.DAL;

namespace TransformeseApp2.Desktop
{
    public partial class frmEsqueciSenha : Form
    {
        public frmEsqueciSenha()
        {
            InitializeComponent();
            ConfigurarEventos();
        }

        private void ConfigurarEventos()
        {
            txtNovaSenha.TextChanged += AtualizarForcaSenha;
            txtNovaSenha2.TextChanged += ValidarConfirmacaoSenha;
            txtNovaSenha.IconRightClick += MostrarOcultarSenha;
            txtNovaSenha2.IconRightClick += MostrarOcultarSenha;
        }

        private void txtNovaSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private bool senhaVisivel = false;

        private void MostrarOcultarSenha(object sender, EventArgs e)
        {
            senhaVisivel = !senhaVisivel;

            if (senhaVisivel)
            {
                txtNovaSenha.PasswordChar = '\0';
                txtNovaSenha2.PasswordChar = '\0';
                txtNovaSenha.IconRight = Properties.Resources.eye_open;
                txtNovaSenha2.IconRight = Properties.Resources.eye_open;
            }
            else
            {
                txtNovaSenha.PasswordChar = '●';
                txtNovaSenha2.PasswordChar = '●';
                txtNovaSenha.IconRight = Properties.Resources.eye_closed;
                txtNovaSenha2.IconRight = Properties.Resources.eye_closed;
            }
        }

        private void AtualizarForcaSenha(object sender, EventArgs e)
        {
            string senha = txtNovaSenha.Text;
            int forca = CalcularForcaSenha(senha);
            string mensagemTooltip = "";

            pgbNovaSenha.Value = forca;

            if (forca < 30)
            {
                pgbNovaSenha.ProgressColor = Color.Red;
                mensagemTooltip = "Senha Fraca\nAdicione mais caracteres, números e ou símbolos especiais";
            }
            else if (forca < 70)
            {
                pgbNovaSenha.ProgressColor = Color.Orange;
                mensagemTooltip = "Senha Média\nTente adicionar mais números e ou símbolos especiais";
            }
            else
            {
                pgbNovaSenha.ProgressColor = Color.Green;
                mensagemTooltip = "Senha Forte\nBoa senha!";
            }

            ttpForcaSenha.SetToolTip(txtNovaSenha, mensagemTooltip);
            ttpForcaSenha.SetToolTip(pgbNovaSenha, mensagemTooltip);
            ValidarConfirmacaoSenha(txtNovaSenha2, EventArgs.Empty);
        }

        private int CalcularForcaSenha(string senha)
        {
            if (string.IsNullOrEmpty(senha)) return 0;

            int pontos = 0;

            // Comprimento (máximo 30 pontos)
            pontos += Math.Min(senha.Length * 3, 30);

            // Letras maiúsculas (20 pontos)
            if (senha.Any(char.IsUpper)) pontos += 20;

            // Letras minúsculas (20 pontos)
            if (senha.Any(char.IsLower)) pontos += 20;

            // Números (20 pontos)
            if (senha.Any(char.IsDigit)) pontos += 20;

            // Caracteres especiais (10 pontos)
            if (senha.Any(c => !char.IsLetterOrDigit(c))) pontos += 10;

            return Math.Min(pontos, 100);
        }

        private void ValidarConfirmacaoSenha(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNovaSenha2.Text))
            {
                txtNovaSenha2.BorderColor = Color.Gray;
                return;
            }

            if (txtNovaSenha2.Text == txtNovaSenha2.Text)
            {
                txtNovaSenha2.BorderColor = Color.Green;
            }
            else
            {
                txtNovaSenha2.BorderColor = Color.Red;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) ||
                string.IsNullOrWhiteSpace(txtNovaSenha.Text) ||
                string.IsNullOrWhiteSpace(txtNovaSenha2.Text))
            {
                MessageBox.Show("Preencha todos os campos.", "Atenção",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNovaSenha.Text != txtNovaSenha2.Text)
            {
                MessageBox.Show("As senhas não coincidem.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CalcularForcaSenha(txtNovaSenha.Text) < 70)
            {
                MessageBox.Show("A senha precisa ser forte. Adicione letras maiúsculas, minúsculas, números e símbolos.", "Atenção",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string login = txtLogin.Text.Trim();
            string novaSenha = txtNovaSenha.Text;

            var usuario = Database.Usuarios.FirstOrDefault(u => u.Usuario.Equals(login, StringComparison.OrdinalIgnoreCase));

            if (usuario == null)
            {
                MessageBox.Show("Usuário não encontrado.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (usuario.Senha == novaSenha)
            {
                MessageBox.Show("A nova senha não pode ser igual à senha anterior.", "Atenção",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (novaSenha.Length < 8)
            {
                MessageBox.Show("A senha deve ter pelo menos 8 caracteres.", "Atenção",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            usuario.Senha = novaSenha;

            MessageBox.Show("Senha alterada com sucesso!", "Sucesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
