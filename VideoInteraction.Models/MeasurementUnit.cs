using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace VideoInteraction.Models
{
    public class MeasurementUnit
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Unit Name")]
        public string Name { get; set; }
        public DateTime CreatedTs { get; set; }= DateTime.Now;
    }
}
