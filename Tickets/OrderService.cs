namespace Tickets;

public class OrderService
{
    public void ProcessOrder(Order order)
    {
        if (order.Customer == null)
        {
            throw new Exception("Customer is required");
        }

        // Basic discount for premium members
        if (order.Customer.IsPremiumMember)
        {
            order.TotalAmount *= 0.9; // 10% discount         
        }

        // Seasonal discount
        order.TotalAmount *= 0.9; //10% discount        

        // Discount for bulk orders
        if (order.TotalAmount >= 50)
        {
            order.TotalAmount *= 0.95; //5% discount            
        }

        Console.WriteLine($"Order processed for {order.Customer}. Total amount: {order.TotalAmount}");









    }
}