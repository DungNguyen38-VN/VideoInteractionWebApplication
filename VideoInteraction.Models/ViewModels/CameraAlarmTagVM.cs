using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoInteraction.Models;

namespace VideoInteraction.Models.ViewModels
{
    public class CameraAlarmTagVM
    {
        public CameraAlarmTag  CameraAlarmTag { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> CameraList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> AlarmMessageList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> ShowStringParamList { get; set; }     

    }
}
