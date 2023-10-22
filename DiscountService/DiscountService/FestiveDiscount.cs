using System;
namespace DiscountService
{
    public class FestiveDiscount : IDiscount
    {
        public double ApplyDiscount(double originalPrice)
        {
            double discount = originalPrice * 0.10; // example 10% discount
            Console.WriteLine($"Applied FestiveDiscount. Original: {originalPrice}, Discounted: {originalPrice - discount}");
            return originalPrice - discount;
        }
    }
}

