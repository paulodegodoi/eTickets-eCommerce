using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
	public class Producer
	{
		[Key]
		public int Id { get; set; }

		[Display(Name = "Foto")]
		public string? ProfilePictureURL { get; set; }

		[Display(Name = "Nome")]
		public string? FullName { get; set; }

		[Display(Name = "Biografia")]
		public string? Bio { get; set; }

		public List<Movie>? Movies { get; set; }
	}
}
