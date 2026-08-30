[![](https://img.shields.io/nuget/v/soenneker.tests.attributes.local.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.tests.attributes.local/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.tests.attributes.local/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.tests.attributes.local/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.tests.attributes.local.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.tests.attributes.local/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.tests.attributes.local/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.tests.attributes.local/actions/workflows/codeql.yml)

# Soenneker.Tests.Attributes.Local

A TUnit skip attribute for tests that should run on a developer machine but not in a detected CI pipeline.

## Installation

```bash
dotnet add package Soenneker.Tests.Attributes.Local
```

## Usage

```csharp
using Soenneker.Tests.Attributes.Local;

public sealed class BrowserTests
{
    [Test]
    [LocalOnly("requires an interactive browser profile")]
    public async Task Uses_local_browser_profile()
    {
        // ...
    }
}
```

When `Soenneker.Utils.Environment.EnvironmentUtil.IsPipeline` is `true`, TUnit reports the test as skipped. Otherwise, the test executes normally. The optional reason is appended to the default `Local only` skip message.

`LocalOnly` does not verify that required local services, credentials, files, or applications are available. Keep the test's own setup explicit, and use a normal conditional skip when availability requires a more specific check.
