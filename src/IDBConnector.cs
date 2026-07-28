public abstract class DbConnector
{
    protected string Password { get; set; }
    protected string UserName { get; set; }
    
    protected string ConnectionString { get; set; }

    public DbConnector(string userName, string password)
    {
        UserName = userName;
        Password = password;
        ConnectionString = "";
    }
    
}