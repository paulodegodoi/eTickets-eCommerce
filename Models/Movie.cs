using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie
	{
		[Key]
        public int Id { get; set; }

        [Display(Name = "Filme")]
        public string? Name { get; set; }

        [Display(Name = "Descrição")]
        public string? Description { get; set; }

        [Display(Name = "Preço")]
        public double Price { get; set; }

        [Display(Name = "Imagem")]
        public string? ImageURL { get; set; }

        [Display(Name = "Data Inicio")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Data Término")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Gênero")]
        public MovieCategory MovieCategory { get; set; }

        public List<Actor_Movie>? Actors_Movies { get; set; }

        // Cinema
        public int CinemaId { get; set; }

        [ForeignKey("CinemaId")]
        public Cinema? Cinema { get; set; }

		// Producer
		public int ProducerId { get; set; }

		[ForeignKey("ProducerId")]
		public Producer? Producer { get; set; }
	}
}
