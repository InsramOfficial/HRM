using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS.Models
{
	[Table("religion")]
	public class Religion
	{
		[Key]
		public int id { get; set; }
		public string Name { get; set; }
	}
}
