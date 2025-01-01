namespace SimpleTestcontainers.MsSql.Tests;

public class IntegrationTests5(SqlServerFixture SqlServerFixture, ITestOutputHelper TestOutputHelper)
    : CommonIntegrationTests(SqlServerFixture, TestOutputHelper)
{    
}
