using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperSuper.Models
{
	public class Purcheses
	{

		public int Id { get; set; }

		public Product Product { get; set; }

		public Customer Customer { get; set; }

		public DateTime PurchesDate { get; set; }
	}
}
