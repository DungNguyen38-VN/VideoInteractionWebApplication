using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoInteraction.Models.HIK
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        public string GroupName { get; set; }

        [ForeignKey("Dlp")]
        public int BelongDlpId { get; set; }
        public Dlp Dlp { get; set; }
    }

}
