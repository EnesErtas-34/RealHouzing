using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.EntityLayer.Concrete
{
    public class MyTeam
    {
        
        public int MyTeamID { get; set; }
        public string NameSurname { get; set; }
        public string Job { get; set; }
        public string ImageURL { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Linkedin { get; set; }
    }
}
