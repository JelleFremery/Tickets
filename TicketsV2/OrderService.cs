using TicketsV2.DiscountStrategy;

namespace TicketsV2;

public class OrderService(IEnumerable<IDiscountStrategy> discountStrategies)
{
    public void ProcessOrder(Order order)
    {
        if (order.Customer == null)
        {
            throw new ArgumentException("Customer is required", nameof(order));
        }

        foreach (var strategy in discountStrategies)
        {
            order.TotalAmount = strategy.ApplyDiscount(order);
        }

        Console.WriteLine($"Order processed. {order}");
    }
}
