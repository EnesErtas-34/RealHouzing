using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DtoLayer.CoLivingDtos
{
    public class UpdateCoLivingDto
    {
        public int CoLivingID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageURL1 { get; set; }
        public string ImageURL2 { get; set; }
    }
}
