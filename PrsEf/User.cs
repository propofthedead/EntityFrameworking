﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrsEf
{
	public class User
	{
		

		public int? Id { get; set; }
		[Required]
		[StringLength(30)]
		[Index(IsUnique =true)]
		public string Username { get; set; }
		[Required]
		[StringLength(30)]
		public string Password { get; set; }
		[Required]
		[StringLength(30)]
		public string Firstname { get; set; }
		[Required]
		[StringLength(30)]
		public string Lastname { get; set; }
		[Required]
		[StringLength(12)]
		public string Phone { get; set; }
		[Required]
		[StringLength(255)]
		public string Email { get; set; }
		public bool IsReviewer { get; set; }
		public bool IsAdmin { get; set; }
		public bool Active { get; set; }

		public User() { }

		public User(SqlDataReader reader) {
			Id = reader.GetInt32(reader.GetOrdinal("Id"));
			Username = reader.GetString(reader.GetOrdinal("Username"));
			Password = reader.GetString(reader.GetOrdinal("Password"));
			Firstname = reader.GetString(reader.GetOrdinal("Firstname"));
			Lastname = reader.GetString(reader.GetOrdinal("Lastname"));
			Phone = reader.GetString(reader.GetOrdinal("phone"));
			Email = reader.GetString(reader.GetOrdinal("email"));
			IsReviewer = reader.GetBoolean(reader.GetOrdinal("IsReviewer"));
			IsAdmin = reader.GetBoolean(reader.GetOrdinal("IsAdmin"));
			Active = reader.GetBoolean(reader.GetOrdinal("Active"));
		}
		
	}
}
