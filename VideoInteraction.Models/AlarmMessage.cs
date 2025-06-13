using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoInteraction.Models
{
    public class AlarmMessage
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        [DisplayName("Alarm Name")]
        public string Name { get; set; } 
        [MaxLength(50)]
        [DisplayName("Alarm Message")]
        public string? AlarmText { get; set; }
        public DateTime CreatedTs { get; set; } = DateTime.Now;
    }
}
