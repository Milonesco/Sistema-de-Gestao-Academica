using TransformeseApp2.DTO;

namespace TransformeseApp2.BLL
{
    public class Session
    {
        public static UsuarioDTO UsuarioLogado { get; set; }

        private static string _user;

        public static event Action<UsuarioDTO> OnUsuarioAtualizado;

        public static void AtualizarUsuarioLogado(UsuarioDTO novoUsuario)
        {
            UsuarioLogado = novoUsuario;
            OnUsuarioAtualizado?.Invoke(novoUsuario); // Notifica formulários/UCs ativos
        }

        public static string User
        {
            get { return Session._user; }
            set { Session._user = value; }
        }
    }
}
