using System.ComponentModel.DataAnnotations;

namespace firstdotnet.Models
{
    public class Category
    {
        [Key]
        public int Cateogry_Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int DisplayOrder { get; set; }
    }
}
