using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DtoLayer.AboutFeatureDtos
{
    public class AddAboutFeatureDto
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string Features { get; set; }
        public string? ImageURL { get; set; }
    }
}
