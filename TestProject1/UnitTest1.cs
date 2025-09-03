using ClassLibrary1;
namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void ShouldReturnIneligableForNullString()
    {
        Assert.Equal("INELIGABLE", Class1.passCheck(""));
    }

    [Fact]
    public void ShouldReturnWeakForOneCase()
    {
        Assert.Equal("WEAK", Class1.passCheck("a"));
    }

    [Fact]
    public void ShouldReturnMediumForTwoCases()
    {
        Assert.Equal("MEDIUM", Class1.passCheck("aA"));
    }

    [Fact]
    public void ShouldReturnMediumForThreeCases()
    {
        Assert.Equal("MEDIUM", Class1.passCheck("aA1"));
    }

    [Fact]
    public void ShouldReturnStrongForFourCases()
    {
        Assert.Equal("STRONG", Class1.passCheck("@aA1"));
    }

    [Fact]
    public void ShouldCountLengthGreaterThan8()
    {
        Assert.Equal("STRONG", Class1.passCheck("@aAAAAAA"));
    }
}