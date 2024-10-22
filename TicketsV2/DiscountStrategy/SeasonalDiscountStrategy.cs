namespace TicketsV2.DiscountStrategy;

public class SeasonalDiscount(double discountPercentage) : IDiscountStrategy
{
    public double ApplyDiscount(Order order)
    {
        return order.TotalAmount * (1 - discountPercentage);
    }
}