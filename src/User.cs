
public class User
{
    public int UserId;
    public string? UserName;

    public BrazilAdressInfo AdressInfo;
    public List<int>? HoldingItemsId;

    public User(string userName, BrazilAdressInfo adressInfo)
    {
        UserName = userName;
        AdressInfo = adressInfo;
    }
}