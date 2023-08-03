using MySql.Data.MySqlClient;

namespace ApiAtividade1.DAO
{
    public class ConnectionFactory
    {
        public static MySqlConnection Build()
        {
            var connectionString = "Server=localhost;Database=ATIVIDADEPW;Uid=root;Pwd=root;";
            return new MySqlConnection(connectionString);
        }
    }
}
