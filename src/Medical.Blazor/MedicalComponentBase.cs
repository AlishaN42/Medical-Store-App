using Medical.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Medical.Blazor;

public abstract class MedicalComponentBase : AbpComponentBase
{
    protected MedicalComponentBase()
    {
        LocalizationResource = typeof(MedicalResource);
    }
}
