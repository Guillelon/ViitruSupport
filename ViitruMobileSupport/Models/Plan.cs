using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViitruMobileSupport
{
    public class Plan
    {
        public string Name { get; set; }
        public Boolean IsDeleted { get; set; }
        public string Duration { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}