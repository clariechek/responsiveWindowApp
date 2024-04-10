using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsiveWindowApp.Model
{
    public partial class Estimate
    {
        public int EstimateNumber { get; set; }
        public string Value { get; set; }
        public int Bottles { get; set; }
        public string Shipping { get; set; }
        public string Sub { get; set; }
        public int EstimateBoxes { get; set; }
        public string Date { get; set; }
        public string Conv { get; set; }


    }
}
