using System.Data.Common;
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
        Assert.Equal("STRONG", Class1.passCheck("+aA1000000"));
    }

    [Fact]
    public void ShouldCountLengthGreaterThan8()
    {
        Assert.Equal("STRONG", Class1.passCheck("+aAAAAAA1"));
    }

    [Fact]
    public void ShouldGenerateValidV4UuidString()
    {
        string id = Class1.CreateV4UuidString();

        Assert.Equal(36, id.Length);
        Assert.Equal('-', id[8]);
        Assert.Equal('-', id[13]);
        Assert.Equal('-', id[18]);
        Assert.Equal('-', id[23]);

        Assert.Equal('4', id[14]);
        Assert.Contains(id[19], new[] { '8', '9', 'a', 'A', 'b', 'B' });

        Guid parsed = Guid.Parse(id);
        Assert.NotEqual(Guid.Empty, parsed);
    }

    [Fact]
    public void ShouldGenerateUniqueV4UuidString()
    {
        List<string> id = new List<string>();

        foreach (int i in Enumerable.Range(0, 10))
            id.Add(Class1.CreateV4UuidString());
        
        Assert.Equal(id.Count, id.Distinct().Count());
    }
}