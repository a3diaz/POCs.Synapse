using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCs.Synapse.Entities;
public class Tax
{
    public TaxCode Code { get; set; }
    public decimal Base { get; set; }
    public CalculatedBy CalculatedBy { get; set; }
    public decimal CalculationReference { get; set; }
    public HoldBy HoldBy { get; set; }
    public decimal Amount
    {
        get
        {
            if (CalculatedBy == CalculatedBy.Rate)
                return Base * (CalculationReference / 100);
            return CalculationReference;
        }
    }

    public Tax(TaxCode taxCode, decimal @base, CalculatedBy calculatedBy, decimal calculationReference, HoldBy holdBy)
    {
        Code = taxCode;
        Base = @base;
        CalculatedBy = calculatedBy;
        CalculationReference = calculationReference;
        HoldBy = holdBy;
    }
}