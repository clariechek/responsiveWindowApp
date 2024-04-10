using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsiveWindowApp.Model
{
    public partial class Appraisal
    {
        public int WineId { get; set; }
        public string WineName { get; set; }
        public int Vintage { get; set; }
        public string Qty { get; set; }
        public string Bottle { get; set; }
        public int Rsv { get; set; }
        public string Low { get; set; }
        public string High { get; set; }
        public string Origin { get; set; }
        public int Done { get; set; }
        public string Source { get; set; }
        public string Notes { get; set; }
    }
}
