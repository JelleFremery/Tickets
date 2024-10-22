namespace TicketsV2.DiscountStrategy;

public interface IDiscountStrategy
{
    double ApplyDiscount(Order order);
}