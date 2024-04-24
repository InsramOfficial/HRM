﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS.Models
{
	[Table("country")]
	public class Country
	{
		[Key]
		public int id { get; set; }
		public string ?Name { get; set; }
	
		//public DateOnly updated_on { get; set; }

	}
}
