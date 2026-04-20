using System.Threading.Tasks;
using Soenneker.Utils.Environment;

namespace Soenneker.Tests.Attributes.Local;

/// <summary>
/// Run locally, skip in pipelines.
/// </summary>
public sealed class LocalOnlyAttribute : SkipAttribute
{
    private const string DefaultSkip = "Local only";

    public LocalOnlyAttribute(string? reason = null) : base(string.IsNullOrWhiteSpace(reason) ? DefaultSkip : $"{DefaultSkip}: {reason}")
    {
    }

    public override Task<bool> ShouldSkip(TestRegisteredContext context)
    {
        return Task.FromResult(EnvironmentUtil.IsPipeline);
    }
}