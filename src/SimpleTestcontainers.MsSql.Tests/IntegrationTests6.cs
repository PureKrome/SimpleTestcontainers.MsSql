namespace SimpleTestcontainers.MsSql.Tests;

public class IntegrationTests6(SqlServerFixture SqlServerFixture, ITestOutputHelper TestOutputHelper)
    : CommonIntegrationTests(SqlServerFixture, TestOutputHelper)
{    
}
