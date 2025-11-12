using TransformeseApp2.DAL;
using TransformeseApp2.DTO;

namespace TransformeseApp2.BLL
{
    public class UsuarioBLL
    {
        UsuarioDAL usuarioDAL = new();
        public UsuarioDTO? Login(string login, string senha)
        {
            //var usuario = Database.Usuarios.FirstOrDefault(u => u.Usuario == Login && u.Senha == Senha);

            //if (usuario == null)
            //{
            //    throw new Exception("Usuário ou senha inválidos");
            //}


            //return usuario;
            return usuarioDAL.Autenticar(login, senha);
        }
        public List<TipoUsuarioDTO> GetTipoUsuario()
        {
            return usuarioDAL.GetTipoUsuario();
        }

        public List<UsuarioDTO> ListarUsuarios()
        {
            return usuarioDAL.Listar();
        }

        public void AtualizarUsuario(UsuarioDTO usuarioDTO)
        {
            //var usuarioExistente = Database.Usuarios.FirstOrDefault(usuario => usuario.Id == usuarioDTO.Id);
            //if (usuarioExistente == null)
            //    throw new Exception("Usuario não encontrado.");

            //if (string.IsNullOrWhiteSpace(usuarioDTO.Nome))
            //    throw new Exception("Nome é obrigatório.");


            //// Atualiza os campos do usuario
            //usuarioExistente.Id = usuarioDTO.Id;
            //usuarioExistente.Nome = usuarioDTO.Nome;
            //usuarioExistente.Usuario = usuarioDTO.Usuario;
            //usuarioExistente.Senha = usuarioDTO.Senha;
            //usuarioExistente.UrlFoto = usuarioDTO.UrlFoto;

            if (string.IsNullOrWhiteSpace(usuarioDTO.Nome))
                throw new Exception("Nome é obrigatório.");

            usuarioDAL.Update(usuarioDTO);
        }

        public void CadastrarUsuario(UsuarioDTO usuario)
        {
            //var usuarios = Database.Usuarios;

            //if (string.IsNullOrWhiteSpace(usuario.Nome))
            //{
            //    throw new Exception("Nome é obrigatório!");
            //} 
            
            //if (string.IsNullOrWhiteSpace(usuario.Usuario))
            //{

            //    throw new Exception("Login é obrigatório!");
            //}            
            
            //if (string.IsNullOrWhiteSpace(usuario.Senha))
            //{
            //    throw new Exception("Senha é obrigatório!");
            //}

            //usuarios.Add(usuario);
            //Database.Usuarios = usuarios; // Salva a lista no JSON
            usuarioDAL.Create(usuario);
        }

        public void RedefinirSenha(string login, string novaSenha)
        {
            var usuario = Database.Usuarios.FirstOrDefault(u => u.Usuario == login);
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

