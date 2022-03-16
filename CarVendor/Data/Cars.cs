using CarVendor.Models;

namespace CarVendor.Data
{
    /// <summary>
    /// Car class
    /// </summary>
    public static class Cars
    {
        /// <summary>
        /// Gets or sets the list of cars.
        /// </summary>
        /// <value>
        /// The list of cars.
        /// </value>
        public static List<Car> Stock { get; set; } = new List<Car>()
        {
            new Car() { LicensePlate="40-PRR-1",Mark="Opel",Model="Corsa"},
            new Car() { LicensePlate="40-GHH-2",Mark="Volkswagen",Model="Passat"},
            new Car() { LicensePlate="4-VLF-86",Mark="Ford",Model="Transit"},
            new Car() { LicensePlate="H-973-BT",Mark="Hyundai",Model="I30"}
        };
    }
}