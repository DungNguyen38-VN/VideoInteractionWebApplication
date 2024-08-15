﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoInteraction.Models;

namespace VideoInteraction.Models.ViewModels
{
    public class MeasurementTagVM
    {
        public MeasurementTag   MeasurementTag { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> CameraList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> MeasurementUnitList { get; set; } 
        [ValidateNever]
        public IEnumerable<SelectListItem> MeasurementPrefixList { get; set; }
    }
}
