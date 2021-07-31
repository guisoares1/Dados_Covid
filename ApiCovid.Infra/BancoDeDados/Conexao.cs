using MySql.Data.MySqlClient;

namespace SysPed.Infra.Dados
{
    public static class Conexao
    {
        public static MySqlConnection ObterConexao()
        {
            var stringConexao = "Server=localhost;Port=3306;Database=dadoscovid;Uid=root;Pwd=1234;SslMode=None;convert zero datetime=True;";
            var mysqlConnection = new MySqlConnection(stringConexao);
            mysqlConnection.Open();
            return mysqlConnection;
        }
        public static void FecharConexao(MySqlConnection mysqlConnection)
        {
            mysqlConnection.Close();
        }
    }
}
