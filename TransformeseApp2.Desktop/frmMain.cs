using TransformeseApp2.BLL;

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
            AtualizarUsuarioLogado();
            AbrirUserControl(new ucHome());
        }


        private void AbrirUserControl(UserControl uc)
        {
            // Limpa o que tiver no painel
            panelConteudo.Controls.Clear();

            uc.Dock = DockStyle.Fill; // Faz o UserControl preencher o painel

            panelConteudo.Controls.Add(uc); // Adiciona o UserControl ao painel



        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            FecharMain();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var confirmacao = MessageBox.Show(
            $"Deseja sair do programa?",
            "Confirmação", MessageBoxButtons.YesNo);
            if (confirmacao == DialogResult.Yes)
            {
                FecharMain();
            }
            else
            {
                return;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelConteudo.Controls.Clear();
            AbrirUserControl(new ucHome());
        }



        private void FecharMain()
        {
            Close();
            frmLogin telaLogin = new();
            telaLogin.ShowDialog();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void AtualizarUsuarioLogado()
        {
            lblUsername.Text = Session.UsuarioLogado.Nome ?? "Usuário";

            // Centralizar horizontalmente o lblUsername em relação ao pbFoto
            lblUsername.Left = pbFoto.Left + (pbFoto.Width - lblUsername.Width) / 2;

            lblUsername.Top = pbFoto.Bottom + 4;


            if (!string.IsNullOrEmpty(Session.UsuarioLogado.UrlFoto) && File.Exists(Session.UsuarioLogado.UrlFoto))
            {
                pbFoto.Image = Image.FromFile(Session.UsuarioLogado.UrlFoto);
            }

        }

        private void pbNotification_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(npNotifica.Text, out int qtdNotifica))
                {
                    if (qtdNotifica > 0)
                    {
                        qtdNotifica--;
                        npNotifica.Text = qtdNotifica > 0 ? qtdNotifica.ToString() : string.Empty;
                        npNotifica.FillColor = qtdNotifica > 0 ? npNotifica.FillColor : Color.Transparent;

                        string mensagem = qtdNotifica > 0 ? $"Você tem {qtdNotifica} notificações." : "Você não tem mais notificações.";
                        mdNotifica.Show(mensagem);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            panelConteudo.Controls.Clear();
            AbrirUserControl(new ucUsuario());
        }
        private void pbNightMode_Click(object sender, EventArgs e)
        {

        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            panelConteudo.Controls.Clear();
            AbrirUserControl(new ucAlunos());
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            panelConteudo.Controls.Clear();
            AbrirUserControl(new ucCursos());
        }

        private void btnUnidades_Click(object sender, EventArgs e)
        {
            panelConteudo.Controls.Clear();
            AbrirUserControl(new ucUnidades());
        }

        private void pbColorMode_Click(object sender, EventArgs e)
        {
            bool isDarkMode = this.BackColor == Color.FromArgb(32, 32, 32);

            if (isDarkMode)
            {
                // Modo Claro - Light Mode

                Color lightBackColor = SystemColors.ButtonHighlight;
                Color lightPanelColor = Color.WhiteSmoke;

                this.BackColor = lightBackColor;
                this.ForeColor = lightPanelColor;

                panelConteudo.BackColor = lightPanelColor;
                pbColorMode.Image = Properties.Resources.lightmode;
            }
            else
            {

            }


            }
        }
    }
}

