using TransformeseApp2.DTO;

namespace TransformeseApp2.DAL
{
    //Simulação do banco de dados em memória
    public static class Database
    {
        public static List<AlunoDTO> Alunos { get; } = new()
        {
            new AlunoDTO {Id = 1, Nome = "Milone", CursoId = 4, UnidadeId = 2},
            new AlunoDTO {Id = 2, Nome = "Paulo", CursoId = 1, UnidadeId = 3},
            new AlunoDTO {Id = 3, Nome = "Valentine", CursoId = 3, UnidadeId = 1},
            new AlunoDTO {Id = 4, Nome = "Cleber", CursoId = 2, UnidadeId = 4},
            new AlunoDTO {Id = 5, Nome = "Patroclo", CursoId = 5, UnidadeId = 5},
        };

        public static List<CursoDTO> Cursos { get; } = new()
        { 
            new CursoDTO {Id = 1, Nome = "Programador de Sistemas", CargaHoraria = 280},
            new CursoDTO {Id = 2, Nome = "Banco de Dados", CargaHoraria = 500},
            new CursoDTO {Id = 3, Nome = "Redes de Computadores", CargaHoraria = 300},
            new CursoDTO {Id = 4, Nome = "Segurança da Informação", CargaHoraria = 400},
            new CursoDTO {Id = 5, Nome = "Desenvolvimento Web", CargaHoraria = 350}
        };
        public static List<UnidadeDTO> Unidades { get; } = new()
        { 
            new UnidadeDTO {Id = 1, Nome = "SMP - São Miguel Paulista", Endereco = "Avenida Marechal Tito, 1500"},
            new UnidadeDTO {Id = 2, Nome = "ITQ - Itaquera", Endereco = "Avenida Itaquera, 8266"},
            new UnidadeDTO {Id = 3, Nome = "Mooca", Endereco = "Rua da Mooca, 1234" },
            new UnidadeDTO {Id = 4, Nome = "Centro", Endereco = "Rua Central, 5678" },
            new UnidadeDTO {Id = 5, Nome = "Vila Prudente", Endereco = "Avenida Vila Prudente, 91011" }
        };
        public static List<UsuarioDTO> Usuarios { get; } = new() 
        {
            new UsuarioDTO { Id = 1, Nome = "Admin", Login = "admin", Senha = "admin123"},
            new UsuarioDTO { Id = 2, Nome = "Usuario", Login = "user", Senha = "user123" },
            new UsuarioDTO { Id = 3, Nome = "Convidado", Login = "guest", Senha = "guest123"}
        };   
    }
}
