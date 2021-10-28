namespace POCs.Synapse.Entities;
public class Concept
{
    public string Description { get; set; }
    public decimal Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal Amount => Quantity * Price;
    public List<Tax> Taxes { get; set; }

    public Concept(string description, decimal quantity, decimal price, List<Tax> taxes)
    {
        Description = description;
        Quantity = quantity;
        Price = price;
        Taxes = taxes;
    }
}
