namespace DiscountService;

class Program
{
    static void Main(string[] args)
    {
        var product1 = new Product();
        product1.Name = "test1";
        product1.Price = 10.00;
        product1.Discount = new LoyaltyDiscount();
        product1.Discount.ApplyDiscount(product1.Price);

        var product2 = new Product();
        product1.Name = "test2";
        product1.Price = 10.00;
        product1.Discount = new FestiveDiscount();
        product1.Discount.ApplyDiscount(product1.Price);
    }
}

