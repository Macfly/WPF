using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Akuna.PriceMonitor.Model
{
    class Order
    {
        const bool bid = true;
        const bool ask = false;
        public double Price { get; set; }
        public enum SideType { bid, ask };

        public SideType Side { get; set; }

        public int Quantity { get; set; }

        public Order(string price,string quantity, bool orderSide )
        {
            Price = double.Parse(price);
            Quantity = int.Parse(quantity);

            if (orderSide == bid)
                Side = SideType.bid;
            else
                Side = SideType.ask;
        }
    }
}
