using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace firstdotnet_razorpages.Model {
    public class Category {
        [Key]
        public int Cateogry_Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(0, 100)]
        public int DisplayOrder { get; set; }
    }
}
