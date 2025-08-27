using ClassLibrary1;
namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void main()
    {
        string password = "Password";
        string result = Class1.passCheck(password);
        Assert.Equal("MEDIUM", result);
    }
}