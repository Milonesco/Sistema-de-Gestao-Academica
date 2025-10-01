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
            if (int.IsNegative(cursoDTO.CargaHoraria))
                throw new Exception("Carga horaria precisa ser positiva, tente novamente, por favor!");
            Database.Cursos.Add(cursoDTO);
        }
        public List<CursoDTO> ListarCursos() => Database.Cursos;

        public void AtualizarCurso(CursoDTO cursoDTO)
        {
            var cursoExistente = Database.Cursos.FirstOrDefault(curso => curso.Id == cursoDTO.Id);
            if (cursoExistente == null)
                throw new Exception("Curso não encontrado.");

            if (string.IsNullOrWhiteSpace(cursoDTO.Nome))
                throw new Exception("Nome é obrigatório.");


            // Atualiza os campos do aluno
            cursoExistente.Nome = cursoDTO.Nome;
            cursoExistente.Id = cursoDTO.Id;
            cursoExistente.CargaHoraria = cursoDTO.CargaHoraria;
        }




        public void RemoverCurso(int id)
        {
            var curso = Database.Cursos.FirstOrDefault(curso => curso.Id == id);
            if (curso == null)
            {
                throw new Exception("Curso não encontrado.");
            }

            Database.Cursos.Remove(curso);
        }
        public CursoDTO GetById(int id)
        {
            return _cursos.FirstOrDefault(curso => curso.Id == id);
        }
    }
}
