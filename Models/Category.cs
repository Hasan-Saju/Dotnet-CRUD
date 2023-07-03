using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        // prop to create property
        [Required]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Required]
        [Range(1, int.MaxValue, ErrorMessage ="Display Order for category must be gretaer than 0")]
        public int DisplayOrder { get; set; }
    }
    
}