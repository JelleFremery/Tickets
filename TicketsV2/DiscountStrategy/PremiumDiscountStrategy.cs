namespace TicketsV2.DiscountStrategy;

public class PremiumMemberDiscount : IDiscountStrategy
{
    public double ApplyDiscount(Order order)
    {
        if (order?.Customer == null)
        {
            throw new ArgumentException("Order invalid", nameof(order));
        }

        return order.Customer.IsPremiumMember ? order.TotalAmount * 0.9 : order.TotalAmount;
    }
}