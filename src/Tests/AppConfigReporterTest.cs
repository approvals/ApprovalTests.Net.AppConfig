using ApprovalTests.Reporters;
using Xunit;

public class AppConfigReporterTest
{
    [Fact]
    public void Test()
    {
        Assert.IsType<DiffReporter>(new AppConfigReporter().Reporter);
    }
}