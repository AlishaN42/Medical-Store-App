using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Medical.Data;

/* This is used if database provider does't define
 * IMedicalDbSchemaMigrator implementation.
 */
public class NullMedicalDbSchemaMigrator : IMedicalDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
