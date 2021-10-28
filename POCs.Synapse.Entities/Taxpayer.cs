using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCs.Synapse.Entities;
public class Taxpayer
{
    public string TaxpayerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }

    public Taxpayer(string taxpayerId, string firstName, string lastName, DateTime birthDate)
    {
        TaxpayerId = taxpayerId;
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
    }
}
