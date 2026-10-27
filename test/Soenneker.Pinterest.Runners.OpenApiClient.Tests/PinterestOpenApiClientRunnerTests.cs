using Soenneker.Tests.HostedUnit;

namespace Soenneker.Pinterest.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class PinterestOpenApiClientRunnerTests : HostedUnitTest
{
    public PinterestOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
