using TransformeseApp2.DAL;
using TransformeseApp2.DTO;

namespace TransformeseApp2.BLL
{
    public class CursoBLL
    {
        private List<CursoDTO> _cursos = Database.Cursos;
        public void CadastrarCurso(CursoDTO cursoDTO)
        {
            //Validação antes de salvar o curso
            if (string.IsNullOrWhiteSpace(cursoDTO.Nome))
                throw new Exception("Nome do curso é obrigatório.");
            Database.Cursos.Add(cursoDTO);
        }
        public List<CursoDTO> ListarCursos() => Database.Cursos;

        public CursoDTO GetById(int id)
        {
            return _cursos.FirstOrDefault(c => c.Id == id);
        }
    }
}
