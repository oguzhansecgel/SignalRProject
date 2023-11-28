﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingalRWebUI.Dtos.DiscountDtos
{
	public class CreateDiscountDto
	{
		public string DiscountTitle { get; set; }
		public string DiscountAmount { get; set; }
		public string DiscountDescription { get; set; }
		public string DiscountImageURL { get; set; }
		public bool Status { get; set; }
	}
}