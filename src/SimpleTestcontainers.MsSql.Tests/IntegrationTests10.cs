namespace SimpleTestcontainers.MsSql.Tests;

public class IntegrationTests10(SqlServerFixture SqlServerFixture, ITestOutputHelper TestOutputHelper)
    : CommonIntegrationTests(SqlServerFixture, TestOutputHelper)
{    
}
