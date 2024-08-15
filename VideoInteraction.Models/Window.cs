using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace VideoInteraction.Models
{
    public class Window
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Window Name")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Window ID")]
        public int WndId { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Window URL")]
        public string WndUrl { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedTs { get; set; }= DateTime.Now;
        public DateTime UpdatedTs { get; set; }= DateTime.Now;
    }
}
