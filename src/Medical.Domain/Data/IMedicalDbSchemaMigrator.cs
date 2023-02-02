using System.Threading.Tasks;

namespace Medical.Data;

public interface IMedicalDbSchemaMigrator
{
    Task MigrateAsync();
}
