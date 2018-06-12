using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrsEf;

namespace PrsWithEf
{
	class Program
	{

		void LingExamples() {
			int[] nrbs = {7,7,14,13,1,
						11,12,3,20,10,
						1,10,18,17,14,
						15,6,14,20,13};
			var total = nrbs.Sum();
			total = nrbs.Where(i => i >= 10).Sum();
			total = nrbs.Where(i => i % 2 == 1).Sum();
			var sortedNrbs = nrbs.OrderBy(i => i);
			sortedNrbs = nrbs.OrderByDescending(i => i);

			var subset = nrbs.Where(i => i % 3 == 0).ToArray();
			var subset2 = nrbs.Where(i => i % 3 == 0).ToList();

		}



		private  static PrsDbConnext db = new PrsDbConnext();
		static void Main(string[] args)
		{

			var hmmm = new PurchaseRequestLineItem {
				ProductId= db.Products.SingleOrDefault(p=> p.Name=="Computer").Id,
				PurchasRequestID=db.PurchaseRequests.SingleOrDefault(pr=> pr.Description=="New computer").Id,
				Quantity=9,
				Price=9 * db.Products.SingleOrDefault(p=> p.Name=="Computer").Price

			};
			db.PurchaseRequestLineItems.Add(hmmm);
			db.SaveChanges();
		}
	}
}
