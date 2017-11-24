using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MileageCheckTools
{
    public class ChartConfig
    {
        public string ChartTitle { get; set; }
        public Font ChartTitleFont { get; set; }

        public string AxesYTitle { get; set; }
        public Font AxesYFont { get; set; }
        public double AxesYMax { get; set; }
        public double AxesYMin { get; set; }
        public double AxesYStep { get; set; }

        public string AxesXTitle { get; set; }
        public Font AxesXFont { get; set; }
        public double AxesXMax { get; set; }
        public double AxesXMin { get; set; }
        public double AxesXStep { get; set; }

        public ChartConfig()
        {
            ChartTitleFont = new Font("Arial", 16, FontStyle.Bold);
            AxesXFont = new Font("Arial", 10, FontStyle.Bold);
            AxesYFont = new Font("Arial", 10, FontStyle.Bold);
        }
    }
}
