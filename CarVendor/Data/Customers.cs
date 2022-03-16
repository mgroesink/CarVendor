using CarVendor.Models;

namespace CarVendor.Data
{
    /// <summary>
    /// Customer class
    /// </summary>
    public static class Customers
    {
        /// <summary>
        /// Gets or sets the list of customers.
        /// </summary>
        /// <value>
        /// The list of customers.
        /// </value>
        public static List<Customer> CustomerBase { get; set; } = new List<Customer>()
            {
                new Customer() { PostalCode="7331 TL",Name="Jansen",Address="Troelstrastraat 3",City="Apeldoorn"},
                new Customer() { PostalCode="7491 CG",Name="van Barneveld",Address="Stationsweg 6",City="Delden"},
                new Customer() { PostalCode="7556 BN",Name="Pieters",Address="Bornsestraat 600",City="Hengelo"},
                new Customer() { PostalCode="7514 AD",Name="Fransen",Address="Hengelosestraat 51",City="Enschede"}
            };
    }
}
