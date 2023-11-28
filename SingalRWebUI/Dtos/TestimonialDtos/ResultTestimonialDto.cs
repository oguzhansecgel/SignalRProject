﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingalRWebUI.Dtos.TestimonialDtos
{
	public class ResultTestimonialDto
	{
		public int TestimonialID { get; set; }
		public string TestimonialName { get; set; }
		public string Title { get; set; }
		public string Comment { get; set; }
		public string ImageURL { get; set; }
		public bool Status { get; set; }
	}
}
