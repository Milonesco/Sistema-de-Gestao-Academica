using Microsoft.Data.SqlClient;

namespace TransformeseApp2.DAL
{
    public class Conexao
    {
        protected SqlConnection conexao;
        protected SqlCommand command;
        protected SqlDataReader dataReader;

        protected void Conectar()
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; 
                                            Initial Catalog=TransformeseBD; 
                                            Integrated Security = True");
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        protected void Desconectar()
        {
            try
            {
                conexao.Close();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
    }
}
