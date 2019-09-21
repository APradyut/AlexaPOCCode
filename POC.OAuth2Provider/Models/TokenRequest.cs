using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC.OAuth2Provider.Models
{
	public class TokenRequest
	{
		public string grant_type { get; set; }
		public string code { get; set; }
		public string redirect_uri { get; set; }
	}
}
