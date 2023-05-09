using System;
using System.Linq;

namespace Practice;

public class Loan
{
    public Loan()
    {
        LoanId = Faker.RandomNumber.Next().ToString();
        BorrowerName = Faker.Name.FullName().ToString();
        Address = new PropertyAddress
        {
            City = Faker.Address.City(),
            State = Faker.Address.UsState(),
            StreetAddress = Faker.Address.StreetAddress(),
            Zip = Faker.Address.ZipCode()
        };
    }

    public PropertyAddress Address { get; set; }

    public int? Years { get; set; }

    public string BorrowerName { get; set; } = string.Empty;

    public string LoanId { get; set; } = string.Empty;

    public class PropertyAddress
    {
        public string City { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty;

        public string StreetAddress { get; set; } = string.Empty;

        public string Zip { get; set; } = string.Empty;
    }
}
