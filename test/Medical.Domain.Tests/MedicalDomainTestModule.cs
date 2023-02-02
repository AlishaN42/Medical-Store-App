using Medical.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Medical;

[DependsOn(
    typeof(MedicalEntityFrameworkCoreTestModule)
    )]
public class MedicalDomainTestModule : AbpModule
{

}
