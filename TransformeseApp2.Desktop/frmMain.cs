using System.Diagnostics;
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
            var confirmacao = mdConfirmar.Show("Você realmente deseja sair?");
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
                Color darkBackColor = Color.FromArgb(32, 32, 32);
                Color darkPanelColor = Color.FromArgb(45, 45, 48);

                this.BackColor = darkBackColor;
                this.ForeColor = darkPanelColor;

                panelConteudo.BackColor = darkPanelColor;
                pbColorMode.Image = Properties.Resources.darkmode;
            }


        }

        private void pbSerasa_Click(object sender, EventArgs e)
        {
            AbrirLink("https://www.serasa.com.br/");
        }

        private void pbSenac_Click(object sender, EventArgs e)
        {
            AbrirLink("https://www.sp.senac.br/");
        }

        private void pbGerando_Click(object sender, EventArgs e)
        {
            AbrirLink("https://gerandofalcoes.com//");
        }

        private void AbrirLink(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                mdNotifica.Show("Erro", $"Erro: {ex.Message}");
            }
        }

        private void pbDiretorio_Click(object sender, EventArgs e)
        {
            string publica = @"T:\Publica\TRANSFORME-SE";

            try
            {
                if (Directory.Exists(publica))
                {
                    Process.Start("explorer.exe", publica);
                }
                else
                {
                    mdNotifica.Show("Erro", "O diretório não foi encontrado ou está inacessivel.");
                }
            }
            catch (Exception ex)
            {
                mdNotifica.Show("Erro", $"Erro: {ex.Message}");
            }
        }
    }
}
