using TransformeseApp2.BLL;
using TransformeseApp2.DAL;
using TransformeseApp2.DTO;

namespace TransformeseApp2.Desktop
{
    public partial class ucUnidades : UserControl
    {
        UnidadeBLL UnidadeBLL = new UnidadeBLL();
        private int? unidadeSelecionadoId = null;


        public ucUnidades()
        {
            InitializeComponent();
        }

        private void ucUnidades_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var unidade = new UnidadeDTO
                {
                    Id = Database.Unidades.Count + 1,
                    Nome = txtNome.Text,
                    Endereco = txtEndereco.Text,
                };

                UnidadeBLL.CadastrarUnidade(unidade);
                MessageBox.Show($"Unidade {txtNome.Text} cadastrada com sucesso", "Cadastro de Curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Clear();
                txtEndereco.Clear();
                AtualizarGrid();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro: {erro.Message}");
            }

            txtNome.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            AtualizarGrid();
        }



        private void AtualizarGrid()
        {
            var lista = UnidadeBLL.ListarUnidades()
                                .Select(unidade => new
                                {
                                    unidade.Id,
                                    unidade.Nome,
                                    unidade.Endereco,
                                }).ToList();

            dgUnidades.DataSource = lista;

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (unidadeSelecionadoId != null)
            {
                btnAtualizar.Enabled = true;
                try
                {
                    var unidadeAtualizada = new UnidadeDTO
                    {
                        Id = unidadeSelecionadoId.Value,
                        Nome = txtNome.Text,
                        Endereco = txtEndereco.Text,
                    };
                    UnidadeBLL.AtualizarUnidade(unidadeAtualizada);
                    MessageBox.Show($"Usuario {unidadeAtualizada.Nome} atualizado com sucesso!");
                    txtNome.Clear();
                    txtEndereco.Clear();
                    unidadeSelecionadoId = null;
                    AtualizarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                    throw;
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgUnidades.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione ao menos uma unidade para exclusão!");
                return;
            }

            List<int> ids = new List<int>();
            List<string> nomesDasUnidades = new List<string>();

            foreach (DataGridViewRow row in dgUnidades.SelectedRows)
            {
                if (row.Cells["Id"].Value != null)
                    ids.Add(Convert.ToInt32(row.Cells["Id"].Value));
                if (row.Cells["Nome"].Value != null)
                    nomesDasUnidades.Add(row.Cells["Nome"].Value.ToString());
            }

            string nomesFormatados = string.Join(", ", nomesDasUnidades);
            var confirmacao = MessageBox.Show(
                $"Confirma a exclusão do(s) usuario(s) selecionado(s)?\nUsuarios selecionados: {nomesFormatados}",
                "Confirmação", MessageBoxButtons.YesNo);

            if (confirmacao == DialogResult.Yes)
            {
                foreach (int id in ids)
                {
                    UnidadeBLL.RemoverUnidade(id);
                }
                MessageBox.Show($"Usuario(s) {nomesFormatados} removido(s) com sucesso!", "Exclusão de Aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
        }

        private void dgUnidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgUnidades.Rows[e.RowIndex];

                unidadeSelecionadoId = Convert.ToInt32(row.Cells["Id"].Value);
                txtNome.Text = row.Cells["Nome"].Value.ToString();
                txtEndereco.Text = row.Cells["Endereco"].Value.ToString();

                btnAtualizar.Enabled = true;
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            BuscarUnidade();
        }

        private void BuscarUnidade()
        {
            string termo = txtPesquisa.Text.Trim().ToLower();

            var filtrados = UnidadeBLL.ListarUnidades()
                                         .Where(unidade => unidade.Nome.ToLower().Contains(termo))
                                         .Select(unidade => new
                                         {
                                             unidade.Id,
                                             unidade.Nome,
                                             unidade.Endereco,
                                         }).ToList();
            dgUnidades.DataSource = filtrados;
        }
    }
}
