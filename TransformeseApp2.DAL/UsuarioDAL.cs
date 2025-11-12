using System.Linq.Expressions;
using System.Net;
using Microsoft.Data.SqlClient;
using TransformeseApp2.DTO;

namespace TransformeseApp2.DAL
{
    public class UsuarioDAL : Conexao
    {
        public void Create(UsuarioDTO usuario)
        {
            Conectar();
            SqlTransaction transaction = conexao.BeginTransaction();
            try
            {
                // Inserir na tabela pessoa
                command = new SqlCommand
                    (
                    @"INSERT INTO Pessoa (Nome, Email, Telefone, DataNascimento, CPF, Sexo, UrlFoto) 
                    VALUES (@Nome, @Email, @Telefone, @DataNascimento, @CPF, @Sexo, @UrlFoto);
                    SELECT CAST (SCOPE_IDENTITY() AS int)", conexao, transaction
                    );

                command.Parameters.AddWithValue("@Nome", usuario.Nome);
                command.Parameters.AddWithValue("@Email", usuario.Email);
                command.Parameters.AddWithValue("@Telefone", usuario.Telefone);
                command.Parameters.AddWithValue("@DataNascimento", usuario.DataNascimento);
                command.Parameters.AddWithValue("@CPF", usuario.CPF);
                command.Parameters.AddWithValue("@Sexo", usuario.Sexo);
                command.Parameters.AddWithValue("@UrlFoto", (object)usuario.UrlFoto ?? DBNull.Value);

                int idPessoa = Convert.ToInt32(command.ExecuteScalar());

                // Inserir na tabela usuario

                command = new SqlCommand
                    (
                    @"INSERT INTO Usuario (Id, Usuario, Senha, TpUsuario) VALUES (@Id, @Usuario, @Senha, @TpUsuario)", conexao, transaction
                    );

                command.Parameters.AddWithValue(@"Id", idPessoa);
                command.Parameters.AddWithValue(@"Usuario", usuario.Usuario);
                command.Parameters.AddWithValue(@"Senha", usuario.Senha);
                command.Parameters.AddWithValue(@"TpUsuario", usuario.TpUsuario);

                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception erro)
            {
                transaction.Rollback();
                throw new Exception(erro.Message);
            }
            finally
            {
                Desconectar();
            }
        }
        public UsuarioDTO Autenticar(string login, string senha)
        {
            try
            {
                Conectar();
                command = new SqlCommand("SELECT * FROM Usuario WHERE Usuario = @Usuario AND Senha = @Senha", conexao);

                command.Parameters.AddWithValue("@Usuario", login);
                command.Parameters.AddWithValue("@Senha", senha);
                dataReader = command.ExecuteReader();

                UsuarioDTO usuario = null;
                if (dataReader.Read())
                {
                    {
                        usuario = new();
                        usuario.Usuario = dataReader["Usuario"].ToString();
                        usuario.Senha = dataReader["Senha"].ToString();
                        usuario.TpUsuario = (int)dataReader["TpUsuario"];
                    }
                }
                return usuario;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public List<UsuarioDTO> Listar()
        {
            List<UsuarioDTO> lista = new List<UsuarioDTO>();
            try
            {
                Conectar();
                command = new SqlCommand
                    (@"SELECT u.Id, u.Usuario, u.Senha, u.TpUsuario,
                     p.Nome, p.Email, p.Telefone, p.DataNascimento, p.CPF, p.Sexo, p.UrlFoto
                     FROM Usuario u
                     JOIN Pessoa p ON u.Id = p.Id", conexao);

                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    UsuarioDTO usuario = new UsuarioDTO();

                    // Dados da Tabela Usuario
                    usuario.Id = Convert.ToInt32(dataReader["Id"]);
                    usuario.Usuario = dataReader["Usuario"].ToString();
                    usuario.Senha = dataReader["Senha"].ToString();
                    usuario.TpUsuario = Convert.ToInt32(dataReader["TpUsuario"]);

                    // Dados da Tabela Pessoa
                    usuario.Nome = dataReader["Nome"].ToString();
                    usuario.Email = dataReader["Email"].ToString();
                    usuario.Telefone = dataReader["Telefone"].ToString();
                    usuario.DataNascimento = Convert.ToDateTime(dataReader["DataNascimento"]);
                    usuario.CPF = dataReader["CPF"].ToString();
                    usuario.Sexo = dataReader["Sexo"].ToString();
                    usuario.UrlFoto = dataReader["UrlFoto"] != DBNull.Value ? dataReader["UrlFoto"].ToString() : null;

                    lista.Add(usuario);
                }
                return lista;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public void Update(UsuarioDTO usuario)
        {
            Conectar();
            SqlTransaction transaction = conexao.BeginTransaction();
            try
            {

                command = new SqlCommand
                    (
                    @"UPDATE Pessoa SET Nome = @Nome, Email = @Email, Telefone = @Telefone, 
                    DataNascimento = @DataNascimento, CPF = @CPF, Sexo = @Sexo, UrlFoto = @UrlFoto 
                    WHERE Id = @Id", conexao, transaction
                    );

                command.Parameters.AddWithValue("@Nome", usuario.Nome);
                command.Parameters.AddWithValue("@Email", usuario.Email);
                command.Parameters.AddWithValue("@Telefone", usuario.Telefone);
                command.Parameters.AddWithValue("@DataNascimento", usuario.DataNascimento);
                command.Parameters.AddWithValue("@CPF", usuario.CPF);
                command.Parameters.AddWithValue("@Sexo", usuario.Sexo);
                command.Parameters.AddWithValue("@UrlFoto", (object)usuario.UrlFoto ?? DBNull.Value);
                command.Parameters.AddWithValue("@Id", usuario.Id); 

                command.ExecuteNonQuery();

                command = new SqlCommand
                    (
                    @"UPDATE Usuario SET Usuario = @Usuario, Senha = @Senha, TpUsuario = @TpUsuario 
                    WHERE Id = @Id", conexao, transaction
                    );

                command.Parameters.AddWithValue("@Usuario", usuario.Usuario);
                command.Parameters.AddWithValue("@Senha", usuario.Senha);
                command.Parameters.AddWithValue("@TpUsuario", usuario.TpUsuario);
                command.Parameters.AddWithValue("@Id", usuario.Id); 

                command.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception erro)
            {
                transaction.Rollback();
                throw new Exception(erro.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public List<TipoUsuarioDTO> GetTipoUsuario()
        {
            List<TipoUsuarioDTO> tipos = new List<TipoUsuarioDTO>();

            try
            {
                Conectar();
                string sql = "SELECT IdTipoUsuario, DescricaoTipoUsuario FROM TipoUsuario";
                command = new SqlCommand(sql, conexao);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    tipos.Add(new TipoUsuarioDTO
                    {
                        IdTipoUsuario = Convert.ToInt32(dataReader["IdTipoUsuario"]),
                        DescricaoTipoUsuario = dataReader["DescricaoTipoUsuario"].ToString()
                    });
                }

                return tipos;
            }
            catch (Exception erro)
            {
                throw new Exception($"Erro ao listar tipos de usuário: {erro.Message}");
            }
            finally
            {
                Desconectar();
            }
        }
    }
}

