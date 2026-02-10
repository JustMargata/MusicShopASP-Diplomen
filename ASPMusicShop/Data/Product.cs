using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPMusicShop.Data
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Barcode { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Model { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public Category Categories { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public DateTime LastEditedOn { get; set; }
        public ICollection<Cart> Carts { get; set; }
    }
}
