using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Research.DynamicDataDisplay.Common;

namespace DynamicGraph.ViewModel
{
    public class GraphPointCollection : RingArray <GraphPoint>
    {
        private const int TOTAL_POINTS = 300;

        public GraphPointCollection()
            : base(TOTAL_POINTS) // here i set how much values to show 
        {    
        }
    }

    public class GraphPoint
    {        
        public DateTime Date { get; set; }
        public double Value { get; set; }

        public GraphPoint(double value, DateTime date)
        {
            this.Date = date;
            this.Value = value;
        }
    }
}
