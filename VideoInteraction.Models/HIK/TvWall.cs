using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace VideoInteraction.Models.HIK
{
    public class TvWall
    {
        [Key]
        public int TvWallId { get; set; }
        public string TvWallName { get; set; }
        public string IndexCode { get; set; }

        public ICollection<Dlp> Dlps { get; set; }
    }

}
