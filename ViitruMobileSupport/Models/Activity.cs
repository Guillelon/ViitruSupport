using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViitruMobileSupport.Models
{
    public class Activity
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Difficulty { get; set; }
        public int Sequence { get; set; }
        public int Week { get; set; }
        public Boolean IsDeleted { get; set; }
        public int CaloricRequirementMin { get; set; }
        public int CaloricRequirementMax { get; set; }
        public int PlanId { get; set; }
    }
}