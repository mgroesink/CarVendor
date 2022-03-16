using System.ComponentModel.DataAnnotations;

namespace CarVendor.Models
{
    public class Car
    {
        #region Fields and properties

        /// <summary>
        /// Gets or sets the license plate.
        /// </summary>
        /// <value>
        /// The license plate.
        /// </value>
        [LicensePlate, Key, Display(Name = "Kenteken")]
        public string LicensePlate { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the mark.
        /// </summary>
        /// <value>
        /// The mark.
        /// </value>
        [Display(Name = "Merk")]
        public string Mark { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        [Display(Name = "Type")]
        public string Model { get; set; } = string.Empty;

        #endregion Fields and properties
    }
}