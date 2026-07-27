using System.Text.RegularExpressions;

public interface IAdressInfo
{
    int PostalCode { get; set; }
    string StreetName { get; set; }
    int HouseNumber { get; set; }

    string CityNeighborhood { get; set; }

    public void SetPostalCodeFormat(string PostalCode);
    
}

public struct BrazilAdressInfo : IAdressInfo
{
    public int PostalCode { get; set; }
    public string CepCode { get; set; }
    public string StreetName { get; set; }
    public int HouseNumber { get; set; }
    public string CityNeighborhood { get; set; }

    public void SetPostalCodeFormat(string formattedPostalCode)
    {
        string BrazilianCepPattern = @"^\d{5}-\d{3}$";
        if (Regex.IsMatch(formattedPostalCode, BrazilianCepPattern))
        {
            CepCode = formattedPostalCode;
        }
        else
        {
            CepCode = "";
            throw new FormatException("FORMATO DE CEP INVALIDO, CEP DEFINIDO COMO NULL");
        }
    }
}