using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperSuper.Models
{
	public class Customer
	{
		public int Id { get; set; }

		public int UserName { get; set; }

		public string Address { get; set; }

		public string EmailAdress { get; set; }

		//[Required(ErrorMessage = "please provide password")]
		//[DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
		public string Password { get; set; }
	}
}
