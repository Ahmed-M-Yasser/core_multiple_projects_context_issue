using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ClassLibrary1.Models
{
	public class Segment
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		/// <summary>
		/// json field
		/// </summary>
		[Required]
		[Column(TypeName = "nvarchar(max)")]
		public string Name { get; set; }
	}
}
