using TransformeseApp2.DAL;
using TransformeseApp2.DTO;

namespace TransformeseApp2.BLL
{
    public class UnidadeBLL
    {
        private List<UnidadeDTO> _unidades = Database.Unidades;
        public void CadastrarUnidade(UnidadeDTO unidadeDTO)
        {
            //Validação antes de salvar a unidade
            if (string.IsNullOrWhiteSpace(unidadeDTO.Nome))
                throw new Exception("Nome da unidade é obrigatório.");
                Database.Unidades.Add(unidadeDTO);
        }
        public List<UnidadeDTO> ListarUnidades() => Database.Unidades;

        public UnidadeDTO GetById(int id)
        {
            return _unidades.FirstOrDefault(unidade => unidade.Id == id);
        }
    }
}
