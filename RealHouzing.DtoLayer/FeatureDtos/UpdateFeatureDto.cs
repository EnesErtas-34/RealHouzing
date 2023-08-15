﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DtoLayer.FeatureDtos
{
    public class UpdateFeatureDto
    {
        public int FeatureID { get; set; }
        public string FeatureTitle { get; set; }
        public string FeatureSubTitle { get; set; }
        public string ImageURL { get; set; }
    }
}
