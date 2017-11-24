using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MileageCheckTools.Model
{
    public class JumpPoints
    {
        public int ID { get; set; }
        public double CurrentMileage { get; set; }
        public double CurrentSample { get; set; }
        public double LastMileage { get; set; }
        public double LastSample { get; set; }
        public double DiffSample { get; set; }
        public double DiffMileage { get; set; }
    }
}
