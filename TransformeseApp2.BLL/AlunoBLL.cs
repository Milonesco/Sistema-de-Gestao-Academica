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

        public AlunoDTO GetById(int id)
        {
            return _alunos.FirstOrDefault(a => a.Id == id);
        }
    }
}
