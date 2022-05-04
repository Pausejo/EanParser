using ConsoleApp1.Domain.EAN;
using ConsoleApp1.Domain.Products.Base;

namespace ConsoleApp1.Domain.Products;

public class MercaProduct : Product
{
    public MercaProduct(string ean) : base(ean)
    {
    }

    public override Ean ExtractEanData()
    {
        Ean ean = new();

        ean.MercaCode = _ean.Substring(2, 5);

        return ean;
    }
}
