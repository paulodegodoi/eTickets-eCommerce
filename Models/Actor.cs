using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
	public class Actor
	{
        [Key]
        public int Id { get; set; }

        [Display(Name = "Foto")]
        public string? ProfilePictureURL { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome do ator é obrigatório.")]
        public string? FullName { get; set; }

        [Display(Name = "Biografia")]
        public string? Bio { get; set; }

        public List<Actor_Movie>? Actors_Movies { get; set;}
    }
}
