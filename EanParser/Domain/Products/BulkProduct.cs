using ConsoleApp1.Domain.EAN;
using ConsoleApp1.Domain.Products.Base;

namespace ConsoleApp1.Domain.Products;

public class BulkProduct : Product
{
    public BulkProduct(string ean) : base(ean)
    {
    }

    public override Ean ExtractEanData()
    {
        Ean ean = new();

        ean.MercaCode = _ean.Substring(3, 5);

        ean.SetWeightInGrams(_ean.Substring(8, 5));

        ean.SetPriceInCents(_ean.Substring(18, 5));

        return ean;
    }
}
