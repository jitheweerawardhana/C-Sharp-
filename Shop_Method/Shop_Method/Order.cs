using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Method
{
    public class Order
    {
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public Customer Customer { get; set; }
    }

    public void calcSubTotal()
    {
        float subTotal = 0;
        foreach (var detail in OrderDetails)
        {
            subTotal += detail.CalcSubTotal();
        }
        return subTotal;
    }

    public void calcTax()
    {
        float tax = 0;
        foreach (var detail in OrderDetails)
        {
            tax += detail.CalcTax();
        }
        return tax;
    }
    public void calcTotal()
    {
        eturn CalcSubTotal() +CalcTax();
    }
    public void calcTotalWeight()
    {
        float totalWeight = 0;
        foreach (var detail in OrderDetails)
        {
            totalWeight += detail.CalcWeight();
        }
        return totalWeight;
    }
}
