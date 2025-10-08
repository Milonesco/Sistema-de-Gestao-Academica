using TransformeseApp2.DTO;

namespace TransformeseApp2.BLL
{
    public class Session
    {
        public static UsuarioDTO UsuarioLogado { get; set; }

        private static string _user;

        public static string User
        {
            get { return Session._user; }
            set { Session._user = value; }
        }
    }
}
