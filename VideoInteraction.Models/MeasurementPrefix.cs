using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace VideoInteraction.Models
{
    public class MeasurementPrefix
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Prefix Name")]
        public string Name { get; set; }
        public DateTime CreatedTs { get; set; }= DateTime.Now;
    }
}
