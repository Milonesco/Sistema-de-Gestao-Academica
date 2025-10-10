using TransformeseApp2.BLL;

namespace TransformeseApp2.Desktop
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.FormClosing += frmMain_FormClosing;
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

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var resultado = MessageBox.Show(
                "Tem certeza que deseja sair do sistema?",
                "Confirmar Saída",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.No)
            {
                e.Cancel = true; // Cancela o fechamento
            }
            else
            {
                Application.Exit(); // Fecha tudo
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var confirmacao = MessageBox.Show(
            $"Deseja sair do programa?",
            "Confirmação", MessageBoxButtons.YesNo);
            if (confirmacao == DialogResult.Yes)
            {
                this.FecharMain();
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
    }
}
