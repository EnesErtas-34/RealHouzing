﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.EntityLayer.Concrete
{
    public class AboutFeature
    {
        public int AboutFeatureID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string Features { get; set; }
        public string? ImageURL { get; set; }

    }
}
