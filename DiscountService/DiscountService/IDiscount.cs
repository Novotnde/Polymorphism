using System;
namespace DiscountService
{
	public interface IDiscount
	{
        double ApplyDiscount(double originalPrice);
    }
}

