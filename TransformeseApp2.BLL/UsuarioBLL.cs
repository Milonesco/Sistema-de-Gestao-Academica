using TransformeseApp2.DAL;
using TransformeseApp2.DTO;

namespace TransformeseApp2.BLL
{
    public class UsuarioBLL
    {
        public UsuarioDTO? Login(string Login, string Senha)
        {
            var usuario = Database.Usuarios.FirstOrDefault(u => u.Login == Login && u.Senha == Senha);

            if (usuario == null)
            {
                throw new Exception("Usuário ou senha inválidos");
            }


            return usuario;
        }

        public List<UsuarioDTO> ListarUsuarios() => Database.Usuarios;

        public void AtualizarUsuario(UsuarioDTO usuarioDTO)
        {
            var usuarioExistente = Database.Usuarios.FirstOrDefault(usuario => usuario.Id == usuarioDTO.Id);
            if (usuarioExistente == null)
                throw new Exception("Usuario não encontrado.");

            if (string.IsNullOrWhiteSpace(usuarioDTO.Nome))
                throw new Exception("Nome é obrigatório.");


            // Atualiza os campos do usuario
            usuarioExistente.Id = usuarioDTO.Id;
            usuarioExistente.Nome = usuarioDTO.Nome;
            usuarioExistente.Login = usuarioDTO.Login;
            usuarioExistente.Senha = usuarioDTO.Senha;
            usuarioExistente.UrlFoto = usuarioDTO.UrlFoto;
        }

        public void CadastrarUsuario(UsuarioDTO usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.Nome))
            {
                throw new Exception("Nome é obrigatório!");
            } 
            
            if (string.IsNullOrWhiteSpace(usuario.Login))
            {
                throw new Exception("Login é obrigatório!");
            }            
            
            if (string.IsNullOrWhiteSpace(usuario.Senha))
            {
                throw new Exception("Senha é obrigatório!");
            }

            Database.Usuarios.Add(usuario);
        }

        public void RedefinirSenha(string login, string novaSenha)
        {
            var usuario = Database.Usuarios.FirstOrDefault(u => u.Login == login);
            if (usuario == null)
                throw new Exception("Usuário não encontrado!");

            usuario.Senha = novaSenha;
        }

        public void RemoverUsuario(int id)
        {
            var usuario = Database.Usuarios.FirstOrDefault(usuario => usuario.Id == id);
            if (usuario == null)
            {
                throw new Exception("Usuário não encontrado.");
            }

            Database.Usuarios.Remove(usuario);
        }
    }



}

