using TransformeseApp2.DAL;
using TransformeseApp2.DTO;

namespace TransformeseApp2.BLL
{
    public class AlunoBLL
    {
        public void CadastrarAluno(AlunoDTO alunoDTO)
        {
            var aluno = Database.Alunos;

            //Validação antes de salvar o aluno
            if (string.IsNullOrWhiteSpace(alunoDTO.Nome))
                throw new Exception("Nome do aluno é obrigatório.");

            aluno.Add(alunoDTO);
            Database.Alunos = aluno; // Salva a lista no JSON
        }
        public List<AlunoDTO> ListarAlunos() => Database.Alunos;

        public void AtualizarAluno(AlunoDTO alunoDTO)
        {
            var alunos = Database.Alunos;
            var alunoExistente = alunos.FirstOrDefault(aluno => aluno.Id == alunoDTO.Id);

            if (alunoExistente == null)
                throw new Exception("Aluno não encontrado.");

            if (string.IsNullOrWhiteSpace(alunoDTO.Nome))
                throw new Exception("Nome é obrigatório.");
            

            // Atualiza os campos do aluno
            alunoExistente.Nome = alunoDTO.Nome;
            alunoExistente.CursoId = alunoDTO.CursoId;
            alunoExistente.UnidadeId = alunoDTO.UnidadeId;
            Database.Alunos = alunos; // Salva a lista atualizada no JSON
        }

        public void RemoverAluno(int id)
        {
            var alunos = Database.Alunos;
            var aluno = Database.Alunos.FirstOrDefault(aluno => aluno.Id == id);
            if (aluno == null)
            {
                throw new Exception("Aluno não encontrado.");
            }

            Database.Alunos.Remove(aluno);
            Database.Alunos = alunos; // Salva a lista atualizada no JSON
        }
    }
}
