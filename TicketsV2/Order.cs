using System.Diagnostics;

namespace TicketsV2;

public class Order
{
    public Customer Customer { get; set; }
    public double FullPriceAmount { get; private set; }
    public double TotalAmount { get; set; }

    public Order(Customer customer, double fullPriceAmount)
    {
        Customer = customer;
        FullPriceAmount = fullPriceAmount;
        TotalAmount = fullPriceAmount;
    }

    public override string ToString()
    {
        return $"{Customer}. Full price amount: {FullPriceAmount}. Total amount: {TotalAmount}.";
    }
}