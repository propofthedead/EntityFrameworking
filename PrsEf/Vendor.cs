using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrsEf
{
	public class Vendor
	{
		public int Id { get; set; }
		[StringLength(10)]
		[Required]
		[Index(IsUnique =true)]
		public string Code { get; set; }
		[StringLength(30)]
		public string Name { get; set; }
		[StringLength(255)]
		public string Address { get; set; }
		[StringLength(30)]
		public string City { get; set; }
		[StringLength(2)]
		public string State { get; set; }
		[StringLength(5)]
		public string  ZipCode { get; set; }
		[StringLength(12)]
		public string Phone { get; set; }
		[StringLength(255)]
		public string  Email { get; set; }
		public bool IsPreApproved { get; set; }
		public bool Active { get; set; }

		public Vendor() {
		}
		//public Vendor(SqlDataReader reader) {
		//	Id = reader.GetInt32(reader.GetOrdinal("ID"));
		//	Code = reader.GetString(reader.GetOrdinal("code"));
		//	Name = reader.GetString(reader.GetOrdinal("name"));
		//	Address = reader.GetString(reader.GetOrdinal("address"));
		//	City = reader.GetString(reader.GetOrdinal("city"));
		//	State = reader.GetString(reader.GetOrdinal("state"));
		//	ZipCode = reader.GetString(reader.GetOrdinal("zip"));
		//	Phone = reader.GetString(reader.GetOrdinal("phone"));
		//	Email = reader.GetString(reader.GetOrdinal("email"));
		//	IsPreApproved = reader.GetBoolean(reader.GetOrdinal("isPreApproved"));
		//	Active = reader.GetBoolean(reader.GetOrdinal("Active"));

		//}
	}
}
