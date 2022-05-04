using ConsoleApp1.Domain.EAN;
using ConsoleApp1.Domain.Products;
using ConsoleApp1.Domain.Products.Base;
using ConsoleApp1.Domain.Products.Factory;
using NUnit.Framework;
using Shouldly;

namespace TestProject1;

public class ProductsTest
{
    private readonly string mercaProductEan = new("8480000278623");
    private readonly string weightProductEan = new("2369664001999");
    private readonly string bulkProductEan = new("230036490033000165000542");

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Success_Extract_Ean_MercaProduct()
    {
        Product mercaProduct = ProductFactory.Create(mercaProductEan, ProductEnum.MercaProduct);

        Ean ean = mercaProduct.ExtractEanData();

        ean.MercaCode.ShouldBe("80000");

        ean.PriceInEur.ShouldBeNull();

        ean.WeightInKg.ShouldBeNull();
    }

    [Test]
    public void Success_Extract_Ean_WeightProduct()
    {
        Product weightProduct = ProductFactory.Create(weightProductEan, ProductEnum.WeightProduct);

        Ean ean = weightProduct.ExtractEanData();

        ean.MercaCode.ShouldBe("69664");

        ean.PriceInEur.ShouldBe(1.99m);

        ean.WeightInKg.ShouldBeNull();
    }

    [Test]
    public void Success_Extract_Ean_BulkProduct()
    {
        Product bulkProduct = ProductFactory.Create(bulkProductEan, ProductEnum.BulkProduct);

        Ean ean = bulkProduct.ExtractEanData();

        ean.MercaCode.ShouldBe("3649");

        ean.PriceInEur.ShouldBe(0.54m);

        ean.WeightInKg.ShouldBe(0.33m);
    }
}
