using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingalRWebUI.Dtos.AboutDtos
{
	public class UpdateAboutDto
	{
		public int AboutID { get; set; }
		public string ImageURL { get; set; }
		public string AboutTitle { get; set; }
		public string AboutDescription { get; set; }
	}
}
