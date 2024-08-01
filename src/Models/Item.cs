using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMinimalApi.Models
{
[Table("Items")]
public class Item

{
    public Item()
    {
        Quantity = 1; 
    }
    [Key]
    public int Id { get; set; }

    [ForeignKey("Category")]
    public int CategoryId { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [Range(1, int.MaxValue)]
    public int Quantity { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}