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

			var peachdot = new PurchaseRequest {
				DeliveryMode = "UPS",
				Description = "I wanted to mess around with alexa to engineer responsive AI",
				Justification = "Yeah",
				UserId = 1,
				User= db.Users.Find(1)
			};

			db.PurchaseRequests.Add(peachdot);
			db.SaveChanges();

			User u1 = db.Users.SingleOrDefault(u => u.Email=="camodude5@yahoo.com");
			u1.IsAdmin = true;
			u1.IsReviewer = true;
			db.SaveChanges();
		}
	}
}
