using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoInteraction.Models
{
    public class Camera
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Camera Name")]
        public string Name { get; set; }
        [MaxLength(50)]
        [DisplayName("Camera Code")]
        public string CameraCode { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedTs { get; set; }= DateTime.Now;
        [Required(ErrorMessage = "Please input L1 Control Id")]
        [Range(1, int.MaxValue, ErrorMessage = "L1ControlId need to be integer")]
        public int L1ControlId { get; set; }
        public string CameraIp { get; set; }
        public int? ShowStringParamId { get; set; }
        [ForeignKey("ShowStringParamId")]
        [ValidateNever]
        public ShowStringParam? ShowStringParam { get; set; }
    }
}
