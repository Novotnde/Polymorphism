using System;
namespace DiscountService
{
	public class LoyaltyDiscount : IDiscount
    {
        public double ApplyDiscount(double originalPrice)
        {
            double discount = originalPrice * 0.05; // example 5% discount
            Console.WriteLine($"Applied LoyaltyDiscount. Original: {originalPrice}, Discounted: {originalPrice - discount}");
            return originalPrice - discount;
        }

        void IDiscount.ApplyDiscount(double originalPrice)
        {
            throw new NotImplementedException();
        }
    }
}

