using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrsEf
{
	public class ProductController
	{
		private PrsDbConnext db = new PrsDbConnext();

		public IEnumerable<Product> List() {
			return db.Products.ToList();
		}

		public Product Get(int? id)
		{
			if (id == null)
				return null;
			return db.Products.Find(id);
		}

		public bool Create(Product product) {
			if (product == null)
				return false;
			db.Products.Add(product);
			db.SaveChanges();
			return true;
		}
		public bool Update(Product product) {
			if (product == null)
				return false;
			Product apro = Get(product.Id);
			if (apro == null)
				return false;
			apro.Name = product.Name;
			apro.PartNumber = product.PartNumber;
			apro.PhotoPath = product.PhotoPath;
			apro.Price = product.Price;
			apro.Unit = product.Unit;
			apro.Vendor = product.Vendor;
			apro.VendorId = product.VendorId;
			db.SaveChanges();
			return true;
		}
		public bool Remove(Product product) {
			if (product == null)
				return false;
			Product apro = Get(product.Id);
			if (apro == null)
				return false;
			db.Products.Remove(product);
			db.SaveChanges();
			return true;
		}
	}
}
