using Medical.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Medical.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MedicalEntityFrameworkCoreModule),
    typeof(MedicalApplicationContractsModule)
    )]
public class MedicalDbMigratorModule : AbpModule
{

}
