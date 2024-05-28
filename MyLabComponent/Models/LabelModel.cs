using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLabComponent.Models
{
    public class LabelModel
    {
        public int Id { get; set; }
        public int ColNr { get; set; }
        public string Description { get; set; }
        public EnumColumns Column { get; set; }
    }
}
