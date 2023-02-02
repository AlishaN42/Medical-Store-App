using Medical.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Medical;

    public class MedicalDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Product, Guid> _ProductRepository;

    public MedicalDataSeederContributor(IRepository<Product, Guid> ProductRepository)
    {
        _ProductRepository = ProductRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _ProductRepository.GetCountAsync() <= 0)
        {
            await _ProductRepository.InsertAsync(
                new Product
                {
                    Name = "Omea",
                    Type = ProductType.Allopathy,
                    PublishDate = new DateTime(1949, 6, 8),
                    Price = 19.84f
                },
                autoSave: true
            );

            await _ProductRepository.InsertAsync(
                new Product
                {
                    Name = "Naturo",
                    Type = ProductType.Homeopathy,
                    PublishDate = new DateTime(1995, 9, 27),
                    Price = 42.0f
                },
                autoSave: true
            );
        }
    }
}