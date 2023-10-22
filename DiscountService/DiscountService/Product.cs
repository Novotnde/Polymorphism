using System;
namespace DiscountService
{
	public class Product
	{
		public string Name { get; set; }

        public double Price { get; set; }

		public IDiscount Discount { get; set; }
    }
}

