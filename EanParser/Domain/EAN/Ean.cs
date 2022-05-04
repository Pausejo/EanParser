namespace ConsoleApp1.Domain.EAN;

public class Ean
{
    private string mercaCode = null!;

    public string MercaCode { 
        get => mercaCode;
        set => mercaCode = Digitify(value);
    }

    public decimal? PriceInEur { get; private set; }

    public decimal? WeightInKg { get; set; }

    private static string Digitify(string digits)
    {
        return int.Parse(digits).ToString();
    }

    public void SetPriceInCents(string priceInCents)
    {
        PriceInEur = decimal.Parse(priceInCents) / 100;
    }

    public void SetWeightInGrams(string weightInGrams)
    {
        WeightInKg = decimal.Parse(weightInGrams) / 1000;
    }
}
