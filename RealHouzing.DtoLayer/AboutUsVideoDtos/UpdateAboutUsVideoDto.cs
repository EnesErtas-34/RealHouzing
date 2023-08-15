using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DtoLayer.AboutUsVideoDtos
{
    public class UpdateAboutUsVideoDto
    {
        public int AboutUsVideoID { get; set; }
        public string VideoURL { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
