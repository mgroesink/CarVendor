using System.ComponentModel.DataAnnotations;

namespace CarVendor.Models
{
    public class Customer
    {
        #region Fields and properties

        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        /// <value>
        /// The customer identifier.
        /// </value>
        [Display(Name = "Klantnummer")]
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Display(Name = "Naam")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        [Display(Name = "Adres")]
        public string Address { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        [Display(Name = "Woonplaats")]
        public string City { get; set; } = string.Empty;

        /// <summary>
        /// The postal code
        /// </summary>
        private string? _postalCode;

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        /// <value>
        /// The postal code.
        /// </value>
        [Display(Name = "Postcode"),PostalCode]
        public string PostalCode { get => _postalCode ?? ""; set => _postalCode = value.ToUpper(); }

        public ICollection<Car> Cars { get; set; }
        #endregion Fields and properties

    }
}