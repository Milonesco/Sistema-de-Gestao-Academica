using TransformeseApp2.DTO;

namespace TransformeseApp2.DAL
{
    //Simulação do banco de dados em memória
    public static class Database
    {
        public static List<AlunoDTO> Alunos { get; } = new();
        public static List<CursoDTO> Cursos { get; } = new();
        public static List<UnidadeDTO> Unidades { get; } = new();
        public static List<UsuarioDTO> Usuarios { get; } = new() 
        {
            new UsuarioDTO { Id = 1, Nome = "Admin", Login = "admin", Senha = "admin123"},
            new UsuarioDTO { Id = 2, Nome = "Usuario", Login = "user", Senha = "user123" },
            new UsuarioDTO { Id = 3, Nome = "Convidado", Login = "guest", Senha = "guest123"}
        };   
    }
}
