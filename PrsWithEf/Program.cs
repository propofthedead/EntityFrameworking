using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrsEf;

namespace PrsWithEf
{
	class Program
	{private  static PrsDbConnext db = new PrsDbConnext();
		static void Main(string[] args)
		{

			var hmmm = new PurchaseRequestLineItem {
				ProductId= db.Products.SingleOrDefault(p => p.PartNumber=="Dot").Id,
				PurchasRequestID= db.PurchaseRequests.SingleOrDefault(pr => pr.Description == "I wanted to mess around with alexa to engineer responsive AI").Id,
				Quantity=3,
				Price=3* db.Products.SingleOrDefault(p => p.PartNumber=="Dot").Price,
			};
			var ok = new PurchaseRequestLineItem {
				ProductId = db.Products.SingleOrDefault(p => p.PartNumber == "AU546124").Id,
				PurchasRequestID = db.PurchaseRequests.SingleOrDefault(pr => pr.Description == "I wanted to mess around with alexa to engineer responsive AI").Id,
				Quantity=5,
				Price=5 * db.Products.SingleOrDefault(p => p.PartNumber == "AU546124").Price
			};
			var sure = new PurchaseRequestLineItem {
				ProductId = db.Products.SingleOrDefault(p => p.Name == "Computer").Id,
				PurchasRequestID = db.PurchaseRequests.SingleOrDefault(pr => pr.Description == "New computer").Id,
				Quantity = 7,
				Price = 7 * db.Products.SingleOrDefault(p => p.Name == "Computer").Price
			};
			db.PurchaseRequestLineItems.Add(hmmm);
			db.PurchaseRequestLineItems.Add(ok);
			db.PurchaseRequestLineItems.Add(sure);
			db.SaveChanges();
		}
	}
}
