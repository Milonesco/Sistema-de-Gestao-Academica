using TransformeseApp2.DAL;
using TransformeseApp2.DTO;

namespace TransformeseApp2.BLL
{
    public class AlunoBLL
    {
        private List<AlunoDTO> _alunos = Database.Alunos;
        public void CadastrarAluno(AlunoDTO alunoDTO)
        {
            //Validação antes de salvar o aluno
            if (string.IsNullOrWhiteSpace(alunoDTO.Nome))
                throw new Exception("Nome do aluno é obrigatório.");
            Database.Alunos.Add(alunoDTO);
        }
        public List<AlunoDTO> ListarAlunos() => Database.Alunos;

        public void AtualizarAluno(AlunoDTO alunoDTO)
        {
            var alunoExistente = Database.Alunos.FirstOrDefault(aluno => aluno.Id == alunoDTO.Id);
            if (alunoExistente == null)
                throw new Exception("Aluno não encontrado.");

            if (string.IsNullOrWhiteSpace(alunoDTO.Nome))
                throw new Exception("Nome é obrigatório.");
            

            // Atualiza os campos do aluno
            alunoExistente.Nome = alunoDTO.Nome;
            alunoExistente.CursoId = alunoDTO.CursoId;
            alunoExistente.UnidadeId = alunoDTO.UnidadeId;
        }

        public void RemoverAluno(int id)
        {
            var aluno = Database.Alunos.FirstOrDefault(aluno => aluno.Id == id);
            if (aluno == null)
            {
                throw new Exception("Aluno não encontrado.");
            }

            Database.Alunos.Remove(aluno);
        }
    }
}
