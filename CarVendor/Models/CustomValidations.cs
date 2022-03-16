using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace CarVendor.Models
{
    public class LicensePlateAttribute : ValidationAttribute
    {
        /// <summary>
        /// Returns true if ... is valid.
        /// </summary>
        /// <param name="value">The license plate to validate.</param>
        /// <returns>
        ///   <see langword="true" /> if the specified value is valid; otherwise, <see langword="false" />.
        /// </returns>
        public override bool IsValid(object? value)
        {
            bool isValid = true;
            if (value == null) return isValid;

            // Change case of letters in license plate
            string license = value.ToString().ToUpper();

            // Define list of words that are not allowed in dutch license plates
            List<string> invalidWords = new List<string>();
            invalidWords.Add("SS");
            invalidWords.Add("SD");
            invalidWords.Add("NSB");
            invalidWords.Add("VVD");
            invalidWords.Add("SP");
            invalidWords.Add("GVD");
            invalidWords.Add("KKK");
            invalidWords.Add("TBS");
            invalidWords.Add("PSV");
            invalidWords.Add("LPF");
            invalidWords.Add("FVD");
            invalidWords.Add("LYK");

            // Check format of the license plate
            Regex regex1 = new Regex(@"(([a-zA-Z]{3}[0-9]{3})|(\w{2}-\w{2}-\w{2})|([0-9]{2}-[a-zA-Z]{3}-[0-9]{1})|([0-9]{1}-[a-zA-Z]{3}-[0-9]{2})|([a-zA-Z]{1}-[0-9]{3}-[a-zA-Z]{2}))");
            if (!regex1.IsMatch(license))
            {
                ErrorMessage = "Dit is geen geldig kentekenformaat (sidecode)";
                isValid = false;
            }

            // Check for letter combinations that are not allowed
            invalidWords.ForEach(invalidWord =>
            {
                if (license.Contains(invalidWord))
                {
                    ErrorMessage = $"{invalidWord} niet toegestaan in kenteken";
                    isValid = false;
                }
            });

            // Check for vowels since no vowels are allowed in dutch license plates
            Regex regex2 = new Regex(@"[AEIOU]");
                if(regex2.IsMatch(license))
            {
                ErrorMessage = "Klinkers in kenteken zijn niet toegestaan";
                isValid = false;
            }

            // Return if the license plate is valid or not
            return isValid;
        }
    }
    public class PostalCodeAttribute : ValidationAttribute
    {
        /// <summary>
        /// Returns true if ... is valid.
        /// </summary>
        /// <param name="value">The value of the object to validate.</param>
        /// <returns>
        ///   <see langword="true" /> if the specified value is valid; otherwise, <see langword="false" />.
        /// </returns>
        public override bool IsValid(object? value)
        {
            if (value == null) return true;
            string postcode = (string)value ?? "";
            postcode = postcode.ToUpper();
            /*
            ^ matches beginning of string
            [1-9][0-9]{3} matches a single non-zero digit, and three 0-9 digits
            ? matches 0 or 1 spaces (you could use * to match 0 or more spaces)
            [A-Z]{2} matches 2 captital A-Z characters
            $ matches the end of the string
            i at the end is the case-insensitive modifier
            */
            Regex regex1 = new Regex("^[1-9][0-9]{3} ?[A-Z]{2}$");
            if(!regex1.IsMatch(postcode))
            {
                ErrorMessage = "Ongeldige postcode";
                return false;
            }
            if(postcode.Contains("SS") || postcode.Contains("SD") || 
                postcode.Contains("SA"))
            {
                ErrorMessage = "SS, SD en SA zijn niet toegestaan in postcode";
                return false;
            }
            return true;
        }
    }
}
