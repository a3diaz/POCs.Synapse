using POCs.Synapse.Entities;
using System.Text;

namespace POCs.Synapse.Files.Generate;
public static class Data
{
    private static readonly List<string> Names = new()
    {
        "James"
,
        "Robert"
,
        "John"
,
        "Michael"
,
        "William"
,
        "David"
,
        "Richard"
,
        "Joseph"
,
        "Thomas"
,
        "Charles"
,
        "Christopher"
,
        "Daniel"
,
        "Matthew"
,
        "Anthony"
,
        "Mark"
,
        "Donald"
,
        "Steven"
,
        "Paul"
,
        "Andrew"
,
        "Joshua"
,
        "Kenneth"
,
        "Kevin"
,
        "Brian"
,
        "George"
,
        "Edward"
,
        "Ronald"
,
        "Timothy"
,
        "Jason"
,
        "Jeffrey"
,
        "Ryan"
,
        "Jacob"
,
        "Gary"
,
        "Nicholas"
,
        "Eric"
,
        "Jonathan"
,
        "Stephen"
,
        "Larry"
,
        "Justin"
,
        "Scott"
,
        "Brandon"
,
        "Benjamin"
,
        "Samuel"
,
        "Gregory"
,
        "Frank"
,
        "Alexander"
,
        "Raymond"
,
        "Patrick"
,
        "Jack"
,
        "Dennis"
,
        "Jerry"
,
        "Tyler"
,
        "Aaron"
,
        "Jose"
,
        "Adam"
,
        "Henry"
,
        "Nathan"
,
        "Douglas"
,
        "Zachary"
,
        "Peter"
,
        "Kyle"
,
        "Walter"
,
        "Ethan"
,
        "Jeremy"
,
        "Harold"
,
        "Keith"
,
        "Christian"
,
        "Roger"
,
        "Noah"
,
        "Gerald"
,
        "Carl"
,
        "Terry"
,
        "Sean"
,
        "Austin"
,
        "Arthur"
,
        "Lawrence"
,
        "Jesse"
,
        "Dylan"
,
        "Bryan"
,
        "Joe"
,
        "Jordan"
,
        "Billy"
,
        "Bruce"
,
        "Albert"
,
        "Willie"
,
        "Gabriel"
,
        "Logan"
,
        "Alan"
,
        "Juan"
,
        "Wayne"
,
        "Roy"
,
        "Ralph"
,
        "Randy"
,
        "Eugene"
,
        "Vincent"
,
        "Russell"
,
        "Elijah"
,
        "Louis"
,
        "Bobby"
,
        "Philip"
,
        "Johnny"
,
        "Mary"
,
        "Patricia"
,
        "Jennifer"
,
        "Linda"
,
        "Elizabeth"
,
        "Barbara"
,
        "Susan"
,
        "Jessica"
,
        "Sarah"
,
        "Karen"
,
        "Nancy"
,
        "Lisa"
,
        "Betty"
,
        "Margaret"
,
        "Sandra"
,
        "Ashley"
,
        "Kimberly"
,
        "Emily"
,
        "Donna"
,
        "Michelle"
,
        "Dorothy"
,
        "Carol"
,
        "Amanda"
,
        "Melissa"
,
        "Deborah"
,
        "Stephanie"
,
        "Rebecca"
,
        "Sharon"
,
        "Laura"
,
        "Cynthia"
,
        "Kathleen"
,
        "Amy"
,
        "Shirley"
,
        "Angela"
,
        "Helen"
,
        "Anna"
,
        "Brenda"
,
        "Pamela"
,
        "Nicole"
,
        "Emma"
,
        "Samantha"
,
        "Katherine"
,
        "Christine"
,
        "Debra"
,
        "Rachel"
,
        "Catherine"
,
        "Carolyn"
,
        "Janet"
,
        "Ruth"
,
        "Maria"
,
        "Heather"
,
        "Diane"
,
        "Virginia"
,
        "Julie"
,
        "Joyce"
,
        "Victoria"
,
        "Olivia"
,
        "Kelly"
,
        "Christina"
,
        "Lauren"
,
        "Joan"
,
        "Evelyn"
,
        "Judith"
,
        "Megan"
,
        "Cheryl"
,
        "Andrea"
,
        "Hannah"
,
        "Martha"
,
        "Jacqueline"
,
        "Frances"
,
        "Gloria"
,
        "Ann"
,
        "Teresa"
,
        "Kathryn"
,
        "Sara"
,
        "Janice"
,
        "Jean"
,
        "Alice"
,
        "Madison"
,
        "Doris"
,
        "Abigail"
,
        "Julia"
,
        "Judy"
,
        "Grace"
,
        "Denise"
,
        "Amber"
,
        "Marilyn"
,
        "Beverly"
,
        "Danielle"
,
        "Theresa"
,
        "Sophia"
,
        "Marie"
,
        "Diana"
,
        "Brittany"
,
        "Natalie"
,
        "Isabella"
,
        "Charlotte"
,
        "Rose"
,
        "Alexis"
,
        "Kayla"
    };
    private static readonly List<string> LastNames = new()
    {
        "Smith"
,
        "Johnson"
,
        "Williams"
,
        "Brown"
,
        "Jones"
,
        "Garcia"
,
        "Miller"
,
        "Davis"
,
        "Rodriguez"
,
        "Martinez"
,
        "Hernandez"
,
        "Lopez"
,
        "Gonzales"
,
        "Wilson"
,
        "Anderson"
,
        "Thomas"
,
        "Taylor"
,
        "Moore"
,
        "Jackson"
,
        "Martin"
,
        "Lee"
,
        "Perez"
,
        "Thompson"
,
        "White"
,
        "Harris"
,
        "Sanchez"
,
        "Clark"
,
        "Ramirez"
,
        "Lewis"
,
        "Robinson"
,
        "Walker"
,
        "Young"
,
        "Allen"
,
        "King"
,
        "Wright"
,
        "Scott"
,
        "Torres"
,
        "Nguyen"
,
        "Hill"
,
        "Flores"
,
        "Green"
,
        "Adams"
,
        "Nelson"
,
        "Baker"
,
        "Hall"
,
        "Rivera"
,
        "Campbell"
,
        "Mitchell"
,
        "Carter"
,
        "Roberts"
,
        "Gomez"
,
        "Phillips"
,
        "Evans"
,
        "Turner"
,
        "Diaz"
,
        "Parker"
,
        "Cruz"
,
        "Edwards"
,
        "Collins"
,
        "Reyes"
,
        "Stewart"
,
        "Morris"
,
        "Morales"
,
        "Murphy"
,
        "Cook"
,
        "Rogers"
,
        "Gutierrez"
,
        "Ortiz"
,
        "Morgan"
,
        "Cooper"
,
        "Peterson"
,
        "Bailey"
,
        "Reed"
,
        "Kelly"
,
        "Howard"
,
        "Ramos"
,
        "Kim"
,
        "Cox"
,
        "Ward"
,
        "Richardson"
,
        "Watson"
,
        "Brooks"
,
        "Chavez"
,
        "Wood"
,
        "James"
,
        "Bennet"
,
        "Gray"
,
        "Mendoza"
,
        "Ruiz"
,
        "Hughes"
,
        "Price"
,
        "Alvarez"
,
        "Castillo"
,
        "Sanders"
,
        "Patel"
,
        "Myers"
,
        "Long"
,
        "Ross"
,
        "Foster"
,
        "Jimenez"
    };
    private static readonly List<string> Words = new() { "Lorem", "ipsum", "dolor", "sit", "amet,", "consectetur", "adipiscing", "elit", "Nunc", "tempus,", "ligula", "cursus", "eleifend", "sagittis,", "ex", "ligula", "bibendum", "neque,", "quis", "convallis", "justo", "mi", "sed", "mauris", "Nulla", "maximus,", "sem", "nec", "commodo", "scelerisque,", "tellus", "mauris", "malesuada", "massa,", "eget", "tristique", "lacus", "mauris", "quis", "erat", "Donec", "et", "sem", "elit", "Duis", "sit", "amet", "scelerisque", "ligula", "", "Vestibulum", "ante", "ipsum", "primis", "in", "faucibus", "orci", "luctus", "et", "ultrices", "posuere", "cubilia", "curae;", "Maecenas", "a", "neque", "a", "leo", "finibus", "commodo", "sed", "sed", "sem", "Morbi", "aliquam", "suscipit", "sapien", "at", "tempus", "Sed", "placerat", "velit", "in", "tellus", "vulputate", "suscipit" };
    private static readonly List<string> Letters = new() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
    private static readonly List<string> States = new()
    {  "Alabama"
,"Alaska"
,"Arizona"
,"Arkansas"
,"California"
,"Colorado"
,"Connecticut"
,"Delaware"
,"Florida"
,"Georgia"
,"Hawaii"
,"Idaho"
,"Illinois"
,"Indiana"
,"Iowa"
,"Kansas"
,"Kentucky"
,"Louisiana"
,"Maine"
,"Maryland"
,"Massachusetts"
,"Michigan"
,"Minnesota"
,"Mississippi"
,"Missouri"
,"Montana"
,"Nebraska"
,"Nevada"
,"New Hampshire"
,"New Jersey"
,"New Mexico"
,"New York"
,"North Carolina"
,"North Dakota"
,"Ohio"
,"Oklahoma"
,"Oregon"
,"Pennsylvania"
,"Rhode Island"
,"South Carolina"
,"South Dakota"
,"Tennessee"
,"Texas"
,"Utah"
,"Vermont"
,"Virginia"
,"Washington"
,"West Virginia"
,"Wisconsin"
,"Wyoming"};
    
    public static List<Invoice> GetInvoices(int count, List<Taxpayer> taxpayers)
    { 
        var invoices = new List<Invoice>();
        for (int i = 0; i < count; i++)
        {
            var issuer = GetRandomElement(taxpayers);
            var receiver = GetRandomElement(taxpayers);
            invoices.Add(GetRandomInvoice(issuer, receiver));
        }
            
        return invoices;
    }
    public static List<Taxpayer> GetTaxpayers(int count)
    {
        var taxpayers = new List<Taxpayer>();
        for (int i = 0; i < count; i++)
            taxpayers.Add(GetRandomTaxPayer());

        return taxpayers;
    }
    public static List<Concept> GetConcepts(int count, InvoiceType invoiceType)
    {
        var concepts = new List<Concept>();
        for (int i = 0; i < count; i++)
            concepts.Add(GetRandomConcept(invoiceType));

        return concepts;
    }
    private static Invoice GetRandomInvoice(Taxpayer issuer, Taxpayer receiver)
    {
        var invoiceType = (InvoiceType)Random.Shared.Next(0, 1);
        var issuedTime = GetRandomDate(2000, 2021);
        var issuedAt = GetRandomElement(States);
        var concepts = GetConcepts(Random.Shared.Next(1, 100), invoiceType);
        return new Invoice(Guid.NewGuid(), issuedTime, issuedAt, issuer, receiver, concepts);
    }
    private static Concept GetRandomConcept(InvoiceType invoiceType)
    {
        var descriptionLength = Random.Shared.Next(10, 50);
        var descriptionBuilder = new StringBuilder();
        for (int i = 0; i < descriptionLength; i++)
            descriptionBuilder.Append(GetRandomElement(Words));

        var description = descriptionBuilder.ToString();
        var quantity = Random.Shared.Next(0, 9999) + (decimal)Random.Shared.NextDouble();
        var price = Random.Shared.Next(0, 999) + (decimal)Random.Shared.NextDouble();
        var taxes = GetTaxes(quantity * price, invoiceType);

        return new Concept(description, quantity, price, taxes);
    }
    private static List<Tax> GetTaxes(decimal @base, InvoiceType type)
    {
        return type switch
        {
            InvoiceType.Bill => GetBillTaxes(@base),
            InvoiceType.ProfessionalReceipt => GetProfessionalTaxes(@base),
            _ => throw new Exception()
        };
    }
    private static List<Tax> GetProfessionalTaxes(decimal @base)
    {
        return new List<Tax>
        {
            new Tax( TaxCode.ISR, @base, CalculatedBy.Quota, 10, HoldBy.Receiver),
            new Tax( TaxCode.IVA, @base, CalculatedBy.Quota, 10.6666m, HoldBy.Receiver),
            new Tax( TaxCode.IVA, @base, CalculatedBy.Quota, 16m, HoldBy.Issuer)
        };
    }
    private static List<Tax> GetBillTaxes(decimal @base)
    {
        return new List<Tax>
        {
            new Tax( TaxCode.ISR, @base, CalculatedBy.Quota, 16, HoldBy.Issuer)
        };
    }
    private static Taxpayer GetRandomTaxPayer()
    {
        var name = GetRandomElement(Names);
        var lastName = GetRandomElement(LastNames);
        var birthDate = GetRandomDate(1950, 2000);
        var key = $"{GetRandomElement(Letters)}{Random.Shared.Next(0, 9)}{GetRandomElement(Letters)}";
        var taxpayerId = $"{lastName.Substring(0, 2)}{name.Substring(0, 2)}{birthDate:yyyyddmm}{lastName.Substring(0, 2)}{key}";

        return new Taxpayer(taxpayerId, name, lastName, birthDate);
    }
    private static DateTime GetRandomDate(int minYear, int maxYear)
    {
        return new DateTime(Random.Shared.Next(minYear, maxYear), Random.Shared.Next(1, 12), Random.Shared.Next(1, 28));
    }
    private static T GetRandomElement<T>(List<T> collection)
    {
        return collection[Random.Shared.Next(0, Names.Count)];
    }
}