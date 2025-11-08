using Microsoft.Data.SqlClient;
using TransformeseApp2.DTO;

namespace TransformeseApp2.DAL
{
    public class UsuarioDAL : Conexao
    {
        public UsuarioDTO Autenticar(string login, string senha)
        {
			try
			{
				Conectar();
				command = new SqlCommand("SELECT * FROM Usuario WHERE Login = @Login AND Senha = @Senha", conexao);

                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Senha", senha);
                dataReader = command.ExecuteReader();

                UsuarioDTO usuario = null;
                if(dataReader.Read())
                {
                    {
                        usuario = new();
                        usuario.Login = dataReader["Login"].ToString();
                        usuario.Senha = dataReader["Senha"].ToString();
                        usuario.TpUsuario = dataReader["TpUsuario"].ToString();
                    }
                }
                return usuario;
            }
			catch (Exception erro)
			{
				throw new Exception(erro.Message);
			}
        }
    }
}
