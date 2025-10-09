using TransformeseApp2.DAL;
using TransformeseApp2.DTO;
using TransformeseApp2.BLL;

namespace TransformeseApp2.Desktop
{
    public partial class ucAlunos : UserControl
    {
        private readonly AlunoBLL alunoBLL = new();
        private int? alunoSelecionadoId = null;
        public ucAlunos()
        {
            InitializeComponent();
        }
        private void ucAlunos_Load(object sender, EventArgs e)
        {
            if (!Database.Cursos.Any())
            {
                Database.Cursos.Add(new CursoDTO { Id = 1, Nome = "Programador de Sistemas" });
                Database.Cursos.Add(new CursoDTO { Id = 2, Nome = "Banco de Dados" });
            }

            if (!Database.Unidades.Any())
            {
                Database.Unidades.Add(new UnidadeDTO { Id = 1, Nome = "SMP - São Miguel Paulista" });
                Database.Unidades.Add(new UnidadeDTO { Id = 2, Nome = "ITQ - Itaquera" });
            }

            if (!Database.Alunos.Any())
            {
                Database.Alunos.Add(new AlunoDTO { Id = 1, Nome = "Ana Silva", CursoId = 1, UnidadeId = 1 });
                Database.Alunos.Add(new AlunoDTO { Id = 2, Nome = "Jorge von Estranho", CursoId = 2, UnidadeId = 1 });
                Database.Alunos.Add(new AlunoDTO { Id = 3, Nome = "Glebenson", CursoId = 2, UnidadeId = 2 });
            }

            //Populando ComboBox de Cursos
            cboCurso.DataSource = Database.Cursos; //Obtendo lista completa de cursos
            cboCurso.DisplayMember = "Nome"; // Atributo que será exibido no Combo Box
            cboCurso.ValueMember = "Id"; // Atributo que será atrelado ao valor do item exibido
            cboCurso.DropDownStyle = ComboBoxStyle.DropDownList;

            // Populando ComboBox de Unidades
            cboUnidade.DataSource = Database.Unidades; // Obtendo lista completa de unidades
            cboUnidade.DisplayMember = "Nome"; // Atributo que será exibido no Combo Box
            cboUnidade.ValueMember = "Id"; // Atributo que será atrelado ao valor do item exibido
            cboUnidade.DropDownStyle = ComboBoxStyle.DropDownList;

            AtualizarGrid();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var aluno = new AlunoDTO
                {
                    Id = Database.Alunos.Count + 1,
                    Nome = txtNome.Text,
                    CursoId = (int)cboCurso.SelectedValue,
                    UnidadeId = (int)cboUnidade.SelectedValue,
                };

                alunoBLL.CadastrarAluno(aluno);
                MessageBox.Show($"Aluno {txtNome.Text} cadastrado com sucesso", "Cadastro de Aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Clear();
                AtualizarGrid();
            }
            catch (Exception erro)
            {

                MessageBox.Show($"Erro: {erro.Message}");
            }
        }

        private void AtualizarGrid()
        {
            var lista = alunoBLL.ListarAlunos()
                                .Select(aluno => new
                                {
                                    aluno.Id,
                                    aluno.Nome,
                                    Curso = Database.Cursos.First(curso => curso.Id == aluno.CursoId).Nome,
                                    Unidade = Database.Unidades.First(unidade => unidade.Id == aluno.UnidadeId).Nome
                                }).ToList();

            dgAlunos.DataSource = lista;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgAlunos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione ao menos um aluno para exclusão!");
                return;
            }

            List<int> ids = new List<int>();
            List<string> nomesDosAlunos = new List<string>();

            foreach (DataGridViewRow row in dgAlunos.SelectedRows)
            {
                if (row.Cells["Id"].Value != null)
                    ids.Add(Convert.ToInt32(row.Cells["Id"].Value));
                if (row.Cells["Nome"].Value != null)
                    nomesDosAlunos.Add(row.Cells["Nome"].Value.ToString());
            }

            string nomesFormatados = string.Join(", ", nomesDosAlunos);
            var confirmacao = MessageBox.Show(
                $"Confirma a exclusão do(s) aluno(s) selecionado(s)?\nAlunos selecionados: {nomesFormatados}",
                "Confirmação", MessageBoxButtons.YesNo);

            if (confirmacao == DialogResult.Yes)
            {
                foreach (int id in ids)
                {
                    alunoBLL.RemoverAluno(id);
                }
                MessageBox.Show($"Aluno(s) {nomesFormatados} removido(s) com sucesso!", "Exclusão de Aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (alunoSelecionadoId != null)
            {
                btnAtualizar.Enabled = true;
                try
                {
                    var alunoAtualizado = new AlunoDTO
                    {
                        Id = alunoSelecionadoId.Value,
                        Nome = txtNome.Text,
                        CursoId = (int)cboCurso.SelectedValue,
                        UnidadeId = (int)cboUnidade.SelectedValue
                    };
                    alunoBLL.AtualizarAluno(alunoAtualizado);
                    MessageBox.Show($"Aluno {alunoAtualizado.Nome} atualizado com sucesso!");
                    txtNome.Clear();
                    alunoSelecionadoId = null;
                    AtualizarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                    throw;
                }

            }
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            BuscarAluno();
        }

        private void dgAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                DataGridViewRow row = dgAlunos.Rows[e.RowIndex];

                alunoSelecionadoId = Convert.ToInt32(row.Cells["Id"].Value);
                txtNome.Text = row.Cells["Nome"].Value.ToString();

                string nomeCurso = row.Cells["Curso"].Value.ToString();
                string nomeUnidade = row.Cells["Unidade"].Value.ToString();

                cboCurso.SelectedValue = Database.Cursos.First(c => c.Nome == nomeCurso).Id;
                cboUnidade.SelectedValue = Database.Unidades.First(u => u.Nome == nomeUnidade).Id;

                btnAtualizar.Enabled = true;
            }
        }

        private void BuscarAluno()
        {
            string termo = txtPesquisa.Text.Trim().ToLower();

            var filtrados = alunoBLL.ListarAlunos()
                                         .Where(aluno => aluno.Nome.ToLower().Contains(termo))
                                         .Select(aluno => new
                                         {
                                             aluno.Id,
                                             aluno.Nome,
                                             Curso = Database.Cursos.First(curso => curso.Id == aluno.CursoId).Nome,
                                             Unidade = Database.Unidades.First(unidade => unidade.Id == aluno.UnidadeId).Nome
                                         }).ToList();
            dgAlunos.DataSource = filtrados;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            BuscarAluno();
        }
    }
}
