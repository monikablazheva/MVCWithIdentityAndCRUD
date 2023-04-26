using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Food_Monika_v4.Models
{
    public class Food
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(0, 1000, ErrorMessage = "Quantity must be between 0 and 1000.")]
        public int Quantity { get; set; }

        [Range(0, 1000, ErrorMessage = "Price must be between 0 and 1000.")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(6, 2)")]
        public double Price { get; set; }

        public IdentityUser? User { get; set; }
        
    }
}
