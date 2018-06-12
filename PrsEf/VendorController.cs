using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrsEf
{
	public class VendorController
	{
		private PrsDbConnext db = new PrsDbConnext();

		public IEnumerable<Vendor> List() {
			return db.Vendors.ToList();
		}

		public Vendor Get(int? id) {
			if (id == null)
				return null;
			return db.Vendors.Find(id);
		}
		public bool Create(Vendor vendor) {
			if (vendor == null)
				return false;
			db.Vendors.Add(vendor);
			db.SaveChanges();
			return true;
		}
		public bool Update(Vendor vendor) {
			if (vendor == null)
				return false;
			Vendor avender = Get(vendor.Id);
			if (avender == null)
				return false;
			avender.Code = vendor.Code;
			avender.City = vendor.City;
			avender.Active = vendor.Active;
			avender.Address = vendor.Address;
			avender.Email = vendor.Email;
			avender.IsPreApproved = vendor.IsPreApproved;
			avender.Name = vendor.Name;
			avender.Phone = vendor.Phone;
			avender.State = vendor.State;
			avender.ZipCode = vendor.ZipCode;
			db.SaveChanges();
			return true;
		}
		public bool Remove(Vendor vendor) {
			if (vendor == null)
				return false;
			Vendor avendor = Get(vendor.Id);
			if (avendor == null)
				return false;
			db.Vendors.Remove(vendor);
			db.SaveChanges();
			return true;
		}
	}
}
