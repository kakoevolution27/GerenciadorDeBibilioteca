using System.Net;
using Npgsql;
using Npgsql.Replication;

public class PostgresManager: DbConnector
{
    const string Host = "postgres_db";
    public PostgresManager(string userName, string password, string database) : base(userName, password)
    {
        this.ConnectionString = $"Host={Host};Username={this.UserName};Password={this.Password};Database={database}";
    }

    //using NpgsqlConnection conn = new NpgsqlConnection(this.ConnectionString);

}