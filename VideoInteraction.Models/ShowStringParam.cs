using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace VideoInteraction.Models
{
    public class ShowStringParam
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Param Set Name")]
        public string Name { get; set; }
        [Required]
        public bool IsShow { get; set; }
        [Required(ErrorMessage = "Please input X-Pos")]
        [Range(-1200, int.MaxValue, ErrorMessage = "X-Pos need to be integer")]
        public int XPos { get; set; }
        [Required(ErrorMessage = "Please input Y-Pos")]
        [Range(-1200, int.MaxValue, ErrorMessage = "Y-Pos need to be integer")]
        public int YPos { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedTs { get; set; }= DateTime.Now;
        public bool IsActive { get; set; }
    }
}
