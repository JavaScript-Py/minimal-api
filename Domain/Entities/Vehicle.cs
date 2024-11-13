using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinimalAPI.Domain.Entities
{
  public class Vehicle
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } = default!;

    [Required]
    [StringLength(150)]
    public string Name { get; set; } = default!;
    
    [Required]
    [StringLength(50)]
    public string Brand { get; set; } = default!;

    [StringLength(10)]
    public string Year { get; set; } = default!;
  }
}
