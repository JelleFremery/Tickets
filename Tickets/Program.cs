using Tickets;

Console.WriteLine("Enter name...");
var name = Console.ReadLine();

Console.WriteLine("Is the customer a premium member? (y/n)");
bool isPremiumMember = Console.ReadLine()?.ToLower() == "y";

Console.WriteLine("Enter total amount of the order...");
var totalAmount = double.Parse(Console.ReadLine() ?? "0");

var customer = new Customer { Name = name, IsPremiumMember = isPremiumMember };
var order = new Order { Customer = customer, TotalAmount = totalAmount };

var orderService = new OrderService();
orderService.ProcessOrder(order);

Console.ReadKey();