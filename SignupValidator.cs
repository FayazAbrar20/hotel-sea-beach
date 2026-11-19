using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace hotelseabeach
{
    /// <summary>
    /// Checks every signup field and returns a list of problems (empty when valid).
    /// Kept separate from the form so the rules are easy to read and test.
    /// </summary>
    internal static class SignupValidator
    {
        private static readonly Regex UsernameRule = new Regex(@"^[A-Za-z][A-Za-z0-9_]{3,19}$");
        private static readonly Regex EmailRule = new Regex(@"^[^@\s]+@[^@\s]+\.[A-Za-z]{2,}$");
        // Bangladeshi mobile: 01 + operator digit 3-9 + 8 digits, optionally starting with +88 or 88.
        private static readonly Regex MobileRule = new Regex(@"^(\+?88)?01[3-9]\d{8}$");

        public const int MinimumAge = 18;

        public static List<string> Validate(string role, string username, string password, string email,
                                            string mobile, DateTime dateOfBirth, string gender, string address,
                                            DateTime today)
        {
            var errors = new List<string>();

            if (role != "Employee" && role != "Customer" && role != "Manager")
                errors.Add("Choose a role.");

            if (!UsernameRule.IsMatch(username ?? ""))
                errors.Add("Username: 4-20 characters, start with a letter, then letters, numbers or _ only.");

            if (string.IsNullOrEmpty(password) || password.Length < 8 ||
                !Regex.IsMatch(password, "[A-Za-z]") || !Regex.IsMatch(password, "[0-9]"))
                errors.Add("Password: at least 8 characters, with at least one letter and one number.");
            else if (!string.IsNullOrEmpty(username) &&
                     password.IndexOf(username, StringComparison.OrdinalIgnoreCase) >= 0)
                errors.Add("Password must not contain the username.");

            if (!EmailRule.IsMatch(email ?? ""))
                errors.Add("Email: enter a valid address, like name@example.com.");

            string digits = (mobile ?? "").Replace(" ", "").Replace("-", "");
            if (!MobileRule.IsMatch(digits))
                errors.Add("Mobile: enter a Bangladeshi number, like 01712345678.");

            if (dateOfBirth.Date > today.Date)
                errors.Add("Date of birth cannot be in the future.");
            else if (AgeOn(dateOfBirth, today) < MinimumAge)
                errors.Add("You must be at least " + MinimumAge + " years old to register.");

            if (gender != "Male" && gender != "Female" && gender != "Other")
                errors.Add("Choose a gender.");

            if ((address ?? "").Trim().Length < 5)
                errors.Add("Address: enter at least 5 characters.");

            return errors;
        }

        public static int AgeOn(DateTime dateOfBirth, DateTime today)
        {
            int age = today.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > today.AddYears(-age).Date) age--;
            return age;
        }
    }
}
