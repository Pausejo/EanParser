using ConsoleApp1.Domain.Products.Base;

namespace ConsoleApp1.Domain.Products.Factory;

public class ProductFactory
{
    public static Product Create(string ean, ProductEnum type)
    {
        return type switch
        {
            ProductEnum.MercaProduct => new MercaProduct(ean),
            ProductEnum.WeightProduct => new WeightProduct(ean),
            ProductEnum.BulkProduct => new BulkProduct(ean),
            _ => throw new NotImplementedException("Given type is not valid.")
        };
    }
}

public enum ProductEnum
{
    MercaProduct,
    WeightProduct,
    BulkProduct,
}
