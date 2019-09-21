using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC.OAuth2Provider.Models
{
	public class UserDB : DbContext
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
	}
}
