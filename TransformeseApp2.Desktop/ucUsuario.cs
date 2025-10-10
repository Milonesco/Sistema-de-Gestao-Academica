using System.Data;
using TransformeseApp2.BLL;
using TransformeseApp2.DAL;
using TransformeseApp2.DTO;

namespace TransformeseApp2.Desktop
{
    public partial class ucUsuario : UserControl
    {
        UsuarioBLL UsuarioBLL = new UsuarioBLL();
        private int? usuarioSelecionadoId = null;

        string diretorio = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\transformese";

        string diretorioImagens = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}";


        public ucUsuario()
        {
            InitializeComponent();
        }

        private void ucUsuario_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
            ConfigurarEventos();
        }


        private void pbFoto_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
            }

            OpenFileDialog openFileDialog = new();
            openFileDialog.InitialDirectory = diretorioImagens;
            openFileDialog.Filter = "Arquivos de Imagem |*.jpg;*.jpeg;*.png;*.gif;";
            openFileDialog.Title = "Selecione uma imagem";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivoImagem = openFileDialog.FileName;

                //Exibe a imagem escolhida no PictureBox

                pbFoto.Image = Image.FromFile(nomeArquivoImagem);

                //Salva o caminho da foto
                txtFotoCaminho.Text = nomeArquivoImagem;
            }
        }

        private void lblFoto_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
            }

            OpenFileDialog openFileDialog = new();
            openFileDialog.InitialDirectory = diretorioImagens;
            openFileDialog.Filter = "Arquivos de Imagem |*.jpg;*.jpeg;*.png;*.gif;";
            openFileDialog.Title = "Selecione uma imagem";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivoImagem = openFileDialog.FileName;

                //Exibe a imagem escolhida no PictureBox

                pbFoto.Image = Image.FromFile(nomeArquivoImagem);

                //Salva o caminho da foto
                txtFotoCaminho.Text = nomeArquivoImagem;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Nome da imagem a ser salva
            string nomeImg = $"{Database.Usuarios.Count + 1} - {txtUsuario.Text}.jpg";

            // Verifica se o diretorio para salvar as imagens existe, se não existir cria o diretorio
            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
            }

            //URL da imagem

            string UrlImagem = Path.Combine(diretorio, nomeImg);

            Image imagem = pbFoto.Image;
            imagem.Save(UrlImagem);

            var usuario = new UsuarioDTO
            {
                Id = Database.Usuarios.Count + 1,
                Nome = txtNome.Text,
                Login = txtUsuario.Text,
                Senha = txtSenha.Text,
                UrlFoto = txtFotoCaminho.Text
            };

            UsuarioBLL.CadastrarUsuario(usuario);
            MessageBox.Show($"Usuário {usuario.Nome} cadastrado com sucesso!", "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNome.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtSenha.Text = string.Empty;
            AtualizarGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgUsuario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione ao menos um usuario para exclusão!");
                return;
            }

            List<int> ids = new List<int>();
            List<string> nomesDosUsuarios = new List<string>();

            foreach (DataGridViewRow row in dgUsuario.SelectedRows)
            {
                if (row.Cells["Id"].Value != null)
                    ids.Add(Convert.ToInt32(row.Cells["Id"].Value));
                if (row.Cells["Nome"].Value != null)
                    nomesDosUsuarios.Add(row.Cells["Nome"].Value.ToString());
            }

            string nomesFormatados = string.Join(", ", nomesDosUsuarios);
            var confirmacao = MessageBox.Show(
                $"Confirma a exclusão do(s) usuario(s) selecionado(s)?\nUsuarios selecionados: {nomesFormatados}",
                "Confirmação", MessageBoxButtons.YesNo);

            if (confirmacao == DialogResult.Yes)
            {
                foreach (int id in ids)
                {
                    UsuarioBLL.RemoverUsuario(id);
                }
                MessageBox.Show($"Usuario(s) {nomesFormatados} removido(s) com sucesso!", "Exclusão de Aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (usuarioSelecionadoId != null)
            {
                try
                {
                    string urlImagemAtualizada = txtFotoCaminho.Text;

                    if (pbFoto.Image != null && !string.IsNullOrEmpty(txtFotoCaminho.Text))
                    {
                        string nomeImg = $"{usuarioSelecionadoId.Value} - {txtUsuario.Text}.jpg";

                        urlImagemAtualizada = Path.Combine(diretorio, nomeImg);

                        Image imagem = pbFoto.Image;
                        imagem.Save(urlImagemAtualizada);
                    }

                    var usuarioAtualizado = new UsuarioDTO
                    {
                        Id = usuarioSelecionadoId.Value,
                        Nome = txtNome.Text,
                        Login = txtUsuario.Text,
                        Senha = txtSenha.Text,
                        UrlFoto = urlImagemAtualizada
                    };

                    UsuarioBLL.AtualizarUsuario(usuarioAtualizado);
                    MessageBox.Show($"Usuário {usuarioAtualizado.Nome} atualizado com sucesso!");

                    txtNome.Clear();
                    txtUsuario.Clear();
                    txtSenha.Clear();
                    txtFotoCaminho.ClearSelection();
                    pbFoto.Image = null;
                    usuarioSelecionadoId = null;
                    btnAtualizar.Enabled = false;

                    AtualizarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void AtualizarGrid()
        {
            dgUsuario.Columns.Clear();
            dgUsuario.AutoGenerateColumns = false;
            dgUsuario.RowTemplate.Height = 60;
            dgUsuario.AllowUserToAddRows = false;

            var colFoto = new DataGridViewImageColumn
            {
                HeaderText = "Foto",
                Name = "Foto",
                DataPropertyName = "Foto",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
            };

            dgUsuario.Columns.Add(colFoto);

            dgUsuario.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", Name = "Id" });
            dgUsuario.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome", Name = "Nome" });
            dgUsuario.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "User", HeaderText = "User", Name = "User" });
            dgUsuario.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Senha", HeaderText = "Senha", Name = "Senha" });
            dgUsuario.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UrlFoto", HeaderText = "UrlFoto", Name = "UrlFoto" });



            var usuarios = UsuarioBLL.ListarUsuarios();

            var dt = new DataTable();
            dt.Columns.Add("Foto", typeof(Image));
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Login", typeof(string));
            dt.Columns.Add("Senha", typeof(string));
            dt.Columns.Add("UrlFoto", typeof(string));

            foreach (var usuario in usuarios)
            {
                Image? image = null;
                if (!string.IsNullOrEmpty(usuario.UrlFoto) && File.Exists(usuario.UrlFoto))
                {
                    try
                    {
                        using (var fs = new FileStream(usuario.UrlFoto, FileMode.Open, FileAccess.Read))
                        {
                            image = Image.FromStream(fs);
                        }
                    }
                    catch (Exception)
                    {
                        image = null;
                    }
                }
                dt.Rows.Add(image);
            }

            var lista = UsuarioBLL.ListarUsuarios()
                                .Select(usuario => new
                                {
                                    usuario.Id,
                                    usuario.Nome,
                                    usuario.Login,
                                }).ToList();

            dgUsuario.DataSource = lista;

        }

        private void dgUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgUsuario.Rows[e.RowIndex];

                usuarioSelecionadoId = Convert.ToInt32(row.Cells["Id"].Value);
                txtNome.Text = row.Cells["Nome"].Value.ToString();
                txtUsuario.Text = row.Cells["Login"].Value.ToString();

                btnAtualizar.Enabled = true;
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            BuscarAluno();
        }

        private void BuscarAluno()
        {
            string termo = txtPesquisa.Text.Trim().ToLower();

            var filtrados = UsuarioBLL.ListarUsuarios()
                                         .Where(usuario => usuario.Nome.ToLower().Contains(termo))
                                         .Select(usuario => new
                                         {
                                             usuario.Id,
                                             usuario.Nome,
                                             usuario.Login,
                                         }).ToList();
            dgUsuario.DataSource = filtrados;
        }

        private bool senhaVisivel = false;

        private void MostrarOcultarSenha(object sender, EventArgs e)
        {
            senhaVisivel = !senhaVisivel;

            if (senhaVisivel)
            {
                txtSenha.PasswordChar = '\0';
                txtSenha.IconRight = Properties.Resources.eye_open;
            }
            else
            {
                txtSenha.PasswordChar = '●';
                txtSenha.IconRight = Properties.Resources.eye_closed;
            }
        }

        private void ConfigurarEventos()
        {
            txtSenha.IconRightClick += MostrarOcultarSenha;
            txtSenha.PasswordChar = '●';
            senhaVisivel = false;
        }
    }
}

