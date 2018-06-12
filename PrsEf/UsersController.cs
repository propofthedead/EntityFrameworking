using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrsEf
{
	public class UsersController
	{
		private PrsDbConnext db = new PrsDbConnext();

		public IEnumerable<User> List() {
			return db.Users.ToList();
		}

		public User get(int? id) {
			if (id == null) { return null; }
			return db.Users.Find(id);
		}

		public bool Create(User user) {
			if (user == null) {
				return false;
			}
			db.Users.Add(user);
			db.SaveChanges();
			return true;

		}

		public bool Change(User user) {
			if (user == null)
				return false;
			User auser = get(user.Id);
			if (auser == null)
				return false;
			auser.Username = user.Username;
			auser.Password = user.Password;
			auser.Firstname = user.Firstname;
			auser.Lastname = user.Lastname;
			auser.Phone = user.Phone;
			auser.Email = user.Email;
			auser.IsReviewer = user.IsReviewer;
			auser.IsAdmin = user.IsAdmin;
			auser.Active = user.Active;
			db.SaveChanges();
			return true;
		}
		public bool Remove(User user)
		{
			if (user == null)
				return false;
			User auser = get(user.Id);
			if (auser == null)
				return false;
			db.Users.Remove(user);
			db.SaveChanges();
			return true;
		}
	}
}
