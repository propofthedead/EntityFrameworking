using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrsEf
{
	public class PurchaseRequestLineItem
	{
		public int Id { get; set; }
		[Required]
		public int PurchasRequestID { get; set; }
		public int ProductId { get; set; }
		public virtual Product Product { get; set; }
		[Required]
		public int Quantity { get; set; }
		[Required]
		public double Price { get; set; }

		public PurchaseRequestLineItem() { }
	}
}
