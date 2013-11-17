using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticGraph
{
    public class DataModel
    {
        public DateTime Date { get; set; }
        public int Value { get; set; }

        public DataModel(DateTime date, int numberOpen)
        {
            this.Date = date; 
            this.Value = numberOpen; 
        }
    }
}
