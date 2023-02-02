using Medical.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Medical.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MedicalController : AbpControllerBase
{
    protected MedicalController()
    {
        LocalizationResource = typeof(MedicalResource);
    }
}
