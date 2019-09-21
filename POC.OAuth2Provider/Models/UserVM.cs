using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC.OAuth2Provider.Models
{
	public class UserVM
	{
		public string UserName { get; set; }
		public string Password { get; set; }
		public string response_type { get; set; }
		public string client_id { get; set; }
		public string redirect_uri { get; set; }
		public string state { get; set; }
	}
}
