using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DtoLayer.ExploreDtos
{
    public class UpdateExploreDto
    {
        public int ExploreID { get; set; }
        public string ExploreName { get; set; }
        public string Icon { get; set; }
        public string ImageURL { get; set; }
    }
}
