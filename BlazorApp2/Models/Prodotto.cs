using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Models
{
    public class Prodotto
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Il nome è obbligatorio")]
        [StringLength(100, ErrorMessage = "Il nome non può superare 100 caratteri")]
        public string Nome { get; set; } = string.Empty;


        [Range(0, 999999.99, ErrorMessage = "Prezzo non valido")]
        public decimal Prezzo { get; set; }
    }
}
