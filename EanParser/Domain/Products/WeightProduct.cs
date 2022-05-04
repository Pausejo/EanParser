using ConsoleApp1.Domain.EAN;
using ConsoleApp1.Domain.Products.Base;

namespace ConsoleApp1.Domain.Products;

public class WeightProduct : Product
{
    public WeightProduct(string ean) : base(ean)
    {
    }

    public override Ean ExtractEanData()
    {
        Ean ean = new();

        ean.MercaCode = _ean.Substring(2, 5);
        ean.SetPriceInCents(_ean.Substring(7, 5));

        return ean;
    }
}
