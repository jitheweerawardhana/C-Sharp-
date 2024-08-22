using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Method
{
    public class Order_Details
    {
        public int Quantity { get; set; }
        public string TaxStatus { get; set; }
        public Item Item { get; set; }

    }

    public float CalcSubTotal()
    {
        return Item.GetPriceForQuantity(Quantity);
    }

    public float CalcWeight()
    {
        return Item.ShippingWeight * Quantity;
    }

    public float CalcTax()
    {
        return CalcSubTotal() * (TaxStatus == "Taxable" ? 0.1f : 0);
    }
}
