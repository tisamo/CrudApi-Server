using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudApi.Controllers.Models
{
    public class TreeModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="varchar(20)")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "tinyint")]
        public int Age { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Image { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Climate{ get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Description { get; set; }
    }
}