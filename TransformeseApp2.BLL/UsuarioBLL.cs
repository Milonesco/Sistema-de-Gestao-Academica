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
    }



}

