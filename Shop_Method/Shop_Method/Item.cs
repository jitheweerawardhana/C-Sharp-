using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Method
{
    public class Item
    {
        public int ShippingWeight { get; set; }
        public String Description { get; set; }
    }

    public float GetPriceForQuantity(int quantity)
    {
        
        return 20.0f * quantity;
    }

    public float GetTax()
    {
        return 0.1f * GetPriceForQuantity(1);
    }

    public bool InStock()
    {
        
        return true;
    }
}
