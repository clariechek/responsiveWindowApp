using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsiveWindowApp.Model
{
    public partial class Consignment
    {
        public int Number { get; set; }
        public string Value { get; set; }
        public string DateReceived { get; set; }
        public string InitialAuction { get; set; }
        public int Boxes { get; set; }
        public string Insurance { get; set; }
        public string Conv { get; set; }
    }
}
