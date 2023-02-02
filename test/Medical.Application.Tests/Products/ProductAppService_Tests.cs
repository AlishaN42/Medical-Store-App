using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Validation;
using Xunit;

namespace Medical.Products;

public class ProductAppService_Tests : MedicalApplicationTestBase
{
    private readonly IProductAppService _ProductAppService;

    public ProductAppService_Tests()
    {
        _ProductAppService = GetRequiredService<IProductAppService>();
    }

    [Fact]
    public async Task Should_Get_List_Of_Products()
    {
        //Act
        var result = await _ProductAppService.GetListAsync(
            new PagedAndSortedResultRequestDto()
        );

        //Assert
        result.TotalCount.ShouldBeGreaterThan(0);
        result.Items.ShouldContain(b => b.Name == "1984");
    }
    [Fact]
    public async Task Should_Create_A_Valid_Product()
    {
        //Act
        var result = await _ProductAppService.CreateAsync(
            new CreateUpdateProductDto
            {
                Name = "New test book 42",
                Price = 10,
                PublishDate = DateTime.Now,
                Type = ProductType.Homeopathy
            }
        );

        //Assert
        result.Id.ShouldNotBe(Guid.Empty);
        result.Name.ShouldBe("New test book 42");
    }

    [Fact]
    public async Task Should_Not_Create_A_Product_Without_Name()
    {
        var exception = await Assert.ThrowsAsync<AbpValidationException>(async () =>
        {
            await _ProductAppService.CreateAsync(
                new CreateUpdateProductDto
                {
                    Name = "",
                    Price = 10,
                    PublishDate = DateTime.Now,
                    Type = ProductType.Homeopathy
                }
            );
        });

        exception.ValidationErrors
            .ShouldContain(err => err.MemberNames.Any(mem => mem == "Name"));
    }
}
