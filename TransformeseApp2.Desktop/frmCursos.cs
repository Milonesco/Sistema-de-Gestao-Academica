using TransformeseApp2.BLL;
using TransformeseApp2.DAL;
using TransformeseApp2.DTO;

namespace TransformeseApp2.Desktop
{
    public partial class frmCursos : Form
    {
        private readonly CursoBLL cursoBLL = new();
        private int? cursoSelecionadoId = null;


        public frmCursos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var curso = new CursoDTO
                {
                    Id = Database.Cursos.Count + 1,
                    Nome = txtNome.Text,
                    CargaHoraria = int.Parse(txtCargaHoraria.Text),
                };

                cursoBLL.CadastrarCurso(curso);
                MessageBox.Show($"Curso {txtNome.Text} cadastrado com sucesso", "Cadastro de Curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Clear();
                txtCargaHoraria.Clear();
                AtualizarGrid();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro: {erro.Message}");
            }
        }



        private void AtualizarGrid()
        {
            var lista = cursoBLL.ListarCursos()
                                .Select(curso => new
                                {
                                    curso.Id,
                                    curso.Nome,
                                    CargaHoraria = curso.CargaHoraria
                                }).ToList();

            dgCursos.DataSource = lista;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgCursos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione ao menos um curso para exclusão!");
                return;
            }

            List<int> ids = new List<int>();
            List<string> nomesDosCursos = new List<string>();

            foreach (DataGridViewRow row in dgCursos.SelectedRows)
            {
                if (row.Cells["Id"].Value != null)
                    ids.Add(Convert.ToInt32(row.Cells["Id"].Value));
                if (row.Cells["Nome"].Value != null)
                    nomesDosCursos.Add(row.Cells["Nome"].Value.ToString());
            }

            string nomesFormatados = string.Join(", ", nomesDosCursos);
            var confirmacao = MessageBox.Show(
                $"Confirma a exclusão do(s) curso(s) selecionado(s)?\nCurso(s) selecionados: {nomesFormatados}",
                "Confirmação", MessageBoxButtons.YesNo);

            if (confirmacao == DialogResult.Yes)
            {
                foreach (int id in ids)
                {
                    cursoBLL.RemoverCurso(id);
                }
                MessageBox.Show($"Curso(s) {nomesFormatados} removido(s) com sucesso!", "Exclusão de Curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
        }

        private void dgCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AtualizarGrid();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (cursoSelecionadoId != null)
            {
                btnAtualizar.Enabled = true;
                try
                {
                    var cursoAtualizado = new CursoDTO
                    {
                        Id = cursoSelecionadoId.Value,
                        Nome = txtNome.Text,
                        CargaHoraria = cursoSelecionadoId.Value,
                    };
                    cursoBLL.AtualizarCurso(cursoAtualizado);
                    MessageBox.Show($"Aluno {cursoAtualizado.Nome} atualizado com sucesso!");
                    txtNome.Clear();
                    cursoSelecionadoId = null;
                    AtualizarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                    throw;
                }
            }
        }

        private void dgCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgCursos.Rows[e.RowIndex];

                cursoSelecionadoId = Convert.ToInt32(row.Cells["Id"].Value);
                txtNome.Text = row.Cells["Nome"].Value.ToString();

                string nomeCurso = row.Cells["Nome"].Value.ToString();

                txtNome.Text = Database.Cursos.First(c => c.Nome == nomeCurso).Nome;
                txtCargaHoraria.Text = Database.Cursos.First(u => u.Nome == nomeCurso).CargaHoraria.ToString();

                btnAtualizar.Enabled = true;
            }
        }

        private void txtCargaHoraria_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
