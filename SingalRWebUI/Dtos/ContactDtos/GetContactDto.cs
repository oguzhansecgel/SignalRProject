using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingalRWebUI.Dtos.ContactDtos
{
	public class GetContactDto
	{
		public int ContactID { get; set; }
		public string Location { get; set; }
		public string PhoneNumber { get; set; }
		public string MailAdress { get; set; }
		public string FooterDescription { get; set; }
	}
}
