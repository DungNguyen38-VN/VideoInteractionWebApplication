using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoInteraction.Models.HIK
{
    public class Monitor
    {
        [Key]
        public int OutputId { get; set; }
        public int Index { get; set; }
        public int Pos { get; set; }
        public string MonitorName { get; set; }
        public bool Joint { get; set; }
        public int DlpRow { get; set; }
        public int DlpCol { get; set; }

        [ForeignKey("Dlp")]
        public int DlpId { get; set; }
        public Dlp Dlp { get; set; }
    }

}
