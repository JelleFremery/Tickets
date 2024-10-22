namespace TicketsV2.DiscountStrategy;

public class BulkOrderDiscount(int threshold, double discountPercentage) : IDiscountStrategy
{
    public double ApplyDiscount(Order order)
    {
        return order.FullPriceAmount >= threshold ? order.TotalAmount * (1 - discountPercentage) : order.TotalAmount;
    }
}