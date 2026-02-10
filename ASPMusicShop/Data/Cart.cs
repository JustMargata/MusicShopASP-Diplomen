using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPMusicShop.Data
{
    public class Cart
    {
        public int Id { get; set; }

        [Required]
        public string ClientId { get; set; }
        
        public Client Clients { get; set; }

        [Required]
        public int ProductId { get; set; }
        
        public Product Products { get; set; }

        [Required]
        public int Quantity { get; set; }
        [Required]
        public DateTime DateOfOrder { get; set; }
    }
}