namespace SimpleTestcontainers.MsSql.Tests;

public class IntegrationTests9(SqlServerFixture SqlServerFixture, ITestOutputHelper TestOutputHelper)
    : CommonIntegrationTests(SqlServerFixture, TestOutputHelper)
{    
}