using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MileageCheckTools.Model
{
    public class TotalFile
    {
        public int ID { get; set; }

        public string LineName { get; set; }

        private string _trainCode;

        public string GeoFileName { get; set; }

        public string ResultTableName { get; set; }

        public double TotalLength { get; set; }

        public string TrainCode
        {
            get
            {
                return _trainCode;
            }

            set
            {
                if(value.Contains("-"))
                {
                    value = value.Replace("-", "_");
                }
                _trainCode = value;
            }
        }

        public TotalFile()
        {
            LineName = "";
            TrainCode = "No_Train";
        }
    }
}
