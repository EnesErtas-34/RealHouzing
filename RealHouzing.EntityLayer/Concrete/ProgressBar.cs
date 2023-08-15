using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.EntityLayer.Concrete
{
    public class ProgressBar
    {
        public int ProgressBarID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

    }
}
