using ConsoleApp1.Domain.EAN;

namespace ConsoleApp1.Domain.Products.Base;

public abstract class Product
{
    protected readonly string _ean;

    public Product(string ean)
    {
        _ean = ean;
    }

    public abstract Ean ExtractEanData();
}
