using System.ComponentModel.DataAnnotations;

namespace firstdotnet.Models.Models {
    public class Product {
        public int Id { get; set; }
        [Required]
        public required string Title { get; set; }
        [Required]

        public required string Description { get; set; }
        [Required]

        public string Author { get; set; }
        public string ISBN { get; set; }


    }
}
