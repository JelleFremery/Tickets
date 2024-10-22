namespace TicketsV2;

public class Customer
{
    public string? Name { get; set; }
    public bool IsPremiumMember { get; set; }

    public override string ToString()
    {
        return $"{(IsPremiumMember ? "Premium Customer" : "Customer")}: {Name ?? "unknown"}";
    }
}