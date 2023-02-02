using System;
using System.Collections.Generic;
using System.Text;
using Medical.Localization;
using Volo.Abp.Application.Services;

namespace Medical;

/* Inherit your application services from this class.
 */
public abstract class MedicalAppService : ApplicationService
{
    protected MedicalAppService()
    {
        LocalizationResource = typeof(MedicalResource);
    }
}
