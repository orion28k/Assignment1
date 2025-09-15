using System.Runtime.CompilerServices;

namespace ClassLibrary1;
public class Class1
{
    /// <summary>
    /// Checks whether a password is valid by ensuring it meets a minimum length
    /// and contains at least one digit, one uppercase letter, and one symbol.
    /// </summary>
    /// <param name="password">
    /// The password string to validate.
    /// </param>
    /// <returns>
    /// True if the password meets the criteria (length, digit, uppercase);
    /// otherwise, false.
    /// </returns>
    public static string passCheck(string password)
    {
        int grade = 0;

        if (password.Any(char.IsUpper))
            grade++;
        if (password.Any(char.IsLower))
            grade++;
        if (password.Any(char.IsDigit))
            grade++;
        if (password.Any(char.IsSymbol))
            grade++;
        if (password.Length > 8)
            return "Password must be at least 8 characters long";

        switch (grade)
        {
            case 0:
                return "INELIGABLE";
            case 1:
                return "WEAK";
            case 2:
                return "MEDIUM";
            case 3:
                return "MEDIUM";
            case 4:
                return "STRONG";
            default:
                return "None";
        }
    }
}
