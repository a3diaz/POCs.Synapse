namespace POCs.Synapse.Entities;
public class Invoice
{
    public Guid Id { get; set; }
    public DateTime IssuedTime { get; set; }
    public string IssuedAt { get; set; }
    public decimal Total => Concepts.Sum(c => c.Amount);
    public decimal TranslatedTaxes => Concepts.Sum(c => c.Taxes.Where(t => t.HoldBy == HoldBy.Issuer).Sum(t => t.Amount));
    public decimal RetainedTaxes => Concepts.Sum(c => c.Taxes.Where(t => t.HoldBy == HoldBy.Receiver).Sum(t => t.Amount));
    public decimal TotalTaxes => Concepts.Sum(c => c.Taxes.Sum(c => c.Amount)); 
    public decimal GrandTotal => Total + TotalTaxes;
    public List<Concept> Concepts { get; set; }

    public Taxpayer Issuer { get; set; }
    public Taxpayer Receiver { get; set; }

    public Invoice(Guid id, DateTime issuedTime, string issuedAt, Taxpayer issuer, Taxpayer receiver, List<Concept> concepts)
    {
        Id = id;
        IssuedTime = issuedTime;
        IssuedAt = issuedAt;
        Issuer = issuer;
        Receiver = receiver;
        Concepts = concepts;
    }
}