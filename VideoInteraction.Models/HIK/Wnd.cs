using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoInteraction.Models.HIK
{
    public class Wnd
    {
        [Key]
        public int WndId { get; set; }
        public string WndUri { get; set; }
        public int Status { get; set; }
        public int DecodeChannel { get; set; }
        public int VirtualId { get; set; }
        public string Uri { get; set; }
        public bool Zoom { get; set; }
        public int NetZone { get; set; }
        public bool ShowLogo { get; set; }
        public bool Audio { get; set; }
        public int EnableSmartRule { get; set; }
        public int RotateDegree { get; set; }

        [ForeignKey("FloatWnd")]
        public int FloatWndId { get; set; }
        public FloatWnd FloatWnd { get; set; }
    }

}
