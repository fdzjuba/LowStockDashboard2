using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LowStockDashboard.Models
{
    public class StockLevelItem
    {
        public string SKU;
        public string ProductTitle;
        public int OnOrder;
        public int Due;
        public int StockLevel;
        public string Location;
    }
}