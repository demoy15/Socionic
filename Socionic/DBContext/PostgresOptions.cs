using Npgsql;

namespace Socionic.DBContext;

public class PostgresOptions
{
    public virtual string ConnectionString
    {
        get
        {
            var connection = new NpgsqlConnectionStringBuilder();
            connection.Database = "socionic";
            connection.Port = 5432;
            connection.Username = "postgres";
            connection.Password = "Qazxsw1.";
            connection.Host = "localhost";
            connection.Pooling = true;
            connection.SslMode = SslMode.Disable;
            return connection.ToString();
        }
    }
}