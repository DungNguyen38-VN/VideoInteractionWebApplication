using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace VideoInteraction.Models
{
    public class CameraAlarmTag
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Camera Alarm Tag")]
        public string TagName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTs { get; set; } = DateTime.Now;
        public DateTime UpdatedTs { get; set; } = DateTime.Now;
        public int CameraId { get; set; }
        [ForeignKey("CameraId")]
        [ValidateNever]
        public Camera Camera { get; set; } 
        public int AlarmMessageId { get; set; }
        [ForeignKey("AlarmMessageId")]
        [ValidateNever]
        public AlarmMessage AlarmMessage { get; set; }
        public int? ShowStringParamId { get; set; }
        [ForeignKey("ShowStringParamId")]
        [ValidateNever]
        public ShowStringParam? ShowStringParam { get; set; }
    }
}
