using Volo.Abp.Modularity;

namespace Medical;

[DependsOn(
    typeof(MedicalApplicationModule),
    typeof(MedicalDomainTestModule)
    )]
public class MedicalApplicationTestModule : AbpModule
{

}
