using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Medical.Blazor;

[Dependency(ReplaceServices = true)]
public class MedicalBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Medical";
}
