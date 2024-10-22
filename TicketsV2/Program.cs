using TicketsV2;
using TicketsV2.DiscountStrategy;

Console.WriteLine("Enter name...");
var name = Console.ReadLine();

Console.WriteLine("Is the customer a premium member? (y/n)");
bool isPremiumMember = Console.ReadLine()?.ToLower() == "y";

Console.WriteLine("Enter total amount of the order...");
var totalAmount = double.Parse(Console.ReadLine() ?? "0");

var customer = new Customer { Name = name, IsPremiumMember = isPremiumMember };
var order = new Order(customer, totalAmount);

var discountStrategies = new List<IDiscountStrategy>
{
    new PremiumMemberDiscount(),
    new SeasonalDiscount(0.1),
    new BulkOrderDiscount(50, 0.05)
};

var orderService = new OrderService(discountStrategies);
orderService.ProcessOrder(order);

Console.ReadKey();
