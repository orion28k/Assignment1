using System.Runtime.CompilerServices;

namespace ClassLibrary1;
public class Class1
{
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
