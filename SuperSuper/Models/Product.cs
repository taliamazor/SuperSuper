using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperSuper.Models
{
	public class Product
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public enum Category
		{
			Dairy,
			Vegetables,
			Fruits,
			Drinks,
			Toiltries,
			Snacks,
			Frozen,
			Cupboard
		}

		public double Price { get; set; }

		public bool Fat { get; set; }

		public string Supplier { get; set; }

	}
}
