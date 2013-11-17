using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace TreeListView
{
    public class Topic
    {
        private static int ratio = 100;

        private double outstandSell = 25;
        private double outstandBuy = 75;
        private double delta = 20;
        private double notional = 26;

        private double outstandSellLevel = 50;
        private double outstandBuyLevel = 100;
        private double deltaLevel = 22;
        private double notionalLevel = 20;

        public string Name { get; set; }
        public string Delta { get; set; }
        public string Notional { get; set; }
        public string OutstandBuy { get; set; }
        public string OutstandSell { get; set; }

        public double OutstandSellLimitState { get { return Percentage(outstandSell, outstandSellLevel); } }
        public double OutstandBuyLimitState { get { return Percentage(outstandBuy, outstandBuyLevel); } }
        public double DeltaLimitState { get { return Percentage(delta, deltaLevel); } }
        public double NotionalLimitState { get { return Percentage(notional, notionalLevel); } }

        private ObservableCollection<Topic> childTopics = new ObservableCollection<Topic>();
        public ObservableCollection<Topic> ChildTopics { get { return childTopics; } set { childTopics = value; } }

        public Topic(){}

        public Topic(string name ,string delta , string notional, string outstandbuy, string outstandSell )
        {
            this.Name = name;
            this.Delta = delta;
            this.Notional = notional;
            this.OutstandBuy = outstandbuy;
            this.OutstandSell = outstandSell;
        }



        private static double Percentage(double top, double bottom)
        {
            return (Math.Abs(top / bottom) * ratio);
        }
    }
}
