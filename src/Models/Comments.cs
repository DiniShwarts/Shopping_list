using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMinimalApi.Models
{
    public class Comments
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Comment { get; set; }
    }
}