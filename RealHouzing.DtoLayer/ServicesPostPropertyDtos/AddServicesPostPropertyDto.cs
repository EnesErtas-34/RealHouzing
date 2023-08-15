using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DtoLayer.ServicesPostPropertyDtos
{
    public class AddServicesPostPropertyDto
    {
        public int ServicesPostPropertyID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
    }
}
